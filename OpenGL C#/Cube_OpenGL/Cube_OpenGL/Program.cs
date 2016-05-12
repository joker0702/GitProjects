using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK;
using OpenTK.Graphics;
using OpenTK.Input;
using OpenTK.Graphics.OpenGL;

namespace Cube_OpenGL
{
    class Program
    {
        private static GameWindow window;

        static void Main(string[] args)
        {
            window = new GameWindow(800, 600, GraphicsMode.Default, "Cube");
            window.RenderFrame += Window_RenderFrame;
            window.KeyDown += Window_KeyDown;
            GL.Enable(EnableCap.DepthTest);
            window.Run();
        }

        private static void Window_KeyDown(object sender, KeyboardKeyEventArgs e)
        {
            double coord_y = 0;
            double coord_x = 0;

            if (e.Key == Key.Up)
            {
                coord_x = 1;
                coord_x *= 1;
            }

            if (e.Key == Key.Down)
            {
                coord_x = 1;
                coord_x *= -1;
            }

            if (e.Key == Key.Right)
            {
                coord_y = 1;
                coord_y *= 1;
            }

            if (e.Key == Key.Left)
            {
                coord_y = 1;
                coord_y *= -1;
            }

            GL.Rotate(0.5, new Vector3d(coord_x, 0.0, 0.0));
            GL.Rotate(0.5, new Vector3d(0.0, coord_y, 0.0));
        }

        private static void Window_RenderFrame(object sender, FrameEventArgs e)
        {
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);
            GL.MatrixMode(MatrixMode.Projection);
            GL.ClearColor(Color4.LightBlue);
            //GL.Ortho(1.0, -1.0, 1.0, -1.0, 0.0, 4.0);
            
            //GL.Rotate(0.1, new Vector3d(1.0, 1.0, 0.0));

            // Draw Frontside
            GL.Begin(PrimitiveType.Polygon);
            GL.Color4(Color4.Yellow);
            GL.Vertex3(new Vector3d(0.5, -0.5, -0.5));
            GL.Vertex3(new Vector3d(0.5, 0.5, -0.5));
            GL.Vertex3(new Vector3d(-0.5, 0.5, -0.5));
            GL.Vertex3(new Vector3d(-0.5, -0.5, -0.5));
            GL.End();
            
            // Draw Backside
            GL.Begin(PrimitiveType.Polygon);
            GL.Color4(Color4.White);
            GL.Vertex3(new Vector3d(0.5, -0.5, 0.5));
            GL.Vertex3(new Vector3d(0.5, 0.5, 0.5));
            GL.Vertex3(new Vector3d(-0.5, 0.5, 0.5));
            GL.Vertex3(new Vector3d(-0.5, -0.5, 0.5));
            GL.End();

            // Draw Righside
            GL.Begin(PrimitiveType.Polygon);
            GL.Color4(Color4.Purple);
            GL.Vertex3(new Vector3d(0.5, -0.5, -0.5));
            GL.Vertex3(new Vector3d(0.5, 0.5, -0.5));
            GL.Vertex3(new Vector3d(0.5, 0.5, 0.5));
            GL.Vertex3(new Vector3d(0.5, -0.5, 0.5));
            GL.End();

            // Draw Leftside
            GL.Begin(PrimitiveType.Polygon);
            GL.Color4(Color4.Green);
            GL.Vertex3(new Vector3d(-0.5, -0.5, 0.5));
            GL.Vertex3(new Vector3d(-0.5, 0.5, 0.5));
            GL.Vertex3(new Vector3d(-0.5, 0.5, -0.5));
            GL.Vertex3(new Vector3d(-0.5, -0.5, -0.5));
            GL.End();

            // Draw Topside
            GL.Begin(PrimitiveType.Polygon);
            GL.Color4(Color4.Blue);
            GL.Vertex3(new Vector3d(0.5, 0.5, 0.5));
            GL.Vertex3(new Vector3d(0.5, 0.5, -0.5));
            GL.Vertex3(new Vector3d(-0.5, 0.5, -0.5));
            GL.Vertex3(new Vector3d(-0.5, 0.5, 0.5));
            GL.End();

            // Draw Bottomside
            GL.Begin(PrimitiveType.Polygon);
            GL.Color4(Color4.Red);
            GL.Vertex3(new Vector3d(0.5, -0.5, -0.5));
            GL.Vertex3(new Vector3d(0.5, -0.5, 0.5));
            GL.Vertex3(new Vector3d(-0.5, -0.5, 0.5));
            GL.Vertex3(new Vector3d(-0.5, -0.5, -0.5));
            GL.End();

            GL.Flush();
            window.SwapBuffers();
        }
    }
}
