using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopCapture
{
    public partial class Form1 : Form
    {
        private Image desktopBitmap;
        private Graphics graphicsFromDesktop;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            tmrUpdate.Start();
        }

        private void tmrUpdate_Tick(object sender, EventArgs e)
        {
            desktopBitmap = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            using (graphicsFromDesktop = Graphics.FromImage(desktopBitmap))
            {
                graphicsFromDesktop.CopyFromScreen(Screen.PrimaryScreen.Bounds.Location, new Point(0,0), Screen.PrimaryScreen.Bounds.Size, CopyPixelOperation.SourceCopy);
            }

            if (pictureBox1.Image != null)
                pictureBox1.Image.Dispose();

            pictureBox1.Image = desktopBitmap;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.A:
                    break;
                case Keys.Add:
                    break;
                case Keys.Alt:
                    break;
                case Keys.Apps:
                    break;
                case Keys.Attn:
                    break;
                case Keys.B:
                    break;
                case Keys.Back:
                    break;
                case Keys.BrowserBack:
                    break;
                case Keys.BrowserFavorites:
                    break;
                case Keys.BrowserForward:
                    break;
                case Keys.BrowserHome:
                    break;
                case Keys.BrowserRefresh:
                    break;
                case Keys.BrowserSearch:
                    break;
                case Keys.BrowserStop:
                    break;
                case Keys.C:
                    break;
                case Keys.Cancel:
                    break;
                case Keys.Capital:
                    break;
                case Keys.Clear:
                    break;
                case Keys.Control:
                    break;
                case Keys.ControlKey:
                    break;
                case Keys.Crsel:
                    break;
                case Keys.D:
                    break;
                case Keys.D0:
                    break;
                case Keys.D1:
                    break;
                case Keys.D2:
                    break;
                case Keys.D3:
                    break;
                case Keys.D4:
                    break;
                case Keys.D5:
                    break;
                case Keys.D6:
                    break;
                case Keys.D7:
                    break;
                case Keys.D8:
                    break;
                case Keys.D9:
                    break;
                case Keys.Decimal:
                    break;
                case Keys.Delete:
                    break;
                case Keys.Divide:
                    break;
                case Keys.Down:
                    break;
                case Keys.E:
                    break;
                case Keys.End:
                    break;
                case Keys.Enter:
                    break;
                case Keys.EraseEof:
                    break;
                case Keys.Escape:
                    this.Close();
                    break;
                case Keys.Execute:
                    break;
                case Keys.Exsel:
                    break;
                case Keys.F:
                    break;
                case Keys.F1:
                    break;
                case Keys.F10:
                    break;
                case Keys.F11:
                    break;
                case Keys.F12:
                    break;
                case Keys.F13:
                    break;
                case Keys.F14:
                    break;
                case Keys.F15:
                    break;
                case Keys.F16:
                    break;
                case Keys.F17:
                    break;
                case Keys.F18:
                    break;
                case Keys.F19:
                    break;
                case Keys.F2:
                    break;
                case Keys.F20:
                    break;
                case Keys.F21:
                    break;
                case Keys.F22:
                    break;
                case Keys.F23:
                    break;
                case Keys.F24:
                    break;
                case Keys.F3:
                    break;
                case Keys.F4:
                    break;
                case Keys.F5:
                    break;
                case Keys.F6:
                    break;
                case Keys.F7:
                    break;
                case Keys.F8:
                    break;
                case Keys.F9:
                    break;
                case Keys.FinalMode:
                    break;
                case Keys.G:
                    break;
                case Keys.H:
                    break;
                case Keys.HanguelMode:
                    break;

                case Keys.Help:
                    break;
                case Keys.Home:
                    break;
                case Keys.I:
                    break;
                case Keys.IMEAccept:
                    break;
                case Keys.IMEConvert:
                    break;
                case Keys.IMEModeChange:
                    break;
                case Keys.IMENonconvert:
                    break;
                case Keys.Insert:
                    break;
                case Keys.J:
                    break;
                case Keys.JunjaMode:
                    break;
                case Keys.K:
                    break;
                case Keys.KeyCode:
                    break;
                case Keys.L:
                    break;
                case Keys.LButton:
                    break;
                case Keys.LControlKey:
                    break;
                case Keys.LMenu:
                    break;
                case Keys.LShiftKey:
                    break;
                case Keys.LWin:
                    break;
                case Keys.LaunchApplication1:
                    break;
                case Keys.LaunchApplication2:
                    break;
                case Keys.LaunchMail:
                    break;
                case Keys.Left:
                    break;
                case Keys.LineFeed:
                    break;
                case Keys.M:
                    break;
                case Keys.MButton:
                    break;
                case Keys.MediaNextTrack:
                    break;
                case Keys.MediaPlayPause:
                    break;
                case Keys.MediaPreviousTrack:
                    break;
                case Keys.MediaStop:
                    break;
                case Keys.Menu:
                    break;
                case Keys.Modifiers:
                    break;
                case Keys.Multiply:
                    break;
                case Keys.N:
                    break;
                case Keys.Next:
                    break;
                case Keys.NoName:
                    break;
                case Keys.None:
                    break;
                case Keys.NumLock:
                    break;
                case Keys.NumPad0:
                    break;
                case Keys.NumPad1:
                    break;
                case Keys.NumPad2:
                    break;
                case Keys.NumPad3:
                    break;
                case Keys.NumPad4:
                    break;
                case Keys.NumPad5:
                    break;
                case Keys.NumPad6:
                    break;
                case Keys.NumPad7:
                    break;
                case Keys.NumPad8:
                    break;
                case Keys.NumPad9:
                    break;
                case Keys.O:
                    break;
                case Keys.Oem1:
                    break;
                case Keys.Oem102:
                    break;
                case Keys.Oem2:
                    break;
                case Keys.Oem3:
                    break;
                case Keys.Oem4:
                    break;
                case Keys.Oem5:
                    break;
                case Keys.Oem6:
                    break;
                case Keys.Oem7:
                    break;
                case Keys.Oem8:
                    break;
                case Keys.OemClear:
                    break;
                case Keys.OemMinus:
                    break;
                case Keys.OemPeriod:
                    break;
                case Keys.Oemcomma:
                    break;
                case Keys.Oemplus:
                    break;
                case Keys.P:
                    break;
                case Keys.Pa1:
                    break;
                case Keys.Packet:
                    break;
                case Keys.PageUp:
                    break;
                case Keys.Pause:
                    break;
                case Keys.Play:
                    break;
                case Keys.Print:
                    break;
                case Keys.PrintScreen:
                    break;
                case Keys.ProcessKey:
                    break;
                case Keys.Q:
                    break;
                case Keys.R:
                    break;
                case Keys.RButton:
                    break;
                case Keys.RControlKey:
                    break;
                case Keys.RMenu:
                    break;
                case Keys.RShiftKey:
                    break;
                case Keys.RWin:
                    break;
                case Keys.Right:
                    break;
                case Keys.S:
                    break;
                case Keys.Scroll:
                    break;
                case Keys.Select:
                    break;
                case Keys.SelectMedia:
                    break;
                case Keys.Separator:
                    break;
                case Keys.Shift:
                    break;
                case Keys.ShiftKey:
                    break;
                case Keys.Sleep:
                    break;
                case Keys.Space:
                    break;
                case Keys.Subtract:
                    break;
                case Keys.T:
                    break;
                case Keys.Tab:
                    break;
                case Keys.U:
                    break;
                case Keys.Up:
                    break;
                case Keys.V:
                    break;
                case Keys.VolumeDown:
                    break;
                case Keys.VolumeMute:
                    break;
                case Keys.VolumeUp:
                    break;
                case Keys.W:
                    break;
                case Keys.X:
                    break;
                case Keys.XButton1:
                    break;
                case Keys.XButton2:
                    break;
                case Keys.Y:
                    break;
                case Keys.Z:
                    break;
                case Keys.Zoom:
                    break;
                default:
                    break;
            }
        }
    }
}
