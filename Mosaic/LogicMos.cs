using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mosaic
{
    class LogicMos
    {
        int size;
        public int[] x, y;
        static Random rand = new Random();
        static int size_pic_box=65, size_form=500;


        public LogicMos(int size)
        {
            if (size < 6) size = 6;
            if (size > 16) size = 16;
            this.size = size;
            x = new int[size];
            y = new int[size];
        }

        public void start()
        {
            for (int i = 0; i < size; i++)
            {
                x[i] = rand.Next(0, size_form - size_pic_box);
                y[i] = rand.Next(0, size_form - size_pic_box);
            }
        }

        public int coordinates_to_position(int x, int y)
        {
            if (x < 0) x = 0;
            if (x > size - 1) x = size - 1;
            if (y < 0) y = 0;
            if (y > size - 1) y = size - 1;
            return y * size + x;
        }
    }
}
