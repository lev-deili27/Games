using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Mosaic
{
    class Picture
    {
        public Image img;
        int game_size, pic_size;
        int size_cell = 65;
        public ImageList img1 = new ImageList();


        public Picture(int size)
        {
            this.game_size = size;
            this.pic_size = size * 65;
        }

        public Picture(int size, int size_cell)
        {
            this.game_size = size;
            this.size_cell = size_cell;
            this.pic_size = size * size_cell;
        }

        public Image loading(Image img1)
        {
            this.img = img1;
            return img = framing(img, new Rectangle(indent_w(), 0, size_img(), size_img()));
        }

        private int indent_w()
        {
            if (((img.Size.Height / img.Size.Width) > 0.9) && ((img.Size.Height / img.Size.Width) < 1.1)) return 0;
            else if (((img.Size.Height / img.Size.Width) > 0.7) && ((img.Size.Height / img.Size.Width) < 1.3)) return img.Size.Width / 6;
            else return img.Size.Width / 4;
        }

        private int size_img()
        {
            int width = img.Size.Width;
            int height = img.Size.Height;
            if (width < height)
            {
                if (width < pic_size)
                {
                    return pic_size;
                }
                else return width;
            }
            else
            {
                if (height < pic_size)
                {
                    return pic_size;
                }
                else return height;
            }

        }

        Bitmap framing(Image src, Rectangle rect)
        {
            var ret = new Bitmap(rect.Width, rect.Height);
            using (var g = Graphics.FromImage(ret))
                g.DrawImage(src, 0, 0, rect, GraphicsUnit.Pixel);
            src = ret;
            ret = new Bitmap(src, new Size(pic_size, pic_size));
            //img1.Images.Add(ret);
            cut(ret);
            return ret;
        }

        private void cut(Bitmap ret)
        {
            img1.ImageSize = new Size(size_cell, size_cell);
            img1.ColorDepth = ColorDepth.Depth32Bit;
            for (int i = 0; i < ret.Width; i += size_cell)
            {
                for (int j = 0; j < ret.Height; j += size_cell)
                {
                    img1.Images.Add(ret.Clone(new Rectangle(j, i, size_cell, size_cell), ret.PixelFormat));
                }
            }
        }
    }
}
