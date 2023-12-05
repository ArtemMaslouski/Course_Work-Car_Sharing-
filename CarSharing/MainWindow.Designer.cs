namespace CarSharing
{
    partial class MainWindow
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
            this.gMapControl1 = new GMap.NET.WindowsForms.GMapControl();
            this.ExitButton = new System.Windows.Forms.Button();
            this.ReservationButton = new System.Windows.Forms.Button();
            this.XCoordinate = new System.Windows.Forms.Label();
            this.YCoordinate = new System.Windows.Forms.Label();
            this.XtextBox = new System.Windows.Forms.TextBox();
            this.YtextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // gMapControl1
            // 
            this.gMapControl1.Bearing = 0F;
            this.gMapControl1.CanDragMap = true;
            this.gMapControl1.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMapControl1.GrayScaleMode = false;
            this.gMapControl1.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMapControl1.LevelsKeepInMemmory = 5;
            this.gMapControl1.Location = new System.Drawing.Point(27, 12);
            this.gMapControl1.MarkersEnabled = true;
            this.gMapControl1.MaxZoom = 2;
            this.gMapControl1.MinZoom = 2;
            this.gMapControl1.MouseWheelZoomEnabled = true;
            this.gMapControl1.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gMapControl1.Name = "gMapControl1";
            this.gMapControl1.NegativeMode = false;
            this.gMapControl1.PolygonsEnabled = true;
            this.gMapControl1.RetryLoadTile = 0;
            this.gMapControl1.RoutesEnabled = true;
            this.gMapControl1.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gMapControl1.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMapControl1.ShowTileGridLines = false;
            this.gMapControl1.Size = new System.Drawing.Size(511, 320);
            this.gMapControl1.TabIndex = 0;
            this.gMapControl1.Zoom = 0D;
            this.gMapControl1.Load += new System.EventHandler(this.gMapControl1_Load);
            this.gMapControl1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.gMapControl1_MouseClick);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(27, 416);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 23);
            this.ExitButton.TabIndex = 1;
            this.ExitButton.Text = "Выход";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // ReservationButton
            // 
            this.ReservationButton.Location = new System.Drawing.Point(137, 419);
            this.ReservationButton.Name = "ReservationButton";
            this.ReservationButton.Size = new System.Drawing.Size(174, 20);
            this.ReservationButton.TabIndex = 3;
            this.ReservationButton.Text = "Забронировать автомобиль";
            this.ReservationButton.UseVisualStyleBackColor = true;
            this.ReservationButton.Click += new System.EventHandler(this.ReservationButton_Click);
            // 
            // XCoordinate
            // 
            this.XCoordinate.AutoSize = true;
            this.XCoordinate.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.XCoordinate.Location = new System.Drawing.Point(605, 15);
            this.XCoordinate.Name = "XCoordinate";
            this.XCoordinate.Size = new System.Drawing.Size(23, 22);
            this.XCoordinate.TabIndex = 4;
            this.XCoordinate.Text = "X";
            // 
            // YCoordinate
            // 
            this.YCoordinate.AutoSize = true;
            this.YCoordinate.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.YCoordinate.Location = new System.Drawing.Point(605, 61);
            this.YCoordinate.Name = "YCoordinate";
            this.YCoordinate.Size = new System.Drawing.Size(23, 22);
            this.YCoordinate.TabIndex = 5;
            this.YCoordinate.Text = "Y";
            // 
            // XtextBox
            // 
            this.XtextBox.Location = new System.Drawing.Point(643, 17);
            this.XtextBox.Name = "XtextBox";
            this.XtextBox.ReadOnly = true;
            this.XtextBox.Size = new System.Drawing.Size(103, 20);
            this.XtextBox.TabIndex = 6;
            // 
            // YtextBox
            // 
            this.YtextBox.Location = new System.Drawing.Point(643, 64);
            this.YtextBox.Name = "YtextBox";
            this.YtextBox.ReadOnly = true;
            this.YtextBox.Size = new System.Drawing.Size(103, 20);
            this.YtextBox.TabIndex = 7;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.YtextBox);
            this.Controls.Add(this.XtextBox);
            this.Controls.Add(this.YCoordinate);
            this.Controls.Add(this.XCoordinate);
            this.Controls.Add(this.ReservationButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.gMapControl1);
            this.Name = "MainWindow";
            this.Text = "MainWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ExitButton;
        public GMap.NET.WindowsForms.GMapControl gMapControl1;
        private System.Windows.Forms.Button ReservationButton;
        private System.Windows.Forms.Label XCoordinate;
        private System.Windows.Forms.Label YCoordinate;
        private System.Windows.Forms.TextBox XtextBox;
        private System.Windows.Forms.TextBox YtextBox;
    }
}