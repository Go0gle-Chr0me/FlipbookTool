using System;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace FlipbookTool
{
    public class Utils
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        public static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // width of ellipse
            int nHeightEllipse // height of ellipse
        );

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        public static void RoundCorners(Form form)
        {
            form.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, form.Width, form.Height, 10, 10));
        }

        public static void RoundCorners(Button form)
        {
            form.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, form.Width, form.Height, 10, 10));
        }

        public static void RoundCorners(TextBox form)
        {
            form.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, form.Width, form.Height, 10, 10));
        }

        public static void MakeDraggable(Form form, IntPtr Handle)
        {
            form.MouseDown += (s, e) =>
            {
                if (e.Button == MouseButtons.Left)
                {
                    ReleaseCapture();
                    SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
                }
            };
        }

        public static void MakeDraggable(Label form, IntPtr Handle)
        {
            form.MouseDown += (s, e) =>
            {
                if (e.Button == MouseButtons.Left)
                {
                    ReleaseCapture();
                    SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
                }
            };
        }

        public static void MakeDraggable(Panel form, IntPtr Handle)
        {
            form.MouseDown += (s, e) =>
            {
                if (e.Button == MouseButtons.Left)
                {
                    ReleaseCapture();
                    SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
                }
            };
        }

        public static void MakeDraggable(PictureBox form, IntPtr Handle)
        {
            form.MouseDown += (s, e) =>
            {
                if (e.Button == MouseButtons.Left)
                {
                    ReleaseCapture();
                    SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
                }
            };
        }

        public static void SetupButton(Button form)
        {
            RoundCorners(form);
            form.MouseEnter += (s, e) =>
            {
                form.BackColor = Color.FromArgb(244, 41, 41);
            };

            form.MouseLeave += (s, e) =>
            {
                form.BackColor = Color.FromArgb(40, 40, 40);
            };
        }

        public static void SetupTextBoxPlaceholder(TextBox textbox)
        {
            String placeholder      = textbox.Text;
            Color placeholderColor  = textbox.ForeColor;

            textbox.GotFocus += (s, e) =>
            {
                if (textbox.Text == placeholder)
                {
                    textbox.Text = "";
                    textbox.ForeColor = Color.White;
                };
            };

            textbox.LostFocus += (s, e) =>
            {
                if (textbox.Text == "")
                {
                    textbox.Text = placeholder;
                    textbox.ForeColor = placeholderColor;
                };
            };
        }

        public static void LimitTextboxToNumbers(TextBox textbox)
        {
            textbox.KeyPress += (s, e) =>
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
                {
                    e.Handled = true;
                };
            };
        }

        public static Image OpenImageDialog()
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                Title = "Browse Image Files",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "png",
                Filter = "Images (*.BMP;*.JPG;*.GIF,*.PNG,*.TIFF)|*.BMP;*.JPG;*.GIF;*.PNG;*.TIFF",
                RestoreDirectory = true,
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                return Image.FromFile(openFileDialog1.FileName);
            }

            return null;
        }

        public static Image[] OpenImagesDialog()
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                Title = "Browse Image Files",

                CheckFileExists = true,
                CheckPathExists = true,
                Multiselect = true,

                DefaultExt = "png",
                Filter = "Images (*.BMP;*.JPG;*.GIF,*.PNG,*.TIFF)|*.BMP;*.JPG;*.GIF;*.PNG;*.TIFF",
                RestoreDirectory = true,
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Image[] imageList = new Image[openFileDialog1.FileNames.Length];

                int i = 0;
                foreach (string fileName in openFileDialog1.FileNames)
                {
                    imageList[i] = Image.FromFile(fileName);
                    i++;
                }

                return imageList;
            };

            return null;
        }

        public static String SaveImageDialog()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Title = "Browse Image Files",

                DefaultExt = "png",
                Filter = "Image (*.PNG)|*.PNG;",
                RestoreDirectory = true,
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                return saveFileDialog.FileName;
            }

            return null;
        }

        public static String SaveFolderDialog()
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                return folderBrowserDialog.SelectedPath;
            }

            return null;
        }
    }
}
