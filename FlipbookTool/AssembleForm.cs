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
    public partial class AssembleForm : Form
    {
        public AssembleForm()
        {
            InitializeComponent();


            Utils.RoundCorners(this);
            Utils.RoundCorners(this.RowsTextbox);
            Utils.RoundCorners(this.ColumnsTextbox);
            Utils.MakeDraggable(this, Handle);
            Utils.MakeDraggable(this.Title, Handle);
            Utils.MakeDraggable(this.Title2, Handle);
            Utils.MakeDraggable(this.pictureBackground, Handle);
            Utils.SetupButton(this.ImportButton);
            Utils.SetupButton(this.CloseButton);
            Utils.SetupButton(this.ExportButton);

            Utils.SetupTextBoxPlaceholder(this.RowsTextbox);
            Utils.LimitTextboxToNumbers(this.RowsTextbox);

            Utils.SetupTextBoxPlaceholder(this.ColumnsTextbox);
            Utils.LimitTextboxToNumbers(this.ColumnsTextbox);

            CloseButton.MouseClick += (s, e) =>
            {
                this.Hide();
            };

            PictureBox[] imageList = new PictureBox[64];

            async void formatChanged(object s, EventArgs e)
            {
                String rowsText = RowsTextbox.Text;
                String columnsText = ColumnsTextbox.Text;

                int rows, columns;

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

                if (rows > 8) { rows = 8; RowsTextbox.Text = "8";  };
                if (columns > 8) { columns = 8; ColumnsTextbox.Text = "8";  };

                if (rows < 1) { rows = 1; RowsTextbox.Text = "1"; };
                if (columns < 1) { columns = 1; ColumnsTextbox.Text = "1"; };

                for (int i = 0; i<64; i++)
                {
                    PictureBox box = imageList[i];
                    if (box != null)
                    {
                        box.Dispose();
                    }
                };


                //pictureBackground.Visible = false;

                int counter = 0;
                int YSize = pictureBackground.Height / rows;
                int XSize = pictureBackground.Width / columns;

                Point boxLocation = pictureBackground.Location;

                for (int row = 1; row <= rows; row++)
                {
                    for (int column = 1; column <= columns; column++)
                    {

                        Point imagePosition = new Point();
                        imagePosition.X = ((column - 1) * XSize);
                        imagePosition.Y = ((row - 1) * YSize);

                        PictureBox box = new PictureBox();

                        box.Location    = imagePosition;
                        box.Size        = new Size(XSize, YSize);
                        box.BackColor   = Color.FromArgb(20, 20, 20);
                        box.BorderStyle = BorderStyle.FixedSingle;
                        box.TabIndex    = 36;
                        box.SizeMode    = PictureBoxSizeMode.StretchImage;
                        box.TabStop     = false;
                        box.Name        = "Frame" + counter;
                        box.Parent      = pictureBackground;

                        box.Show();

                        imageList[counter] = box;

                        counter++;

                    }
                }

            };

            RowsTextbox.TextChanged += formatChanged;
            ColumnsTextbox.TextChanged += formatChanged;

            ImportButton.MouseClick += async (s, e) =>
            {
                int rows;

                if (!int.TryParse(RowsTextbox.Text, out rows))
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

                if (!int.TryParse(ColumnsTextbox.Text, out columns))
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

                Image[] importedImages = Utils.OpenImagesDialog();

                if(importedImages != null)
                {
                    for(int i = 0; i<importedImages.Length; i++)
                    {
                        PictureBox box = imageList[i];
                        if (box != null)
                        {
                            box.Image = importedImages[i];
                        }
                    }
                }

            };

            ExportButton.MouseClick += async (s, e) =>
            {
                int rows;

                if (!int.TryParse(RowsTextbox.Text, out rows))
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

                if (!int.TryParse(ColumnsTextbox.Text, out columns))
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

                Image firstImage = imageList[0].Image;

                if (firstImage != null)
                {
                    int XSize = firstImage.Width;
                    int YSize = firstImage.Height;

                    Bitmap finalImage = new Bitmap(XSize * columns, YSize * rows);

                    Graphics g = Graphics.FromImage(finalImage);

                    int counter = 0;

                    for (int row = 1; row <= rows; row++)
                    {
                        for (int column = 1; column <= columns; column++)
                        {
                            Image frame = imageList[counter].Image;
                            if (frame != null)
                            {
                                Point imagePosition = new Point();
                                imagePosition.X = ((column - 1) * XSize);
                                imagePosition.Y = ((row - 1) * YSize);

                                ImageFactory factory = new ImageFactory();
                                factory.Load(frame);

                                Size newImageSize = new Size();
                                newImageSize.Width = XSize;
                                newImageSize.Height = YSize;

                                ImageProcessor.Imaging.ResizeLayer resize = new ImageProcessor.Imaging.ResizeLayer(newImageSize, ImageProcessor.Imaging.ResizeMode.Stretch);

                                factory.Resize(resize);

                                g.DrawImage(factory.Image, imagePosition);

                            } else
                            {
                                break;
                            }

                            counter++;
                        }
                    }

                    String fileName = Utils.SaveImageDialog();
                    if (fileName != null)
                    {
                        ImageFactory factory = new ImageFactory();
                        factory.Load(finalImage);
                        factory.Format(new ImageProcessor.Imaging.Formats.PngFormat());
                        factory.Save(fileName);
                    }
                }
            };

        }

    }
}
