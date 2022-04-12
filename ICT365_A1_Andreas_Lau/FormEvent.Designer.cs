
namespace Assignment1
{
    partial class FormEvent
    {
        /// Required designer variable.
        private System.ComponentModel.IContainer components = null;

        /// Clean up any resources being used.
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

        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.facebookPicturebox = new System.Windows.Forms.PictureBox();
            this.twitterPicturebox = new System.Windows.Forms.PictureBox();
            this.personPicturebox = new System.Windows.Forms.PictureBox();
            this.videoPicturebox = new System.Windows.Forms.PictureBox();
            this.imagePicturebox = new System.Windows.Forms.PictureBox();
            this.eventTooltip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.facebookPicturebox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.twitterPicturebox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personPicturebox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.videoPicturebox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagePicturebox)).BeginInit();
            this.SuspendLayout();
            // 
            // facebookPicturebox
            // 
            this.facebookPicturebox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.facebookPicturebox.Image = global::Assignment1.Properties.Resources.facebook;
            this.facebookPicturebox.ImageLocation = "";
            this.facebookPicturebox.Location = new System.Drawing.Point(0, 0);
            this.facebookPicturebox.Name = "facebookPicturebox";
            this.facebookPicturebox.Size = new System.Drawing.Size(100, 100);
            this.facebookPicturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.facebookPicturebox.TabIndex = 0;
            this.facebookPicturebox.TabStop = false;
            this.eventTooltip.SetToolTip(this.facebookPicturebox, "Facebook");
            this.facebookPicturebox.Click += new System.EventHandler(this.facebookPicturebox_Click);
            // 
            // twitterPicturebox
            // 
            this.twitterPicturebox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.twitterPicturebox.Image = global::Assignment1.Properties.Resources.twitter;
            this.twitterPicturebox.ImageLocation = "";
            this.twitterPicturebox.Location = new System.Drawing.Point(99, 0);
            this.twitterPicturebox.Name = "twitterPicturebox";
            this.twitterPicturebox.Size = new System.Drawing.Size(100, 100);
            this.twitterPicturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.twitterPicturebox.TabIndex = 1;
            this.twitterPicturebox.TabStop = false;
            this.eventTooltip.SetToolTip(this.twitterPicturebox, "Twitter");
            this.twitterPicturebox.Click += new System.EventHandler(this.twitterPicturebox_Click);
            // 
            // personPicturebox
            // 
            this.personPicturebox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.personPicturebox.Image = global::Assignment1.Properties.Resources.person;
            this.personPicturebox.ImageLocation = "";
            this.personPicturebox.Location = new System.Drawing.Point(197, 0);
            this.personPicturebox.Name = "personPicturebox";
            this.personPicturebox.Size = new System.Drawing.Size(100, 100);
            this.personPicturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.personPicturebox.TabIndex = 2;
            this.personPicturebox.TabStop = false;
            this.eventTooltip.SetToolTip(this.personPicturebox, "Person");
            this.personPicturebox.Click += new System.EventHandler(this.personPicturebox_Click);
            // 
            // videoPicturebox
            // 
            this.videoPicturebox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.videoPicturebox.Image = global::Assignment1.Properties.Resources.video;
            this.videoPicturebox.ImageLocation = "";
            this.videoPicturebox.Location = new System.Drawing.Point(144, 100);
            this.videoPicturebox.Name = "videoPicturebox";
            this.videoPicturebox.Size = new System.Drawing.Size(100, 100);
            this.videoPicturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.videoPicturebox.TabIndex = 4;
            this.videoPicturebox.TabStop = false;
            this.eventTooltip.SetToolTip(this.videoPicturebox, "Video");
            this.videoPicturebox.Click += new System.EventHandler(this.videoPicturebox_Click);
            // 
            // imagePicturebox
            // 
            this.imagePicturebox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imagePicturebox.Image = global::Assignment1.Properties.Resources.image;
            this.imagePicturebox.ImageLocation = "";
            this.imagePicturebox.Location = new System.Drawing.Point(38, 100);
            this.imagePicturebox.Name = "imagePicturebox";
            this.imagePicturebox.Size = new System.Drawing.Size(100, 100);
            this.imagePicturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imagePicturebox.TabIndex = 3;
            this.imagePicturebox.TabStop = false;
            this.eventTooltip.SetToolTip(this.imagePicturebox, "Image");
            this.imagePicturebox.Click += new System.EventHandler(this.imagePicturebox_Click);
            // 
            // FormEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(297, 200);
            this.Controls.Add(this.videoPicturebox);
            this.Controls.Add(this.imagePicturebox);
            this.Controls.Add(this.personPicturebox);
            this.Controls.Add(this.twitterPicturebox);
            this.Controls.Add(this.facebookPicturebox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormEvent";
            this.Text = "eventForm";
            ((System.ComponentModel.ISupportInitialize)(this.facebookPicturebox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.twitterPicturebox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personPicturebox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.videoPicturebox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagePicturebox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox facebookPicturebox;
        private System.Windows.Forms.PictureBox twitterPicturebox;
        private System.Windows.Forms.PictureBox personPicturebox;
        private System.Windows.Forms.PictureBox videoPicturebox;
        private System.Windows.Forms.PictureBox imagePicturebox;
        private System.Windows.Forms.ToolTip eventTooltip;
    }
}