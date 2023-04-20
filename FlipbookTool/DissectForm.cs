using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ImageProcessor;

namespace FlipbookTool
{
    public partial class DissectForm : Form
    {
        public DissectForm()
        {
            InitializeComponent();

            Utils.RoundCorners(this);
            Utils.RoundCorners(this.RowsTextbox);
            Utils.RoundCorners(this.ColumnsTextbox);
            Utils.MakeDraggable(this, Handle);
            Utils.MakeDraggable(this.Title, Handle);
            Utils.MakeDraggable(this.Title2, Handle);
            Utils.MakeDraggable(this.ImageFrame, Handle);
            Utils.SetupButton(this.ImportButton);
            Utils.SetupButton(this.DissectButton);
            Utils.SetupButton(this.CloseButton);

            Utils.SetupTextBoxPlaceholder(this.RowsTextbox);
            Utils.LimitTextboxToNumbers(this.RowsTextbox);

            Utils.SetupTextBoxPlaceholder(this.ColumnsTextbox);
            Utils.LimitTextboxToNumbers(this.ColumnsTextbox);

            CloseButton.MouseClick += (s, e) =>
            {
                this.Hide();
            };

            ImportButton.MouseClick += (s, e) =>
            {
                Image importedImage = Utils.OpenImageDialog();
                if (importedImage != null)
                {
                    ImageFrame.Image = importedImage;
                }
            };

            DissectButton.MouseClick += async (s, e) =>
            {
                String rowsText = RowsTextbox.Text;
                String columnsText = ColumnsTextbox.Text;
                Image image = ImageFrame.Image;


                if (image == null)
                {
                    ImageFrame.BackColor = Color.FromArgb(244, 41, 41);
                    await Task.Delay(200);
                    ImageFrame.BackColor = Color.FromArgb(20, 20, 20);
                    await Task.Delay(200);
                    ImageFrame.BackColor = Color.FromArgb(244, 41, 41);
                    await Task.Delay(200);
                    ImageFrame.BackColor = Color.FromArgb(20, 20, 20);
                    return;
                }

                int rows;

                if (!int.TryParse(rowsText, out rows))
                {
                    RowsTextbox.BackColor = Color.FromArgb(244, 41, 41);
                    await Task.Delay(200);
                    RowsTextbox.BackColor = Color.FromArgb(40, 40, 40);
                    await Task.Delay(200);
                    RowsTextbox.BackColor = Color.FromArgb(244, 41, 41);
                    await Task.Delay(200);
                    RowsTextbox.BackColor = Color.FromArgb(40, 40, 40);
                    return;
                };

                int columns;

                if (!int.TryParse(columnsText, out columns))
                {
                    ColumnsTextbox.BackColor = Color.FromArgb(244, 41, 41);
                    await Task.Delay(200);
                    ColumnsTextbox.BackColor = Color.FromArgb(40, 40, 40);
                    await Task.Delay(200);
                    ColumnsTextbox.BackColor = Color.FromArgb(244, 41, 41);
                    await Task.Delay(200);
                    ColumnsTextbox.BackColor = Color.FromArgb(40, 40, 40);
                    return;
                };

                rows = (rows == 0 ? 1 : rows);
                columns = (columns == 0 ? 1 : columns);

                String folderName = Utils.SaveFolderDialog();
                if (folderName != null)
                {

                    int XSize = image.Width / columns;
                    int YSize = image.Height / rows;

                    Size imageSize = new Size();
                    imageSize.Width = XSize;
                    imageSize.Height = YSize;

                    for (int row = 1; row <= rows; row++)
                    {
                        for (int column = 1; column <= columns; column++)
                            {
                            ImageFactory editor = new ImageFactory();
                            editor.Load(image);

                            Point imagePosition = new Point();
                            imagePosition.X = (column - 1) * XSize;
                            imagePosition.Y = (row - 1) * YSize;

                            Rectangle cropRectangle = new Rectangle(imagePosition, imageSize);

                            editor.Crop(cropRectangle);
                            editor.Format(new ImageProcessor.Imaging.Formats.PngFormat());

                            editor.Save(folderName + "\\Dissect_" + row + column + ".png");
                            editor.Dispose();
                        }
                    }
                }
            };
        }
    }
}
