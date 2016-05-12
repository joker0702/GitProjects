using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenTK;
using OpenTK.Graphics;
using OpenTK.Input;
using OpenTK.Graphics.OpenGL;

namespace ViereckOpenGL
{
    public partial class Form1 : Form
    {
        private GameWindow window;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            window = new GameWindow(800, 600, GraphicsMode.Default, "Viereck");
            window.RenderFrame += Window_RenderFrame;
            window.Run();
        }

        private void Window_RenderFrame(object sender, FrameEventArgs e)
        {
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);
            GL.MatrixMode(MatrixMode.Projection);
            GL.Ortho(-1.0, 1.0, -1.0, 1.0, 0.0, 4.0);

            GL.Begin(PrimitiveType.Quads);

            GL.Color4(Color4.Red);
            GL.Vertex2(new Vector2d(0.9f, -0.9f));
            GL.Color4(Color4.Green);
            GL.Vertex2(new Vector2d(0.9f, 0.9f));
            GL.Color4(Color4.Black);
            GL.Vertex2(new Vector2d(-0.9f, 0.9f));
            GL.Color4(Color4.Blue);
            GL.Vertex2(new Vector2d(-0.9f, -0.9f));

            GL.End();

            window.SwapBuffers();
        }
    }
}
