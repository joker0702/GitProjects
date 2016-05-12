using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;

namespace CamCaputure
{
    public partial class Form1 : Form
    {
        private FilterInfoCollection _webcams;
        private VideoCaptureDevice _camera;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _webcams = new FilterInfoCollection(FilterCategory.VideoInputDevice);

            foreach (FilterInfo webcam in _webcams)
            {
                string webCamName = webcam.Name;
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (_webcams.Count == 0)
            {
                MessageBox.Show("No Webcam installed!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
                
            _camera = new VideoCaptureDevice(_webcams[0].MonikerString);
            _camera.NewFrame += _camera_NewFrame;
            _camera.Start();
        }

        void _camera_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap bitmap = (Bitmap)eventArgs.Frame.Clone();
            pbxWebcam.Image = bitmap;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            if (_camera != null)
            {
                if (_camera.IsRunning)
                    _camera.Stop();
            }
        }
    }
}
