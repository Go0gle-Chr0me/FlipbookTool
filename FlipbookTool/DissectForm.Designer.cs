
namespace FlipbookTool
{
    partial class DissectForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DissectForm));
            this.ImageFrame = new System.Windows.Forms.PictureBox();
            this.ImportButton = new System.Windows.Forms.Button();
            this.DissectButton = new System.Windows.Forms.Button();
            this.Title = new System.Windows.Forms.Label();
            this.CloseButton = new System.Windows.Forms.Button();
            this.ColumnsTextbox = new System.Windows.Forms.TextBox();
            this.RowsTextbox = new System.Windows.Forms.TextBox();
            this.Title2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ImageFrame)).BeginInit();
            this.SuspendLayout();
            // 
            // ImageFrame
            // 
            this.ImageFrame.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ImageFrame.Location = new System.Drawing.Point(12, 52);
            this.ImageFrame.Name = "ImageFrame";
            this.ImageFrame.Size = new System.Drawing.Size(186, 186);
            this.ImageFrame.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImageFrame.TabIndex = 9;
            this.ImageFrame.TabStop = false;
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
            this.ImportButton.Location = new System.Drawing.Point(12, 244);
            this.ImportButton.Name = "ImportButton";
            this.ImportButton.Size = new System.Drawing.Size(186, 42);
            this.ImportButton.TabIndex = 10;
            this.ImportButton.Text = "Import";
            this.ImportButton.UseVisualStyleBackColor = false;
            // 
            // DissectButton
            // 
            this.DissectButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.DissectButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.DissectButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DissectButton.FlatAppearance.BorderSize = 0;
            this.DissectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DissectButton.Font = new System.Drawing.Font("Gadugi", 18F);
            this.DissectButton.ForeColor = System.Drawing.Color.White;
            this.DissectButton.Location = new System.Drawing.Point(204, 244);
            this.DissectButton.Name = "DissectButton";
            this.DissectButton.Size = new System.Drawing.Size(186, 42);
            this.DissectButton.TabIndex = 13;
            this.DissectButton.Text = "Dissect";
            this.DissectButton.UseVisualStyleBackColor = false;
            // 
            // Title
            // 
            this.Title.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Title.AutoSize = true;
            this.Title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.Title.Cursor = System.Windows.Forms.Cursors.Default;
            this.Title.Font = new System.Drawing.Font("Gadugi", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.White;
            this.Title.Location = new System.Drawing.Point(7, 9);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(157, 31);
            this.Title.TabIndex = 14;
            this.Title.Text = "Dissect Tool";
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
            this.CloseButton.Location = new System.Drawing.Point(355, 8);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(40, 40);
            this.CloseButton.TabIndex = 15;
            this.CloseButton.Text = "X";
            this.CloseButton.UseVisualStyleBackColor = false;
            // 
            // ColumnsTextbox
            // 
            this.ColumnsTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ColumnsTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ColumnsTextbox.Cursor = System.Windows.Forms.Cursors.Default;
            this.ColumnsTextbox.Font = new System.Drawing.Font("Gadugi", 20F);
            this.ColumnsTextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(178)))), ((int)(((byte)(178)))));
            this.ColumnsTextbox.Location = new System.Drawing.Point(225, 179);
            this.ColumnsTextbox.Name = "ColumnsTextbox";
            this.ColumnsTextbox.Size = new System.Drawing.Size(136, 36);
            this.ColumnsTextbox.TabIndex = 17;
            this.ColumnsTextbox.Text = "Columns";
            this.ColumnsTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // RowsTextbox
            // 
            this.RowsTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.RowsTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RowsTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.RowsTextbox.Font = new System.Drawing.Font("Gadugi", 20F);
            this.RowsTextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(178)))), ((int)(((byte)(178)))));
            this.RowsTextbox.Location = new System.Drawing.Point(225, 108);
            this.RowsTextbox.Name = "RowsTextbox";
            this.RowsTextbox.Size = new System.Drawing.Size(136, 36);
            this.RowsTextbox.TabIndex = 16;
            this.RowsTextbox.Text = "Rows";
            this.RowsTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Title2
            // 
            this.Title2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Title2.AutoSize = true;
            this.Title2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.Title2.Cursor = System.Windows.Forms.Cursors.Default;
            this.Title2.Font = new System.Drawing.Font("Gadugi", 18F);
            this.Title2.ForeColor = System.Drawing.Color.White;
            this.Title2.Location = new System.Drawing.Point(210, 61);
            this.Title2.Name = "Title2";
            this.Title2.Size = new System.Drawing.Size(186, 28);
            this.Title2.TabIndex = 18;
            this.Title2.Text = "Flipbook Format";
            this.Title2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DissectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(402, 298);
            this.Controls.Add(this.Title2);
            this.Controls.Add(this.ColumnsTextbox);
            this.Controls.Add(this.RowsTextbox);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.DissectButton);
            this.Controls.Add(this.ImportButton);
            this.Controls.Add(this.ImageFrame);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DissectForm";
            this.Text = "DissectForm";
            ((System.ComponentModel.ISupportInitialize)(this.ImageFrame)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ImageFrame;
        private System.Windows.Forms.Button ImportButton;
        private System.Windows.Forms.Button DissectButton;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.TextBox ColumnsTextbox;
        private System.Windows.Forms.TextBox RowsTextbox;
        private System.Windows.Forms.Label Title2;
    }
}