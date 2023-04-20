using System;
using System.Drawing;
using System.Windows.Forms;
using System.Threading.Tasks;
using ImageProcessor;

namespace FlipbookTool
{
    public partial class ResizeForm : Form
    {
        public ResizeForm()
        {
            InitializeComponent();

            Utils.RoundCorners(this);
            Utils.RoundCorners(this.WidthTextbox);
            Utils.RoundCorners(this.HeightTextbox);
            Utils.MakeDraggable(this, Handle);
            Utils.MakeDraggable(this.Title, Handle);
            Utils.MakeDraggable(this.Title2, Handle);
            Utils.MakeDraggable(this.panel1, Handle);
            Utils.MakeDraggable(this.panel2, Handle);
            Utils.MakeDraggable(this.panel3, Handle);
            Utils.MakeDraggable(this.ImageFrame, Handle);
            Utils.SetupButton(this.ImportButton);
            Utils.SetupButton(this.ExportButton);
            Utils.SetupButton(this.CloseButton);

            Utils.SetupTextBoxPlaceholder(this.WidthTextbox);
            Utils.LimitTextboxToNumbers(this.WidthTextbox);

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

            WidthTextbox.TextChanged += (s, e) =>
            {
                if (WidthTextbox.Text == "Width")
                {
                    HeightTextbox.Text = "Height";
                    HeightTextbox.ForeColor = Color.FromArgb(178, 178, 178);
                }
                else
                {
                    HeightTextbox.Text = WidthTextbox.Text;
                    HeightTextbox.ForeColor = Color.White;
                }
            };

            ExportButton.MouseClick += async (s, e) =>
            {
                String Width = WidthTextbox.Text;
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

                int dimension;

                if (!int.TryParse(Width, out dimension))
                {
                    WidthTextbox.BackColor = Color.FromArgb(244, 41, 41);
                    await Task.Delay(200);
                    WidthTextbox.BackColor = Color.FromArgb(40, 40, 40);
                    await Task.Delay(200);
                    WidthTextbox.BackColor = Color.FromArgb(244, 41, 41);
                    await Task.Delay(200);
                    WidthTextbox.BackColor = Color.FromArgb(40, 40, 40);
                    return;
                };

                dimension = (dimension == 0 ? 1 : dimension);

                Size newImageSize = new Size();
                newImageSize.Width = dimension;
                newImageSize.Height = dimension;

                ImageProcessor.Imaging.ResizeLayer resize = new ImageProcessor.Imaging.ResizeLayer(newImageSize, ImageProcessor.Imaging.ResizeMode.Stretch);

                ImageFactory editor = new ImageFactory();
                editor.Load(image).Resize(resize).Format(new ImageProcessor.Imaging.Formats.PngFormat());

                String fileName = Utils.SaveImageDialog();
                if (fileName != null)
                {
                    editor.Save(fileName);
                }
                        

            };

        }

    }
}
