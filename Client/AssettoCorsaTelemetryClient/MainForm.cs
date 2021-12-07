using ACCSharedMemory;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssettoCorsaTelemetryClient
{
    public partial class MainForm : Form
    {
        private AssettoCorsaTelemetryReader telemetryReader;
        public MainForm()
        {
            InitializeComponent();
            telemetryReader = new AssettoCorsaTelemetryReader();
            telemetryReader.OnTelemetryRead += TelemetryReader_OnTelemetryRead;
        }

        private void TelemetryReader_OnTelemetryRead(AssettoCorsaTelemetry telemetry)
        {
            var texto = JsonConvert.SerializeObject(telemetry, Formatting.Indented);
            richTextBox1.BeginInvoke((MethodInvoker)delegate ()
            {
                richTextBox1.Text = texto;
                lblLastRefresh.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
            });
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            telemetryReader.Start();
            btnStart.Enabled = false;
            btnStop.Enabled = true;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            telemetryReader.Stop();
            btnStart.Enabled = true;
            btnStop.Enabled = false;
        }
    }
}
