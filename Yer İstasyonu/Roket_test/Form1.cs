using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.IO;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;


namespace Roket_test
{
    public partial class Form1 : Form
    {
        GMapMarker markerR = new GMarkerGoogle(new PointLatLng(0, 0), GMarkerGoogleType.orange);
        GMapMarker markerU = new GMarkerGoogle(new PointLatLng(0, 0), GMarkerGoogleType.red);
        double C_RADIUS_EARTH_KM = 6371.1;
        double C_RADIUS_EARTH_MI = 3958.82;
        double C_PI = Math.PI;
        string[] ports = SerialPort.GetPortNames();
        public delegate void AddDataDelegate(String myString);
        public AddDataDelegate myDelegate;
        public string strCurrentLine;
        GMapOverlay markers = new GMapOverlay("markers");
        bool isFirstGPSData = true;
        double latF;
        double lngF;
        float curAlt;
        long maksm = 50;
        long minm = 0;
        string[] datas;
        int controller = 0; 
        int curController = 0;
        bool apogee = false;
        int error;

        public Form1()
        {
            this.myDelegate = new AddDataDelegate(addDataMethod);
            InitializeComponent();
            GMapProviders.GoogleMap.ApiKey = @"AIzaSyDdgIefcmPb3D-k2MaxBlQ898rfOx8x8JQ";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GMaps.Instance.Mode = AccessMode.ServerAndCache;
            map.CacheLocation = @"cache";
            map.SetPositionByKeywords("Ankara, Turkey");
            foreach (string port in ports)
            {
                comboPorts.Items.Add(port);
                comboPorts.SelectedIndex = 0;
            }
            map.ShowCenter = false;
            map.MapProvider = GMapProviders.GoogleHybridMap;
            map.DragButton = MouseButtons.Left;
            map.MinZoom = 5;
            map.MaxZoom = 100;
            map.Zoom = 12;
        }


        private void buttonConnect_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboPorts.Text == string.Empty || comboBoxBaudRate.Text == string.Empty)
                {
                    MessageBox.Show("Check Settings", "Unexpected Exception", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    serialPort1.PortName = comboPorts.Text;
                    serialPort1.BaudRate = Int32.Parse(comboBoxBaudRate.Text);
                    serialPort1.DataBits = 8;
                    serialPort1.Open();
                    serialPort1.DataReceived += SerialPort1_DataReceived;
                    Portas.PortCom = comboPorts.Text;
                    Portas.PortBaud = Int32.Parse(comboBoxBaudRate.Text);
                    progressBar1.Value = 100;
                    if (serialPort1.IsOpen)
                    {
                        timer1.Enabled = true;
                        timer1.Start();
                        buttonConnect.Enabled = false;
                        buttonDisconnect.Enabled = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex, "Unexpected Exception", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
            }
        }


        private void SerialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                try
                {
                    SerialPort sp = (SerialPort)sender;
                    strCurrentLine = sp.ReadLine();
                    serialPort1.DiscardInBuffer();
                    sp.DiscardInBuffer();
                    richTextBoxLogR.Invoke(this.myDelegate, new Object[] { strCurrentLine });
                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex, "Unexcepted Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        public void addDataMethod(String myString)
        {
            try
            {
                if (myString != null)
                {
                    richTextBoxLogR.Text = myString + "\n";
                    datas = myString.Split('?');
                    controller++;
                    dataControll(datas);
                    if (datas[0] == "A")
                    {
                        txtAlg.Text = "Anakart";


                        if (datas[12] == "0")
                        {
                            txtState.Text = "Bağlandı";
                        }
                        else if (datas[12] == "1")
                        {
                            txtState.Text = "Başlatıldı";
                        }
                        else if (datas[12] == "2")
                        {
                            txtState.Text = "Uçuyor";
                        }
                        else if (datas[12] == "3")
                        {
                            txtState.Text = "Burnout";
                        }
                        else if (datas[12] == "4")
                        {
                            txtState.Text = "Algoritmalar";
                        }
                        else if (datas[12] == "5")
                        {
                            txtState.Text = "Zirve";
                        }
                        else if (datas[12] == "6")
                        {
                            txtState.Text = "Ana Paraşüt";
                        }
                        else if (datas[12] == "7")
                        {
                            txtState.Text = "Yerde";
                        }
                        else
                        {
                            txtEpogee.Text = "---";
                        }


                        float vel = VerticalVelocity(float.Parse(datas[3]));

                        double lat = Convert.ToDouble(datas[7]) / 1000000;
                        double lng = Convert.ToDouble(datas[8]) / 1000000;

                        txtTime.Text = datas[1];
                        txtVolt.Text = datas[2];
                        txtAltitude.Text = datas[3];
                        txtEpogee.Text = datas[4];
                        txtVel.Text = "" + vel;
                        txtPressure.Text = datas[5];
                        txtG.Text = datas[6];
                        txtSat.Text = datas[9];

                        if (lat != 0 && lng != 0 && isFirstGPSData)
                        {
                            PointLatLng pointF = new PointLatLng(lat, lng);
                            map.Position = pointF;
                            latF = lat;
                            lngF = lng;
                            GMapMarker markerF = new GMarkerGoogle(pointF, GMarkerGoogleType.green);
                            markers.Markers.Add(markerF);
                            isFirstGPSData = false;
                        }

                        ChartDesign(datas[10], datas[11], datas[3]);
                        
                        PointLatLng point = new PointLatLng(lat, lng);
                        
                        map.Position = point;
                        GMarkerGoogle marker = new GMarkerGoogle(point, GMarkerGoogleType.blue_dot);
                        markers.Markers.Append(marker);
                        txtDist.Text = "" + GreatCircleDistance(latF, lngF, lat, lng, true, false);
                        map.Overlays.Add(markers);
                        map.Refresh();
                    }
                    if (datas[0] == "Y")
                    {
                        txtAlg.Text = "YedekKart";


                        if (datas[12] == "0")
                        {
                            txtState.Text = "Bağlandı";
                        }
                        else if (datas[12] == "1")
                        {
                            txtState.Text = "Başlatıldı";
                        }
                        else if (datas[12] == "2")
                        {
                            txtState.Text = "Uçuyor";
                        }
                        else if (datas[12] == "3")
                        {
                            txtState.Text = "Burnout";
                        }
                        else if (datas[12] == "4")
                        {
                            txtState.Text = "Algoritmalar";
                        }
                        else if (datas[12] == "5")
                        {
                            txtState.Text = "Zirve";
                        }
                        else if (datas[12] == "6")
                        {
                            txtState.Text = "Ana Paraşüt";
                        }
                        else if (datas[12] == "7")
                        {
                            txtState.Text = "Yerde";
                        }
                        else
                        {
                            txtEpogee.Text = "---";
                        }


                        float vel = VerticalVelocity(float.Parse(datas[3]));

                        double lat = Convert.ToDouble(datas[7]) / 1000000;
                        double lng = Convert.ToDouble(datas[8]) / 1000000;

                        txtTime.Text = datas[1];
                        txtVolt.Text = datas[2];
                        txtAltitude.Text = datas[3];
                        txtEpogee.Text = datas[4];
                        txtVel.Text = "" + vel;
                        txtPressure.Text = datas[5];
                        txtG.Text = datas[6];
                        txtSat.Text = datas[9];

                        if (lat != 0 && lng != 0 && isFirstGPSData)
                        {
                            PointLatLng pointF = new PointLatLng(lat, lng);
                            map.Position = pointF;
                            latF = lat;
                            lngF = lng;
                            GMapMarker markerF = new GMarkerGoogle(pointF, GMarkerGoogleType.green);
                            markers.Markers.Add(markerF);
                            isFirstGPSData = false;
                        }

                        ChartDesign(datas[10], datas[11], datas[3]);

                        PointLatLng point = new PointLatLng(lat, lng);

                        map.Position = point;
                        GMarkerGoogle marker = new GMarkerGoogle(point, GMarkerGoogleType.blue_dot);
                        markers.Markers.Append(marker);
                        txtDist.Text = "" + GreatCircleDistance(latF, lngF, lat, lng, true, false);
                        map.Overlays.Add(markers);
                        map.Refresh();
                    }
                    if (datas[0] == "U")
                    {
                        txtAlg.Text = "Uydu";

                        double lat = Convert.ToDouble(datas[3]) / 1000000;
                        double lng = Convert.ToDouble(datas[4]) / 1000000;

                        PointLatLng point = new PointLatLng(lat, lng);

                        map.Position = point;
                        GMarkerGoogle marker = new GMarkerGoogle(point, GMarkerGoogleType.blue_dot);
                        markers.Markers.Append(marker);
                        txtDist.Text = "" + GreatCircleDistance(latF, lngF, lat, lng, true, false);
                        map.Overlays.Add(markers);
                        map.Refresh();

                        txtTime.Text = datas[1];
                        txtVolt.Text = datas[2];
                        txtAltitude.Text = "-";
                        txtEpogee.Text = "-";
                        txtVel.Text = "-";
                        txtPressure.Text = "-";
                        txtG.Text = "-";
                        txtSat.Text = datas[5];


                        ChartDesign("0", "0", "0");

                    }
                    if (datas[0] == "TY")
                    {
                        txtAlg.Text = "TESTYedekKart";

                        if (datas[10] == "0")
                        {
                            txtState.Text = "Bağlandı";
                        }
                        else if (datas[10] == "1")
                        {
                            txtState.Text = "Havalandı";
                        }
                        else if (datas[10] == "2")
                        {
                            txtState.Text = "Zirvede";
                        }
                        else if (datas[10] == "3")
                        {
                            txtState.Text = "Zirvede";
                        }
                        else
                        {
                            txtEpogee.Text = "0";
                        }

                        txtTime.Text = datas[1];
                        txtVolt.Text = "-";
                        txtAltitude.Text = datas[2];
                        txtEpogee.Text = datas[3];
                        txtVel.Text = datas[4];
                        txtPressure.Text = datas[6];
                        txtG.Text = datas[7];
                        txtSat.Text = "-";


                        ChartDesign(datas[8], datas[9], datas[2]);
                    }
                    if (datas[0] == "TG")
                    {
                        txtAlg.Text = "Telemetri testi";

                        if (datas[14] == "0")
                        {
                            txtState.Text = "Bağlandı";
                        }
                        else if (datas[14] == "1")
                        {
                            txtState.Text = "Havalandı";
                        }
                        else if (datas[14] == "2")
                        {
                            txtState.Text = "Zirvede";
                        }
                        else if (datas[14] == "3")
                        {
                            txtState.Text = "Zirvede";
                        }
                        else
                        {
                            txtEpogee.Text = "0";
                        }

                        txtTime.Text = datas[1];
                        txtVolt.Text = datas[2];
                        txtAltitude.Text = datas[3];
                        txtEpogee.Text = datas[4];
                        txtVel.Text = datas[5];
                        txtPressure.Text = datas[6];
                        txtG.Text = datas[7];
                        txtSat.Text = datas[10];


                        // ChartDesign(datas[2], datas[5]);

                    }
                    if (datas[0] == "t")
                    {
                        txtState.Text = "Kalman Test";
                       
                    }
                    //logger(myString);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex, "AddData", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public float VerticalVelocity(float alt)
        {
            float velocity = (alt - curAlt) * 10;
            curAlt = alt;
            return velocity;
        }

        double GreatCircleDistance(double Latitude1, double Longitude1,
                      double Latitude2, double Longitude2, bool ValuesAsDecimalDegrees,
                      bool ResultAsMiles)
        {
            double Lat1;
            double Lat2;
            double Long1;
            double Long2;
            long X;
            double Delta;

            if (ValuesAsDecimalDegrees == true)
                X = 1;
            else
                X = 24;

            // convert to decimal degrees
            Lat1 = Latitude1 * X;
            Long1 = Longitude1 * X;
            Lat2 = Latitude2 * X;
            Long2 = Longitude2 * X;

            // convert to radians: radians = (degrees/180) * PI
            Lat1 = (Lat1 / 180) * C_PI;
            Lat2 = (Lat2 / 180) * C_PI;
            Long1 = (Long1 / 180) * C_PI;
            Long2 = (Long2 / 180) * C_PI;
            // get the central spherical angle

            Delta = (2 * Math.Asin(Math.Sqrt((Math.Pow(Math.Sin((Lat1 - Lat2) / 2), 2) + Math.Cos(Lat1) * Math.Cos(Lat2) * (Math.Pow(Math.Sin((Long1 - Long2) / 2), 2))))));

            if (ResultAsMiles == true)
                return (Delta * C_RADIUS_EARTH_MI) * 1000;
            else
                return (Delta * C_RADIUS_EARTH_KM) * 1000;

        }
            
        public void ChartDesign(string x1, string x2, string x3)
        {
            float a = float.Parse(x3) + 20;

            //ChartX
            this.chartAngle.ChartAreas[0].AxisX.Minimum = minm;
            this.chartAngle.ChartAreas[0].AxisX.Maximum = maksm;

            this.chartAngle.ChartAreas[0].AxisY.Minimum = -180;
            this.chartAngle.ChartAreas[0].AxisY.Maximum = 180;

            this.chartAngle.ChartAreas[0].AxisX.ScaleView.Zoom(minm, maksm);

            this.chartAngle.Series[0].Points.AddXY((minm + maksm) / 2, x1);
            //ChartY
            this.chartAngle.ChartAreas[1].AxisX.Minimum = minm;
            this.chartAngle.ChartAreas[1].AxisX.Maximum = maksm;

            this.chartAngle.ChartAreas[1].AxisY.Minimum = -180;
            this.chartAngle.ChartAreas[1].AxisY.Maximum = 180;

            this.chartAngle.ChartAreas[1].AxisX.ScaleView.Zoom(minm, maksm);

            this.chartAngle.Series[1].Points.AddXY((minm + maksm) / 2, x2);
            //Altitude
            this.chartAngle.ChartAreas[2].AxisX.Minimum = minm;
            this.chartAngle.ChartAreas[2].AxisX.Maximum = maksm;

            this.chartAngle.ChartAreas[2].AxisY.Minimum = -10;
            this.chartAngle.ChartAreas[2].AxisY.Maximum = 10;

            this.chartAngle.ChartAreas[2].AxisX.ScaleView.Zoom(minm, maksm);

            this.chartAngle.Series[2].Points.AddXY((minm + maksm) / 2, x3);

            this.chartAngle.Update();

            minm++;
            maksm++;
        }

        public void dataControll(string[] _datas)
        {
            int i = 0;
            foreach (string value in _datas)
            {
                if (value == string.Empty)
                {
                    _datas[i] = "0";
                    i++;
                }
            }
        }

        private void buttonDisconnect_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                try
                {
                    serialPort1.Close();
                    serialPort1.DataReceived -= SerialPort1_DataReceived;
                    
                    if (!serialPort1.IsOpen)
                    {
                        richTextBoxLogR.Text = string.Empty;
                        buttonConnect.Enabled = true;
                        buttonDisconnect.Enabled = false;
                        progressBar1.Value = 0;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex, "disconnect", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        //private void btnLoadIntoMap_Click(object sender, EventArgs e)
        //{
        //    map.DragButton = MouseButtons.Left;
        //    map.MapProvider = GMapProviders.GoogleMap;
        //    double lat = Convert.ToDouble(txtLat.Text);
        //    double longt = Convert.ToDouble(txtLong.Text);
        //    map.Position = new PointLatLng(lat, longt);
        //    map.MinZoom = 1;
        //    map.MaxZoom = 100;
        //    map.Zoom = 10;

        //    PointLatLng point = new PointLatLng(lat, longt);



        //    GMapMarker marker = new GMarkerGoogle(point, GMarkerGoogleType.blue_dot);


        //    //1
        //    GMapOverlay markers = new GMapOverlay("markers");

        //    //2
        //    markers.Markers.Add(marker);

        //    //3
        //    map.Overlays.Add(markers);

        //}

        void logger(string strLog)
        {
            try
            {
                string path = @"c:\\Logs\log.txt";
                using (StreamWriter file = new StreamWriter(path, true))
                {
                    file.Write(strLog + "\n");
                    file.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex, "Log", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                try
                {
                    serialPort1.Close();
                    serialPort1.DataReceived -= SerialPort1_DataReceived;
                    if (!serialPort1.IsOpen)
                    {
                        progressBar1.Value = 0;
                        buttonConnect.Enabled = true;
                        buttonDisconnect.Enabled = false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex, "disconnect", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                timer1.Enabled = false;
                timer1.Stop();
                
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (controller == curController)
            {
                error++;
            }
            else
            {
                error = 0;
            }
            if (error == 25)
            {
                MessageBox.Show("bağlantı koptu");
            }
            curController = controller;
        }

        private void buttonServoForm_Click(object sender, EventArgs e)
        {
            Form servo = new FormServo();
            
                serialPort1.Close();
                serialPort1.DataReceived -= SerialPort1_DataReceived;

                if (!serialPort1.IsOpen)
                {
                    richTextBoxLogR.Text = string.Empty;
                    buttonConnect.Enabled = true;
                    buttonDisconnect.Enabled = false;
                    progressBar1.Value = 0;
                }
            servo.Show();
        }
    }
}






