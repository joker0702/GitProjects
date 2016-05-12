using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeadPixelDetection
{
    public partial class Form1 : Form
    {
        private List<Color> colors;
        private IEnumerator<Color> color;
        public enum ExecutonState : uint
        {
            AwayModeRequired = 0x00000040,
            Continous = 0x80000000,
            DisplayRequired = 0x00000002,
            SystemRequired = 0x00000001
        }

        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        static extern ExecutonState SetThreadExecutionState(ExecutonState flag);

        public Form1()
        {
            InitializeComponent();
        }

        private void changeColor_Tick(object sender, EventArgs e)
        {
            if (color.MoveNext())
                this.BackColor = color.Current;
            else
                color.Reset();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            colors = new List<Color>();
            colors.Add(Color.Black);
            colors.Add(Color.White);
            colors.Add(Color.Red);
            colors.Add(Color.Green);
            colors.Add(Color.Blue);
            color = colors.GetEnumerator();

            SetThreadExecutionState(ExecutonState.Continous | ExecutonState.DisplayRequired | ExecutonState.SystemRequired);

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

        private void Form2_MouseDown(object sender, MouseEventArgs e)
        {
            if (color.MoveNext())
                this.BackColor = color.Current;
            else
                color.Reset();
        }
    }
}
