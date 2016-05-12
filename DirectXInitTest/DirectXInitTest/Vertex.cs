using SharpDX;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectXInitTest
{
    class Vertex
    {
        public Vector4 position;
        public Color4 color;

        public Vertex(float x, float y, float z, float r, float g, float b, float alpha)
        {
            position = new Vector4(x, y, z, 1.0f);
            color = new Color4(r, g, b, alpha);
        }
    }
}
