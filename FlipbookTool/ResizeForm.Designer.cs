
namespace FlipbookTool
{
    partial class ResizeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResizeForm));
            this.Title = new System.Windows.Forms.Label();
            this.CloseButton = new System.Windows.Forms.Button();
            this.ImportButton = new System.Windows.Forms.Button();
            this.ExportButton = new System.Windows.Forms.Button();
            this.ImageFrame = new System.Windows.Forms.PictureBox();
            this.Title2 = new System.Windows.Forms.Label();
            this.WidthTextbox = new System.Windows.Forms.TextBox();
            this.HeightTextbox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.ImageFrame)).BeginInit();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Title.AutoSize = true;
            this.Title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.Title.Cursor = System.Windows.Forms.Cursors.Default;
            this.Title.Font = new System.Drawing.Font("Gadugi", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.White;
            this.Title.Location = new System.Drawing.Point(7, 12);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(148, 31);
            this.Title.TabIndex = 1;
            this.Title.Text = "Resize Tool";
            this.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseButton.FlatAppearance.BorderSize = 0;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Font = new System.Drawing.Font("Comic Sans MS", 14F);
            this.CloseButton.ForeColor = System.Drawing.Color.White;
            this.CloseButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.CloseButton.Location = new System.Drawing.Point(355, 7);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(40, 40);
            this.CloseButton.TabIndex = 5;
            this.CloseButton.Text = "X";
            this.CloseButton.UseVisualStyleBackColor = false;
            // 
            // ImportButton
            // 
            this.ImportButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ImportButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ImportButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ImportButton.FlatAppearance.BorderSize = 0;
            this.ImportButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ImportButton.Font = new System.Drawing.Font("Gadugi", 18F);
            this.ImportButton.ForeColor = System.Drawing.Color.White;
            this.ImportButton.Location = new System.Drawing.Point(12, 246);
            this.ImportButton.Name = "ImportButton";
            this.ImportButton.Size = new System.Drawing.Size(186, 42);
            this.ImportButton.TabIndex = 6;
            this.ImportButton.Text = "Import";
            this.ImportButton.UseVisualStyleBackColor = false;
            // 
            // ExportButton
            // 
            this.ExportButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ExportButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ExportButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExportButton.FlatAppearance.BorderSize = 0;
            this.ExportButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExportButton.Font = new System.Drawing.Font("Gadugi", 18F);
            this.ExportButton.ForeColor = System.Drawing.Color.White;
            this.ExportButton.Location = new System.Drawing.Point(204, 246);
            this.ExportButton.Name = "ExportButton";
            this.ExportButton.Size = new System.Drawing.Size(186, 42);
            this.ExportButton.TabIndex = 7;
            this.ExportButton.Text = "Export";
            this.ExportButton.UseVisualStyleBackColor = false;
            // 
            // ImageFrame
            // 
            this.ImageFrame.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ImageFrame.Location = new System.Drawing.Point(13, 54);
            this.ImageFrame.Name = "ImageFrame";
            this.ImageFrame.Size = new System.Drawing.Size(186, 186);
            this.ImageFrame.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImageFrame.TabIndex = 8;
            this.ImageFrame.TabStop = false;
            // 
            // Title2
            // 
            this.Title2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Title2.AutoSize = true;
            this.Title2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.Title2.Cursor = System.Windows.Forms.Cursors.Default;
            this.Title2.Font = new System.Drawing.Font("Gadugi", 18F);
            this.Title2.ForeColor = System.Drawing.Color.White;
            this.Title2.Location = new System.Drawing.Point(210, 54);
            this.Title2.Name = "Title2";
            this.Title2.Size = new System.Drawing.Size(180, 28);
            this.Title2.TabIndex = 9;
            this.Title2.Text = "New Resolution";
            this.Title2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WidthTextbox
            // 
            this.WidthTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.WidthTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.WidthTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.WidthTextbox.Font = new System.Drawing.Font("Gadugi", 20F);
            this.WidthTextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(178)))), ((int)(((byte)(178)))));
            this.WidthTextbox.Location = new System.Drawing.Point(215, 101);
            this.WidthTextbox.Name = "WidthTextbox";
            this.WidthTextbox.Size = new System.Drawing.Size(136, 36);
            this.WidthTextbox.TabIndex = 10;
            this.WidthTextbox.Text = "Width";
            this.WidthTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // HeightTextbox
            // 
            this.HeightTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.HeightTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.HeightTextbox.Cursor = System.Windows.Forms.Cursors.No;
            this.HeightTextbox.Font = new System.Drawing.Font("Gadugi", 20F);
            this.HeightTextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(178)))), ((int)(((byte)(178)))));
            this.HeightTextbox.Location = new System.Drawing.Point(215, 172);
            this.HeightTextbox.Name = "HeightTextbox";
            this.HeightTextbox.ReadOnly = true;
            this.HeightTextbox.Size = new System.Drawing.Size(136, 36);
            this.HeightTextbox.TabIndex = 11;
            this.HeightTextbox.Text = "Height";
            this.HeightTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(357, 120);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(19, 3);
            this.panel1.TabIndex = 12;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(357, 191);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(19, 3);
            this.panel2.TabIndex = 13;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(373, 123);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(3, 70);
            this.panel3.TabIndex = 13;
            // 
            // ResizeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(402, 298);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.HeightTextbox);
            this.Controls.Add(this.WidthTextbox);
            this.Controls.Add(this.Title2);
            this.Controls.Add(this.ImageFrame);
            this.Controls.Add(this.ExportButton);
            this.Controls.Add(this.ImportButton);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.Title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ResizeForm";
            this.Text = "ResizeForm";
            ((System.ComponentModel.ISupportInitialize)(this.ImageFrame)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button ImportButton;
        private System.Windows.Forms.Button ExportButton;
        private System.Windows.Forms.PictureBox ImageFrame;
        private System.Windows.Forms.Label Title2;
        private System.Windows.Forms.TextBox WidthTextbox;
        private System.Windows.Forms.TextBox HeightTextbox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}