using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlipbookTool
{
    public partial class Menu : Form
    {

        private void SetupPromptFormButton(Button button, Form formObject)
        {

            button.MouseClick += (s, e) =>
            {

                formObject.Show();
            };

        }
        
        public Menu()
        {
            InitializeComponent();
            Utils.RoundCorners(this);
            Utils.MakeDraggable(this, Handle);
            Utils.MakeDraggable(this.Title, Handle);
            Utils.SetupButton(this.ResizeButton);
            Utils.SetupButton(this.DissectButton);
            Utils.SetupButton(this.AssembleButton);
            Utils.SetupButton(this.PreviewButton);
            Utils.SetupButton(this.CloseButton);

            CloseButton.MouseClick += (s, e) =>
            {
                Application.Exit();
            };

            SetupPromptFormButton(ResizeButton, new ResizeForm());
            SetupPromptFormButton(DissectButton, new DissectForm());
            SetupPromptFormButton(AssembleButton, new AssembleForm());
            SetupPromptFormButton(PreviewButton, new PreviewForm());
        }
    }
}
