namespace Roket_test
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.buttonConnect = new System.Windows.Forms.Button();
            this.buttonDisconnect = new System.Windows.Forms.Button();
            this.richTextBoxLogR = new System.Windows.Forms.RichTextBox();
            this.comboPorts = new System.Windows.Forms.ComboBox();
            this.comboBoxBaudRate = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.map = new GMap.NET.WindowsForms.GMapControl();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label11 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.chartAngle = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.txtState = new System.Windows.Forms.Label();
            this.txtSat = new System.Windows.Forms.Label();
            this.txtAltitude = new System.Windows.Forms.Label();
            this.txtVel = new System.Windows.Forms.Label();
            this.txtPressure = new System.Windows.Forms.Label();
            this.txtEpogee = new System.Windows.Forms.Label();
            this.txtG = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtTime = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtVolt = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtAlg = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txtDist = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.buttonServoForm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartAngle)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonConnect
            // 
            this.buttonConnect.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonConnect.Location = new System.Drawing.Point(401, 11);
            this.buttonConnect.Margin = new System.Windows.Forms.Padding(2);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(147, 26);
            this.buttonConnect.TabIndex = 0;
            this.buttonConnect.Text = "Connect";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // buttonDisconnect
            // 
            this.buttonDisconnect.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonDisconnect.Location = new System.Drawing.Point(552, 11);
            this.buttonDisconnect.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDisconnect.Name = "buttonDisconnect";
            this.buttonDisconnect.Size = new System.Drawing.Size(156, 26);
            this.buttonDisconnect.TabIndex = 1;
            this.buttonDisconnect.Text = "Disconnect";
            this.buttonDisconnect.UseVisualStyleBackColor = true;
            this.buttonDisconnect.Click += new System.EventHandler(this.buttonDisconnect_Click);
            // 
            // richTextBoxLogR
            // 
            this.richTextBoxLogR.Location = new System.Drawing.Point(401, 57);
            this.richTextBoxLogR.Margin = new System.Windows.Forms.Padding(2);
            this.richTextBoxLogR.Name = "richTextBoxLogR";
            this.richTextBoxLogR.Size = new System.Drawing.Size(427, 114);
            this.richTextBoxLogR.TabIndex = 2;
            this.richTextBoxLogR.Text = "";
            // 
            // comboPorts
            // 
            this.comboPorts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboPorts.FormattingEnabled = true;
            this.comboPorts.Location = new System.Drawing.Point(109, 14);
            this.comboPorts.Margin = new System.Windows.Forms.Padding(2);
            this.comboPorts.Name = "comboPorts";
            this.comboPorts.Size = new System.Drawing.Size(92, 21);
            this.comboPorts.TabIndex = 3;
            // 
            // comboBoxBaudRate
            // 
            this.comboBoxBaudRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBaudRate.FormattingEnabled = true;
            this.comboBoxBaudRate.Items.AddRange(new object[] {
            "115200"});
            this.comboBoxBaudRate.Location = new System.Drawing.Point(299, 15);
            this.comboBoxBaudRate.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxBaudRate.Name = "comboBoxBaudRate";
            this.comboBoxBaudRate.Size = new System.Drawing.Size(92, 21);
            this.comboBoxBaudRate.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 141);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "Sat Val :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(197, 141);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "Dikey Hız :";
            // 
            // map
            // 
            this.map.Bearing = 0F;
            this.map.CanDragMap = true;
            this.map.EmptyTileColor = System.Drawing.Color.Navy;
            this.map.GrayScaleMode = false;
            this.map.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.map.LevelsKeepInMemmory = 5;
            this.map.Location = new System.Drawing.Point(401, 176);
            this.map.MarkersEnabled = true;
            this.map.MaxZoom = 2;
            this.map.MinZoom = 2;
            this.map.MouseWheelZoomEnabled = true;
            this.map.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.map.Name = "map";
            this.map.NegativeMode = false;
            this.map.PolygonsEnabled = true;
            this.map.RetryLoadTile = 0;
            this.map.RoutesEnabled = true;
            this.map.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.map.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.map.ShowTileGridLines = false;
            this.map.Size = new System.Drawing.Size(427, 349);
            this.map.TabIndex = 8;
            this.map.Zoom = 0D;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 21);
            this.label3.TabIndex = 12;
            this.label3.Text = "Basınç :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(197, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 21);
            this.label4.TabIndex = 13;
            this.label4.Text = "Yükseklik :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(12, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 21);
            this.label5.TabIndex = 14;
            this.label5.Text = "Zirve :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(197, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 21);
            this.label6.TabIndex = 15;
            this.label6.Text = "G kuvveti :";
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Bauhaus 93", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label9.Location = new System.Drawing.Point(6, 7);
            this.label9.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 28);
            this.label9.TabIndex = 18;
            this.label9.Text = "E22 :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.SystemColors.Window;
            this.label8.Location = new System.Drawing.Point(64, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 19);
            this.label8.TabIndex = 19;
            this.label8.Text = "Port :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.ForeColor = System.Drawing.SystemColors.Window;
            this.label10.Location = new System.Drawing.Point(206, 15);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 19);
            this.label10.TabIndex = 20;
            this.label10.Text = "Boud Rate :";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(833, 12);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(409, 25);
            this.progressBar1.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Impact", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label11.Location = new System.Drawing.Point(8, 258);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(127, 43);
            this.label11.TabIndex = 22;
            this.label11.Text = "Durum :";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label16.Location = new System.Drawing.Point(398, 37);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(110, 18);
            this.label16.TabIndex = 27;
            this.label16.Text = "Serial Dialog :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Roket_test.Properties.Resources.ps2pdf_com__2_;
            this.pictureBox1.Location = new System.Drawing.Point(16, 390);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(364, 135);
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            // 
            // chartAngle
            // 
            chartArea1.Name = "ChartArea1";
            chartArea2.Name = "ChartArea2";
            chartArea3.Name = "ChartArea3";
            this.chartAngle.ChartAreas.Add(chartArea1);
            this.chartAngle.ChartAreas.Add(chartArea2);
            this.chartAngle.ChartAreas.Add(chartArea3);
            legend1.Name = "Legend1";
            this.chartAngle.Legends.Add(legend1);
            this.chartAngle.Location = new System.Drawing.Point(833, 57);
            this.chartAngle.Name = "chartAngle";
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Color = System.Drawing.Color.Red;
            series1.Legend = "Legend1";
            series1.MarkerSize = 20;
            series1.MarkerStep = 100;
            series1.Name = "X axis";
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series2.BorderWidth = 3;
            series2.ChartArea = "ChartArea2";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Color = System.Drawing.Color.Green;
            series2.Legend = "Legend1";
            series2.MarkerSize = 20;
            series2.MarkerStep = 100;
            series2.Name = "Y axis";
            series2.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series3.BorderWidth = 3;
            series3.ChartArea = "ChartArea3";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Legend = "Legend1";
            series3.MarkerSize = 20;
            series3.MarkerStep = 100;
            series3.Name = "Altitude";
            series3.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            this.chartAngle.Series.Add(series1);
            this.chartAngle.Series.Add(series2);
            this.chartAngle.Series.Add(series3);
            this.chartAngle.Size = new System.Drawing.Size(409, 468);
            this.chartAngle.TabIndex = 33;
            this.chartAngle.Text = "Angles";
            // 
            // txtState
            // 
            this.txtState.AutoSize = true;
            this.txtState.Font = new System.Drawing.Font("Impact", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtState.ForeColor = System.Drawing.SystemColors.Control;
            this.txtState.Location = new System.Drawing.Point(8, 314);
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(181, 43);
            this.txtState.TabIndex = 34;
            this.txtState.Text = "Beklemede";
            this.txtState.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSat
            // 
            this.txtSat.AutoSize = true;
            this.txtSat.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSat.ForeColor = System.Drawing.SystemColors.Control;
            this.txtSat.Location = new System.Drawing.Point(85, 141);
            this.txtSat.Name = "txtSat";
            this.txtSat.Size = new System.Drawing.Size(25, 21);
            this.txtSat.TabIndex = 35;
            this.txtSat.Text = "---";
            // 
            // txtAltitude
            // 
            this.txtAltitude.AutoSize = true;
            this.txtAltitude.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAltitude.ForeColor = System.Drawing.SystemColors.Control;
            this.txtAltitude.Location = new System.Drawing.Point(295, 56);
            this.txtAltitude.Name = "txtAltitude";
            this.txtAltitude.Size = new System.Drawing.Size(25, 21);
            this.txtAltitude.TabIndex = 36;
            this.txtAltitude.Text = "---";
            // 
            // txtVel
            // 
            this.txtVel.AutoSize = true;
            this.txtVel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtVel.ForeColor = System.Drawing.SystemColors.Control;
            this.txtVel.Location = new System.Drawing.Point(295, 141);
            this.txtVel.Name = "txtVel";
            this.txtVel.Size = new System.Drawing.Size(25, 21);
            this.txtVel.TabIndex = 37;
            this.txtVel.Text = "---";
            // 
            // txtPressure
            // 
            this.txtPressure.AutoSize = true;
            this.txtPressure.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPressure.ForeColor = System.Drawing.SystemColors.Control;
            this.txtPressure.Location = new System.Drawing.Point(85, 56);
            this.txtPressure.Name = "txtPressure";
            this.txtPressure.Size = new System.Drawing.Size(25, 21);
            this.txtPressure.TabIndex = 38;
            this.txtPressure.Text = "---";
            // 
            // txtEpogee
            // 
            this.txtEpogee.AutoSize = true;
            this.txtEpogee.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtEpogee.ForeColor = System.Drawing.SystemColors.Control;
            this.txtEpogee.Location = new System.Drawing.Point(85, 99);
            this.txtEpogee.Name = "txtEpogee";
            this.txtEpogee.Size = new System.Drawing.Size(25, 21);
            this.txtEpogee.TabIndex = 39;
            this.txtEpogee.Text = "---";
            this.txtEpogee.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtG
            // 
            this.txtG.AutoSize = true;
            this.txtG.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtG.ForeColor = System.Drawing.SystemColors.Control;
            this.txtG.Location = new System.Drawing.Point(295, 99);
            this.txtG.Name = "txtG";
            this.txtG.Size = new System.Drawing.Size(25, 21);
            this.txtG.TabIndex = 40;
            this.txtG.Text = "---";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(0, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 41;
            this.label7.Text = "label7";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(12, 188);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(111, 21);
            this.label12.TabIndex = 42;
            this.label12.Text = "Sistem süresi :";
            // 
            // txtTime
            // 
            this.txtTime.AutoSize = true;
            this.txtTime.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTime.ForeColor = System.Drawing.SystemColors.Control;
            this.txtTime.Location = new System.Drawing.Point(119, 188);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(25, 21);
            this.txtTime.TabIndex = 43;
            this.txtTime.Text = "---";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(197, 188);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(118, 21);
            this.label13.TabIndex = 44;
            this.label13.Text = "Voltaj Değeri :";
            // 
            // txtVolt
            // 
            this.txtVolt.AutoSize = true;
            this.txtVolt.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtVolt.ForeColor = System.Drawing.SystemColors.Control;
            this.txtVolt.Location = new System.Drawing.Point(309, 188);
            this.txtVolt.Name = "txtVolt";
            this.txtVolt.Size = new System.Drawing.Size(25, 21);
            this.txtVolt.TabIndex = 45;
            this.txtVolt.Text = "---";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(12, 224);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(173, 21);
            this.label14.TabIndex = 46;
            this.label14.Text = "Kullanılan Algoritma :";
            // 
            // txtAlg
            // 
            this.txtAlg.AutoSize = true;
            this.txtAlg.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAlg.ForeColor = System.Drawing.SystemColors.Control;
            this.txtAlg.Location = new System.Drawing.Point(191, 224);
            this.txtAlg.Name = "txtAlg";
            this.txtAlg.Size = new System.Drawing.Size(25, 21);
            this.txtAlg.TabIndex = 47;
            this.txtAlg.Text = "---";
            // 
            // timer1
            // 
            this.timer1.Interval = 200;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // txtDist
            // 
            this.txtDist.AutoSize = true;
            this.txtDist.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtDist.ForeColor = System.Drawing.SystemColors.Control;
            this.txtDist.Location = new System.Drawing.Point(253, 258);
            this.txtDist.Name = "txtDist";
            this.txtDist.Size = new System.Drawing.Size(25, 21);
            this.txtDist.TabIndex = 48;
            this.txtDist.Text = "---";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(179, 258);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(69, 21);
            this.label15.TabIndex = 49;
            this.label15.Text = "Uzaklık :";
            // 
            // buttonServoForm
            // 
            this.buttonServoForm.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonServoForm.Location = new System.Drawing.Point(712, 11);
            this.buttonServoForm.Margin = new System.Windows.Forms.Padding(2);
            this.buttonServoForm.Name = "buttonServoForm";
            this.buttonServoForm.Size = new System.Drawing.Size(116, 26);
            this.buttonServoForm.TabIndex = 50;
            this.buttonServoForm.Text = "Servo Form";
            this.buttonServoForm.UseVisualStyleBackColor = true;
            this.buttonServoForm.Click += new System.EventHandler(this.buttonServoForm_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(1259, 535);
            this.Controls.Add(this.buttonServoForm);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtDist);
            this.Controls.Add(this.txtAlg);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtVolt);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtTime);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtG);
            this.Controls.Add(this.txtEpogee);
            this.Controls.Add(this.txtPressure);
            this.Controls.Add(this.txtVel);
            this.Controls.Add(this.txtAltitude);
            this.Controls.Add(this.txtSat);
            this.Controls.Add(this.txtState);
            this.Controls.Add(this.chartAngle);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.map);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxBaudRate);
            this.Controls.Add(this.comboPorts);
            this.Controls.Add(this.richTextBoxLogR);
            this.Controls.Add(this.buttonDisconnect);
            this.Controls.Add(this.buttonConnect);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "SAKARYA";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartAngle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.Button buttonDisconnect;
        private System.Windows.Forms.RichTextBox richTextBoxLogR;
        private System.Windows.Forms.ComboBox comboPorts;
        private System.Windows.Forms.ComboBox comboBoxBaudRate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private GMap.NET.WindowsForms.GMapControl map;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartAngle;
        private System.Windows.Forms.Label txtState;
        private System.Windows.Forms.Label txtSat;
        private System.Windows.Forms.Label txtAltitude;
        private System.Windows.Forms.Label txtVel;
        private System.Windows.Forms.Label txtPressure;
        private System.Windows.Forms.Label txtEpogee;
        private System.Windows.Forms.Label txtG;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label txtTime;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label txtVolt;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label txtAlg;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label txtDist;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button buttonServoForm;
    }
}

