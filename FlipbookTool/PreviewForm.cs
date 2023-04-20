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
    public partial class PreviewForm : Form
    {
        public PreviewForm()
        {
            InitializeComponent();

            Utils.RoundCorners(this);
            Utils.RoundCorners(this.RowsTextbox);
            Utils.RoundCorners(this.ColumnsTextbox);
            Utils.RoundCorners(this.SecondsTextbox);
            Utils.MakeDraggable(this, Handle);
            Utils.MakeDraggable(this.Title, Handle);
            Utils.MakeDraggable(this.Title2, Handle);
            Utils.MakeDraggable(this.ImageFrame, Handle);
            Utils.MakeDraggable(this.OutputFrame, Handle);
            Utils.SetupButton(this.ImportButton);
            Utils.SetupButton(this.PlayButton);
            Utils.SetupButton(this.CloseButton);

            Utils.SetupTextBoxPlaceholder(this.RowsTextbox);
            Utils.LimitTextboxToNumbers(this.RowsTextbox);

            Utils.SetupTextBoxPlaceholder(this.ColumnsTextbox);
            Utils.LimitTextboxToNumbers(this.ColumnsTextbox);

            Utils.SetupTextBoxPlaceholder(this.SecondsTextbox);
            Utils.LimitTextboxToNumbers(this.SecondsTextbox);

            CloseButton.MouseClick += (s, e) =>
            {
                this.Hide();
            };

            long lastTimeImport = 0;
            long lastTimePlay = 0;
            int lastRows = 0;
            int lastColumns = 0;
            Image[] lastFrames = new Image[64];

            ImportButton.MouseClick += (s, e) =>
            {
                Image importedImage = Utils.OpenImageDialog();
                if (importedImage != null)
                {
                    ImageFrame.Image = importedImage;
                    lastTimeImport = DateTime.Now.Ticks;
                }
            };

            PlayButton.MouseClick += async (s, e) =>
            {
                String rowsText = RowsTextbox.Text;
                String columnsText = ColumnsTextbox.Text;
                String secondsText = SecondsTextbox.Text;
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

                float seconds;

                if (!float.TryParse(secondsText, out seconds))
                {
                    SecondsTextbox.BackColor = Color.FromArgb(244, 41, 41);
                    await Task.Delay(200);
                    SecondsTextbox.BackColor = Color.FromArgb(40, 40, 40);
                    await Task.Delay(200);
                    SecondsTextbox.BackColor = Color.FromArgb(244, 41, 41);
                    await Task.Delay(200);
                    SecondsTextbox.BackColor = Color.FromArgb(40, 40, 40);
                    return;
                };

                rows = (rows == 0 ? 1 : rows);
                columns = (columns == 0 ? 1 : columns);
                seconds = (seconds == 0 ? 0.1f : seconds);

                Image[] frames = new Image[64];

                if (lastTimeImport > lastTimePlay || rows != lastRows || columns != lastColumns)
                {
                    int XSize = image.Width / columns;
                    int YSize = image.Height / rows;

                    Size imageSize = new Size();
                    imageSize.Width = XSize;
                    imageSize.Height = YSize;

                    int frameCount = rows * columns;

                    lastRows = rows;
                    lastColumns = columns;

                    frames = new Image[frameCount];

                    int i = 0;

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

                            frames[i] = editor.Image;
                            i++;

                        }
                    }
                }
                else
                {
                    frames = lastFrames;
                }

                lastTimePlay = DateTime.Now.Ticks;
                lastFrames = frames;

                int DelayTime = (int)(seconds * 1000) / (lastFrames.Length);

                for (int frame = 0; frame < (lastFrames.Length); frame++)
                {
                    OutputFrame.Image = lastFrames[frame];
                    await Task.Delay(DelayTime);
                }

                OutputFrame.Image = null;
            };
        }
    }
}
