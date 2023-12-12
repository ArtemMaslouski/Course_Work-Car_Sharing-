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
            this.XCoordinate = new System.Windows.Forms.Label();
            this.YCoordinate = new System.Windows.Forms.Label();
            this.XtextBox = new System.Windows.Forms.TextBox();
            this.YtextBox = new System.Windows.Forms.TextBox();
            this.MaintabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ReservationDataGridView = new System.Windows.Forms.DataGridView();
            this.ReservationButton = new System.Windows.Forms.Button();
            this.MarkLabel = new System.Windows.Forms.Label();
            this.Modellabel = new System.Windows.Forms.Label();
            this.Yearlabel = new System.Windows.Forms.Label();
            this.Capacitylabel = new System.Windows.Forms.Label();
            this.MarktextBox = new System.Windows.Forms.TextBox();
            this.ModeltextBox = new System.Windows.Forms.TextBox();
            this.YeartextBox = new System.Windows.Forms.TextBox();
            this.CapacitytextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.DistanceLabel = new System.Windows.Forms.Label();
            this.KmLabel = new System.Windows.Forms.Label();
            this.MaintabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ReservationDataGridView)).BeginInit();
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
            this.gMapControl1.Location = new System.Drawing.Point(6, 6);
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
            this.gMapControl1.Size = new System.Drawing.Size(490, 308);
            this.gMapControl1.TabIndex = 0;
            this.gMapControl1.Zoom = 0D;
            this.gMapControl1.OnMarkerClick += new GMap.NET.WindowsForms.MarkerClick(this.gMapControl1_OnMarkerClick);
            this.gMapControl1.Load += new System.EventHandler(this.gMapControl1_Load);
            this.gMapControl1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.gMapControl1_MouseClick);
            // 
            // ExitButton
            // 
            this.ExitButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExitButton.Location = new System.Drawing.Point(27, 406);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(90, 33);
            this.ExitButton.TabIndex = 1;
            this.ExitButton.Text = "Выход";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
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
            this.XtextBox.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.XtextBox.Location = new System.Drawing.Point(643, 17);
            this.XtextBox.Name = "XtextBox";
            this.XtextBox.ReadOnly = true;
            this.XtextBox.Size = new System.Drawing.Size(103, 29);
            this.XtextBox.TabIndex = 6;
            // 
            // YtextBox
            // 
            this.YtextBox.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.YtextBox.Location = new System.Drawing.Point(643, 64);
            this.YtextBox.Name = "YtextBox";
            this.YtextBox.ReadOnly = true;
            this.YtextBox.Size = new System.Drawing.Size(103, 29);
            this.YtextBox.TabIndex = 7;
            // 
            // MaintabControl
            // 
            this.MaintabControl.Controls.Add(this.tabPage1);
            this.MaintabControl.Controls.Add(this.tabPage2);
            this.MaintabControl.Location = new System.Drawing.Point(27, 17);
            this.MaintabControl.Name = "MaintabControl";
            this.MaintabControl.SelectedIndex = 0;
            this.MaintabControl.Size = new System.Drawing.Size(510, 346);
            this.MaintabControl.TabIndex = 8;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.gMapControl1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(502, 320);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Map";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.ReservationDataGridView);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(502, 320);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Reservstion";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // ReservationDataGridView
            // 
            this.ReservationDataGridView.AllowUserToAddRows = false;
            this.ReservationDataGridView.AllowUserToDeleteRows = false;
            this.ReservationDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ReservationDataGridView.Location = new System.Drawing.Point(6, 6);
            this.ReservationDataGridView.Name = "ReservationDataGridView";
            this.ReservationDataGridView.ReadOnly = true;
            this.ReservationDataGridView.Size = new System.Drawing.Size(490, 308);
            this.ReservationDataGridView.TabIndex = 0;
            // 
            // ReservationButton
            // 
            this.ReservationButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ReservationButton.Location = new System.Drawing.Point(136, 406);
            this.ReservationButton.Name = "ReservationButton";
            this.ReservationButton.Size = new System.Drawing.Size(188, 32);
            this.ReservationButton.TabIndex = 9;
            this.ReservationButton.Text = "Забронировать";
            this.ReservationButton.UseVisualStyleBackColor = true;
            this.ReservationButton.Click += new System.EventHandler(this.ReservationButton_Click_1);
            // 
            // MarkLabel
            // 
            this.MarkLabel.AutoSize = true;
            this.MarkLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MarkLabel.Location = new System.Drawing.Point(567, 136);
            this.MarkLabel.Name = "MarkLabel";
            this.MarkLabel.Size = new System.Drawing.Size(69, 22);
            this.MarkLabel.TabIndex = 10;
            this.MarkLabel.Text = "Марка";
            // 
            // Modellabel
            // 
            this.Modellabel.AutoSize = true;
            this.Modellabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Modellabel.Location = new System.Drawing.Point(567, 185);
            this.Modellabel.Name = "Modellabel";
            this.Modellabel.Size = new System.Drawing.Size(77, 22);
            this.Modellabel.TabIndex = 11;
            this.Modellabel.Text = "Модель";
            // 
            // Yearlabel
            // 
            this.Yearlabel.AutoSize = true;
            this.Yearlabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Yearlabel.Location = new System.Drawing.Point(567, 237);
            this.Yearlabel.Name = "Yearlabel";
            this.Yearlabel.Size = new System.Drawing.Size(118, 22);
            this.Yearlabel.TabIndex = 12;
            this.Yearlabel.Text = "Год выпуска";
            // 
            // Capacitylabel
            // 
            this.Capacitylabel.AutoSize = true;
            this.Capacitylabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Capacitylabel.Location = new System.Drawing.Point(567, 291);
            this.Capacitylabel.Name = "Capacitylabel";
            this.Capacitylabel.Size = new System.Drawing.Size(68, 22);
            this.Capacitylabel.TabIndex = 13;
            this.Capacitylabel.Text = "Объём";
            // 
            // MarktextBox
            // 
            this.MarktextBox.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MarktextBox.Location = new System.Drawing.Point(683, 136);
            this.MarktextBox.Name = "MarktextBox";
            this.MarktextBox.ReadOnly = true;
            this.MarktextBox.Size = new System.Drawing.Size(100, 29);
            this.MarktextBox.TabIndex = 14;
            // 
            // ModeltextBox
            // 
            this.ModeltextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ModeltextBox.Location = new System.Drawing.Point(683, 185);
            this.ModeltextBox.Name = "ModeltextBox";
            this.ModeltextBox.ReadOnly = true;
            this.ModeltextBox.Size = new System.Drawing.Size(100, 29);
            this.ModeltextBox.TabIndex = 15;
            // 
            // YeartextBox
            // 
            this.YeartextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.YeartextBox.Location = new System.Drawing.Point(683, 239);
            this.YeartextBox.Name = "YeartextBox";
            this.YeartextBox.ReadOnly = true;
            this.YeartextBox.Size = new System.Drawing.Size(100, 29);
            this.YeartextBox.TabIndex = 16;
            // 
            // CapacitytextBox
            // 
            this.CapacitytextBox.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CapacitytextBox.Location = new System.Drawing.Point(683, 291);
            this.CapacitytextBox.Name = "CapacitytextBox";
            this.CapacitytextBox.ReadOnly = true;
            this.CapacitytextBox.Size = new System.Drawing.Size(100, 29);
            this.CapacitytextBox.TabIndex = 17;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(330, 406);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(223, 32);
            this.button1.TabIndex = 18;
            this.button1.Text = "Вернуть автомобиль";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DistanceLabel
            // 
            this.DistanceLabel.AutoSize = true;
            this.DistanceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DistanceLabel.Location = new System.Drawing.Point(33, 366);
            this.DistanceLabel.Name = "DistanceLabel";
            this.DistanceLabel.Size = new System.Drawing.Size(287, 24);
            this.DistanceLabel.TabIndex = 20;
            this.DistanceLabel.Text = "Расстояние до автомобиля:";
            // 
            // KmLabel
            // 
            this.KmLabel.AutoSize = true;
            this.KmLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.KmLabel.Location = new System.Drawing.Point(326, 368);
            this.KmLabel.Name = "KmLabel";
            this.KmLabel.Size = new System.Drawing.Size(20, 22);
            this.KmLabel.TabIndex = 21;
            this.KmLabel.Text = "0";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.KmLabel);
            this.Controls.Add(this.DistanceLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CapacitytextBox);
            this.Controls.Add(this.YeartextBox);
            this.Controls.Add(this.ModeltextBox);
            this.Controls.Add(this.MarktextBox);
            this.Controls.Add(this.Capacitylabel);
            this.Controls.Add(this.Yearlabel);
            this.Controls.Add(this.Modellabel);
            this.Controls.Add(this.MarkLabel);
            this.Controls.Add(this.ReservationButton);
            this.Controls.Add(this.MaintabControl);
            this.Controls.Add(this.YtextBox);
            this.Controls.Add(this.XtextBox);
            this.Controls.Add(this.YCoordinate);
            this.Controls.Add(this.XCoordinate);
            this.Controls.Add(this.ExitButton);
            this.Name = "MainWindow";
            this.Text = "MainWindow";
            this.MaintabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ReservationDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ExitButton;
        public GMap.NET.WindowsForms.GMapControl gMapControl1;
        private System.Windows.Forms.Label XCoordinate;
        private System.Windows.Forms.Label YCoordinate;
        private System.Windows.Forms.TextBox XtextBox;
        private System.Windows.Forms.TextBox YtextBox;
        private System.Windows.Forms.TabControl MaintabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView ReservationDataGridView;
        private System.Windows.Forms.Button ReservationButton;
        private System.Windows.Forms.Label MarkLabel;
        private System.Windows.Forms.Label Modellabel;
        private System.Windows.Forms.Label Yearlabel;
        private System.Windows.Forms.Label Capacitylabel;
        private System.Windows.Forms.TextBox MarktextBox;
        private System.Windows.Forms.TextBox ModeltextBox;
        private System.Windows.Forms.TextBox YeartextBox;
        private System.Windows.Forms.TextBox CapacitytextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label DistanceLabel;
        private System.Windows.Forms.Label KmLabel;
    }
}