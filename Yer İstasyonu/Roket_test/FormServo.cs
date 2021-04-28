using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Roket_test
{
    public partial class FormServo : Form
    {
        public FormServo()
        {
            InitializeComponent();
        }

        private void FormServo_Load(object sender, EventArgs e)
        {
            serialPort1.PortName = Portas.PortCom;
            serialPort1.BaudRate = Portas.PortBaud;
            serialPort1.DataBits = 8;
            serialPort1.Open();
            trackBarUp.Maximum = 100;
            trackBarUp.Minimum = 0;
            trackBarLow.Maximum = 100;
            trackBarLow.Minimum = 0;
        }

        private void trackBarUp_Scroll(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {                
                serialPort1.WriteLine("u" + String.Format("{0:000}", trackBarUp.Value));
                lblDegreeUp.Text = trackBarUp.Value.ToString();
            }
        }

        private void trackBarLow_Scroll(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.WriteLine("l" + String.Format("{0:000}", trackBarLow.Value));
                lblDegreeLow.Text = trackBarLow.Value.ToString();
            }
        }
    }
}
