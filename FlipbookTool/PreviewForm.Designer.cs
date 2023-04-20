
namespace FlipbookTool
{
    partial class PreviewForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PreviewForm));
            this.Title = new System.Windows.Forms.Label();
            this.CloseButton = new System.Windows.Forms.Button();
            this.ImageFrame = new System.Windows.Forms.PictureBox();
            this.ImportButton = new System.Windows.Forms.Button();
            this.Title2 = new System.Windows.Forms.Label();
            this.ColumnsTextbox = new System.Windows.Forms.TextBox();
            this.RowsTextbox = new System.Windows.Forms.TextBox();
            this.SecondsTextbox = new System.Windows.Forms.TextBox();
            this.OutputFrame = new System.Windows.Forms.PictureBox();
            this.PlayButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ImageFrame)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OutputFrame)).BeginInit();
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
            this.Title.Location = new System.Drawing.Point(10, 15);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(166, 31);
            this.Title.TabIndex = 15;
            this.Title.Text = "Preview Tool";
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
            this.CloseButton.Location = new System.Drawing.Point(581, 7);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(40, 40);
            this.CloseButton.TabIndex = 16;
            this.CloseButton.Text = "X";
            this.CloseButton.UseVisualStyleBackColor = false;
            // 
            // ImageFrame
            // 
            this.ImageFrame.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ImageFrame.Location = new System.Drawing.Point(12, 59);
            this.ImageFrame.Name = "ImageFrame";
            this.ImageFrame.Size = new System.Drawing.Size(186, 186);
            this.ImageFrame.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImageFrame.TabIndex = 17;
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
            this.ImportButton.Location = new System.Drawing.Point(12, 251);
            this.ImportButton.Name = "ImportButton";
            this.ImportButton.Size = new System.Drawing.Size(186, 42);
            this.ImportButton.TabIndex = 18;
            this.ImportButton.Text = "Import";
            this.ImportButton.UseVisualStyleBackColor = false;
            // 
            // Title2
            // 
            this.Title2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Title2.AutoSize = true;
            this.Title2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.Title2.Cursor = System.Windows.Forms.Cursors.Default;
            this.Title2.Font = new System.Drawing.Font("Gadugi", 18F);
            this.Title2.ForeColor = System.Drawing.Color.White;
            this.Title2.Location = new System.Drawing.Point(218, 59);
            this.Title2.Name = "Title2";
            this.Title2.Size = new System.Drawing.Size(186, 28);
            this.Title2.TabIndex = 21;
            this.Title2.Text = "Flipbook Format";
            this.Title2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ColumnsTextbox
            // 
            this.ColumnsTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ColumnsTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ColumnsTextbox.Cursor = System.Windows.Forms.Cursors.Default;
            this.ColumnsTextbox.Font = new System.Drawing.Font("Gadugi", 20F);
            this.ColumnsTextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(178)))), ((int)(((byte)(178)))));
            this.ColumnsTextbox.Location = new System.Drawing.Point(236, 178);
            this.ColumnsTextbox.Name = "ColumnsTextbox";
            this.ColumnsTextbox.Size = new System.Drawing.Size(136, 36);
            this.ColumnsTextbox.TabIndex = 20;
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
            this.RowsTextbox.Location = new System.Drawing.Point(236, 127);
            this.RowsTextbox.Name = "RowsTextbox";
            this.RowsTextbox.Size = new System.Drawing.Size(136, 36);
            this.RowsTextbox.TabIndex = 19;
            this.RowsTextbox.Text = "Rows";
            this.RowsTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SecondsTextbox
            // 
            this.SecondsTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.SecondsTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SecondsTextbox.Cursor = System.Windows.Forms.Cursors.Default;
            this.SecondsTextbox.Font = new System.Drawing.Font("Gadugi", 20F);
            this.SecondsTextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(178)))), ((int)(((byte)(178)))));
            this.SecondsTextbox.Location = new System.Drawing.Point(236, 229);
            this.SecondsTextbox.Name = "SecondsTextbox";
            this.SecondsTextbox.Size = new System.Drawing.Size(136, 36);
            this.SecondsTextbox.TabIndex = 22;
            this.SecondsTextbox.Text = "Seconds";
            this.SecondsTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // OutputFrame
            // 
            this.OutputFrame.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OutputFrame.Location = new System.Drawing.Point(431, 59);
            this.OutputFrame.Name = "OutputFrame";
            this.OutputFrame.Size = new System.Drawing.Size(186, 186);
            this.OutputFrame.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.OutputFrame.TabIndex = 23;
            this.OutputFrame.TabStop = false;
            // 
            // PlayButton
            // 
            this.PlayButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.PlayButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PlayButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PlayButton.FlatAppearance.BorderSize = 0;
            this.PlayButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PlayButton.Font = new System.Drawing.Font("Gadugi", 18F);
            this.PlayButton.ForeColor = System.Drawing.Color.White;
            this.PlayButton.Location = new System.Drawing.Point(431, 251);
            this.PlayButton.Name = "PlayButton";
            this.PlayButton.Size = new System.Drawing.Size(186, 42);
            this.PlayButton.TabIndex = 24;
            this.PlayButton.Text = "Play";
            this.PlayButton.UseVisualStyleBackColor = false;
            // 
            // PreviewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(627, 304);
            this.Controls.Add(this.PlayButton);
            this.Controls.Add(this.OutputFrame);
            this.Controls.Add(this.SecondsTextbox);
            this.Controls.Add(this.Title2);
            this.Controls.Add(this.ColumnsTextbox);
            this.Controls.Add(this.RowsTextbox);
            this.Controls.Add(this.ImportButton);
            this.Controls.Add(this.ImageFrame);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.Title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PreviewForm";
            this.Text = "PreviewForm";
            ((System.ComponentModel.ISupportInitialize)(this.ImageFrame)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OutputFrame)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.PictureBox ImageFrame;
        private System.Windows.Forms.Button ImportButton;
        private System.Windows.Forms.Label Title2;
        private System.Windows.Forms.TextBox ColumnsTextbox;
        private System.Windows.Forms.TextBox RowsTextbox;
        private System.Windows.Forms.TextBox SecondsTextbox;
        private System.Windows.Forms.PictureBox OutputFrame;
        private System.Windows.Forms.Button PlayButton;
    }
}