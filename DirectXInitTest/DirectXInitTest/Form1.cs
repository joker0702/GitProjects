using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SharpDX;
using SharpDX.Direct3D9;
using System.Runtime.InteropServices;

namespace DirectXInitTest
{
    public partial class Form1 : Form
    {
        private Direct3D direct3dInterface;
        private Device direct3dDevice;
        private VertexBuffer vertexBuffer;
        private CustomVertex[] customVertex;
        private const VertexFormat vertexFormat = VertexFormat.PositionRhw | VertexFormat.Diffuse;
        private struct CustomVertex
        {
            public float x, y, z, rhw;
            public ColorBGRA color;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            direct3dInterface = new Direct3D();

            PresentParameters[] paramters = new PresentParameters[1];

            paramters[0].Windowed = true;
            paramters[0].SwapEffect = SwapEffect.Discard;
            paramters[0].DeviceWindowHandle = this.Handle;

            direct3dDevice = new Device(direct3dInterface, 0, DeviceType.Hardware, this.Handle, CreateFlags.SoftwareVertexProcessing, paramters);

            if (direct3dDevice == null)
            {
                MessageBox.Show("Error: Can not initialize Direct3D Device", Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Vertex[] vertices = new Vertex[] 
            {
                new Vertex(0.0f, 0.5f, 0.0f, 1.0f, 0.0f, 0.0f, 1.0f),
                new Vertex(0.5f, -.5f, 0.0f, 0.0f, 1.0f, 0.0f, 1.0f),
                new Vertex(-.5f, -.5f, 0.0f, 0.0f, 0.0f, 1.0f, 1.0f),
            };

            int bufferSize = 3 * Marshal.SizeOf<CustomVertex>();
            vertexBuffer = new VertexBuffer(direct3dDevice, bufferSize, Usage.None, vertexFormat, Pool.Managed);
            

            tmrUpdate.Start();
        }

        private void tmrUpdate_Tick(object sender, EventArgs e)
        {
            direct3dDevice.Clear(ClearFlags.Target, ColorBGRA.FromRgba(int.MinValue), 1.0f, 0);

            direct3dDevice.BeginScene();

            direct3dDevice.SetStreamSource(0, vertexBuffer, 0, Marshal.SizeOf<CustomVertex>());
            direct3dDevice.VertexFormat = vertexFormat;
            direct3dDevice.DrawPrimitives(PrimitiveType.TriangleList, 0, 1);

            direct3dDevice.EndScene();

            direct3dDevice.Present();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (direct3dInterface != null)
            {
                direct3dInterface.Dispose();
                direct3dInterface = null;
            }
            if (direct3dDevice != null)
            {
                direct3dDevice.Dispose();
                direct3dDevice = null;
            }
            if (vertexBuffer != null)
            {
                vertexBuffer.Dispose();
                vertexBuffer = null;
            }
        }
    }
}
