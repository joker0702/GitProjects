using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeadPixelDetection
{
    public partial class Form1 : Form
    {
        private List<Color> colors;
        private IEnumerator<Color> color;

        public Form1()
        {
            InitializeComponent();
        }

        private void changeColor_Tick(object sender, EventArgs e)
        {
            if (color.MoveNext())
                this.BackColor = color.Current;
            else
                this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            colors = new List<Color>();
            colors.Add(Color.Black);
            colors.Add(Color.Red);
            colors.Add(Color.Green);
            colors.Add(Color.Blue);
            color = colors.GetEnumerator();
            if (Screen.AllScreens.Length > 1)
                Bounds = Screen.AllScreens[1].Bounds;

            changeColor.Start();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    this.Close();
                    break;
                default:
                    break;
            }
        }
    }
}
