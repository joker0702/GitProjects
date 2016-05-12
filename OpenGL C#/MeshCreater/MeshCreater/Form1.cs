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

namespace MeshCreater
{
    public partial class Form1 : Form
    {
        private GameWindow game;
        private double frame;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            game = new GameWindow(800, 600, GraphicsMode.Default, "Primitive Draw");
            game.Load += Game_Load;
            game.Resize += Game_Resize;
            game.RenderFrame += Game_RenderFrame;
            game.UpdateFrame += Game_UpdateFrame;
            game.KeyDown += Game_KeyDown;
            game.Run();
        }

        private void Game_KeyDown(object sender, KeyboardKeyEventArgs e)
        {
            if (e.Key == Key.Escape)
            {
                game.Exit();
                this.Close();
            }
        }

        private void Game_UpdateFrame(object sender, FrameEventArgs e)
        {
            
        }

        private void Game_Resize(object sender, EventArgs e)
        {
            GL.Viewport(0, 0, game.Width, game.Height);
        }

        private void Game_Load(object sender, EventArgs e)
        {
            game.VSync = VSyncMode.On;
            frame = 0;
        }

        private void Game_RenderFrame(object sender, FrameEventArgs e)
        {
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);

            GL.MatrixMode(MatrixMode.Projection);
            GL.LoadIdentity();
            GL.Ortho(-1.0f, 1.0, -1.0, 1.0, 0.0, 4.0);

            GL.Begin(PrimitiveType.Triangles);

            GL.Color4(Color4.Red);
            GL.Vertex2(new Vector2(0.9f, -0.9f));
            GL.Color4(Color4.Green);
            GL.Vertex2(new Vector2(0.0f, 0.9f));
            GL.Color4(Color4.Blue);
            GL.Vertex2(new Vector2(-0.9f, -0.9f));

            GL.End();

            game.SwapBuffers();
        }
    }
}
