﻿
namespace Assignment1
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.CoordLabel = new System.Windows.Forms.Label();
            this.mainMap = new GMap.NET.WindowsForms.GMapControl();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tracklogPicturebox = new System.Windows.Forms.PictureBox();
            this.addPersonButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tracklogPicturebox)).BeginInit();
            this.SuspendLayout();
            // 
            // CoordLabel
            // 
            this.CoordLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CoordLabel.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CoordLabel.ForeColor = System.Drawing.Color.Black;
            this.CoordLabel.Location = new System.Drawing.Point(12, 9);
            this.CoordLabel.Name = "CoordLabel";
            this.CoordLabel.Size = new System.Drawing.Size(115, 22);
            this.CoordLabel.TabIndex = 1;
            this.CoordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mainMap
            // 
            this.mainMap.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.mainMap.Bearing = 0F;
            this.mainMap.CanDragMap = true;
            this.mainMap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainMap.EmptyTileColor = System.Drawing.Color.Navy;
            this.mainMap.GrayScaleMode = false;
            this.mainMap.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.mainMap.LevelsKeepInMemory = 5;
            this.mainMap.Location = new System.Drawing.Point(0, 0);
            this.mainMap.MarkersEnabled = true;
            this.mainMap.MaxZoom = 19;
            this.mainMap.MinZoom = 3;
            this.mainMap.MouseWheelZoomEnabled = true;
            this.mainMap.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionWithoutCenter;
            this.mainMap.Name = "mainMap";
            this.mainMap.NegativeMode = false;
            this.mainMap.PolygonsEnabled = true;
            this.mainMap.RetryLoadTile = 0;
            this.mainMap.RoutesEnabled = true;
            this.mainMap.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.mainMap.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.mainMap.ShowTileGridLines = false;
            this.mainMap.Size = new System.Drawing.Size(1264, 642);
            this.mainMap.TabIndex = 0;
            this.mainMap.Zoom = 7D;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.CoordLabel);
            this.splitContainer1.Panel1.Controls.Add(this.mainMap);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.splitContainer1.Panel2.Controls.Add(this.tracklogPicturebox);
            this.splitContainer1.Panel2.Controls.Add(this.addPersonButton);
            this.splitContainer1.Panel2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.splitContainer1.Panel2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.splitContainer1.Size = new System.Drawing.Size(1264, 681);
            this.splitContainer1.SplitterDistance = 642;
            this.splitContainer1.TabIndex = 2;
            // 
            // tracklogPicturebox
            // 
            this.tracklogPicturebox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tracklogPicturebox.Image = global::Assignment1.Properties.Resources.tracklog;
            this.tracklogPicturebox.ImageLocation = "";
            this.tracklogPicturebox.Location = new System.Drawing.Point(1028, 1);
            this.tracklogPicturebox.Name = "tracklogPicturebox";
            this.tracklogPicturebox.Size = new System.Drawing.Size(32, 34);
            this.tracklogPicturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.tracklogPicturebox.TabIndex = 6;
            this.tracklogPicturebox.TabStop = false;
            this.tracklogPicturebox.Tag = "Add a route";
            this.tracklogPicturebox.Click += new System.EventHandler(this.tracklogPicturebox_Click_1);
            // 
            // addPersonButton
            // 
            this.addPersonButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addPersonButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("addPersonButton.BackgroundImage")));
            this.addPersonButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.addPersonButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addPersonButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addPersonButton.ForeColor = System.Drawing.Color.Black;
            this.addPersonButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addPersonButton.Location = new System.Drawing.Point(1066, 4);
            this.addPersonButton.Name = "addPersonButton";
            this.addPersonButton.Size = new System.Drawing.Size(195, 28);
            this.addPersonButton.TabIndex = 1;
            this.addPersonButton.Text = "Add Person";
            this.addPersonButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.addPersonButton.UseVisualStyleBackColor = true;
            this.addPersonButton.Click += new System.EventHandler(this.addPersonButton_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.splitContainer1);
            this.Name = "FormMain";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "ICT365 Assignment 1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.mainForm_FormClosing);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tracklogPicturebox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label CoordLabel;
        private GMap.NET.WindowsForms.GMapControl mainMap;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button addPersonButton;
        private System.Windows.Forms.PictureBox tracklogPicturebox;
    }
}

