using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mosaic
{
    public partial class FormMosaic : Form
    {
        ControlMos con;

        public FormMosaic()
        {
            int size = 6;
            InitializeComponent();
            con = new ControlMos(size);
            generatoinPicBox(size);
            //pictureBox1.Size = new Size(size * 65, size * 65);
            //pictureBox1.Image = con.start_pic();
        }
        
        private void generatoinPicBox(int size)
        {
            con.generatoinPicBox();
            for (int i = 0; i < size*size; i++)
            {
                Controls.Add(con.pic_box[i]);
            }
            Controls.Add(con.table);
        }

        private bool _moving;
        private Point _startLocation;

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            _moving = false;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (_moving)
            {
                pictureBox1.Left += e.Location.X - _startLocation.X;
                pictureBox1.Top += e.Location.Y - _startLocation.Y;
            }
        }

        private void pictureBox1_MouseDown_1(object sender, MouseEventArgs e)
        {
            _moving = true;
            _startLocation = e.Location;
        }

        private void level1_Click(object sender, EventArgs e)
        {
            int size = 6;
            con.deletePicBox();
            con = new ControlMos(size);
            generatoinPicBox(size);
            //pictureBox1.Size = new Size(size * 65, size * 65);
            //pictureBox1.Image = con.start_pic();
        }

        private void level2_Click(object sender, EventArgs e)
        {
            int size = 10;
            con.deletePicBox();
            con = new ControlMos(size);
            generatoinPicBox(size);
            //pictureBox1.Size = new Size(size * 65, size * 65);
            //pictureBox1.Image = con.start_pic();
        }

        private void level3_Click(object sender, EventArgs e)
        {
            int size = 16;
            con.deletePicBox();
            con = new ControlMos(size);
            generatoinPicBox(size);
            //pictureBox1.Size = new Size(size * 65, size * 65);
            //pictureBox1.Image = con.start_pic();
        }

        private void menu_Click(object sender, EventArgs e)
        {
            con.start_game();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (con.Add_pictire() == true)
            {
               // pictureBox1.Image = Control.big_img[Control.c];
                buttonRight.Enabled = true;
                buttonLeft.Enabled = true;
            }
        }

        private void buttonLeft_Click(object sender, EventArgs e)
        {
            if(con.Left_Click() == false)
            {
               // pictureBox1.Image = Control.big_img[Control.c];
                buttonLeft.Enabled = false;
            }
            else
            {
                buttonRight.Enabled = true;
                //pictureBox1.Image = Control.big_img[Control.c];
            }
        }

        private void buttonRight_Click(object sender, EventArgs e)
        {
            if (con.Right_Click() == false)
            {
                buttonRight.Enabled = false;
            }
            else
            {
                buttonLeft.Enabled = true;
               // pictureBox1.Image = Control.big_img[Control.c];
            }
        }
    }
}
