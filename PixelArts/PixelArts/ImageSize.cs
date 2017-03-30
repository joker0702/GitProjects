using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace PixelArts
{
    public class ImageSize
    {
        private Size _imageSize;

        public ImageSize(Size imageSize)
        {
            this._imageSize = imageSize;
        }

        public Size ImageSizeProperty
        {
            get
            {
                return _imageSize;
            }
            set
            {
                _imageSize = value;
            }
        }
    }
}
