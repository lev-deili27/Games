using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Mosaic
{
    class ControlMos
    {
        LogicMos game; Picture pic;
        int size;
        public PictureBox[] pic_box;
        int count_img = 0, a = 0;
        public static Image[] big_img;
        int num, size_cell;
        public Point loc=new Point();
        static Random rand = new Random();
        public TableLayoutPanel table;
        public PointF[,] cell_origin;

        public ControlMos(int size)
        {
            this.size = size;
            if (size < 6) size = 6;
            if (size > 16) size = 16;
            generatoinTable();
            size_cell = (int)(table.Width * (100f / table.ColumnCount) / 100);
            game = new LogicMos(size);
            pic = new Picture(size, size_cell);
            start_pic();
            game.start();
            generatoinPicBox();
        }

        public void start_game()
        {
            game.start();
            deletePicBox();
            generatoinPicBox();
        }

        private void generatoinTable()
        {
            table = new TableLayoutPanel();
            table.Size = new Size(500, 500);
            table.ColumnCount = size;
            table.Name = "table";
            table.Location = new Point(150, 0);
            table.RowCount = size;
            table.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            table.BackColor = Color.White;

            int width = 100 / table.ColumnCount;
            int height = 100 / table.RowCount;

            for (int col = 0; col < table.ColumnCount; col++)
            {
                // добавляем колонку
                table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, width));

                for (int row = 0; row < table.RowCount; row++)
                {
                    // добавляем строку
                    if (col == 0)
                    {
                        table.RowStyles.Add(new RowStyle(SizeType.Percent, height));
                    }
                }
            }
        }

        public Image start_pic()
        {
            big_img = new Image[size];
            big_img[0] = (Image)Properties.Resources._1;
            pic.loading(big_img[0]);
            return big_img[0];
        } 

        public void generatoinPicBox()
        {
            pic_box = new PictureBox[size*size];
            int a = 0, j1=0, j2=0;
            for (int i = 0; i < size*size; ++i)
            {
                    pic_box[i] = new PictureBox();
                    pic_box[i].Size = new Size(size_cell, size_cell);
                    pic_box[i].Location = new Point(game.x[j1], game.y[j2]);
                    pic_box[i].Tag = a;
                    pic_box[i].Name = "pic_box" + a;
                    pic_box[i].MouseMove += picBoxMouseMove;
                    pic_box[i].MouseDown += picBoxMouseDown;
                    pic_box[i].MouseUp += picBoxMouseUp;
                    pic_box[i].Image = pic.img1.Images[(count_img * size * size) + i];
                    pic_box[i].Visible = true;
                    a++;
                j1 = rand.Next(0, size);
                j2 = rand.Next(0, size);
            }
        }

        private bool _moving;
        private Point _startLocation;

        private void picBoxMouseUp(object sender, MouseEventArgs e)
        {
            if (check()==true)
            {
                ((PictureBox)sender).Location = new Point(loc.X, loc.Y);
                ((PictureBox)sender).Enabled = false;
            }
            _moving = false;
        }

        private bool check()
        {
            int xt, yt;
            absolute_to_table(loc, out xt, out yt);
            int position_true = num;
            int position_real = game.coordinates_to_position(xt, yt);
            if (position_true == position_real&&xt!=-1&&yt!=-1)
            {
                loc = new Point((int)cell_origin[xt, yt].X, (int)cell_origin[xt, yt].Y);
                return true;
            }
            else return false;
        }

        private void picBoxMouseMove(object sender, MouseEventArgs e)
        {
            if (_moving)
            {
                loc.X=((PictureBox)sender).Left += e.Location.X - _startLocation.X;
                loc.Y=((PictureBox)sender).Top += e.Location.Y - _startLocation.Y;
            }
        }

        private void picBoxMouseDown(object sender, MouseEventArgs e)
        {
            _moving = true;
            _startLocation = e.Location;
            num = Convert.ToInt16(((PictureBox)sender).Tag);
        }

        private void absolute_to_table(PointF coord, out int xt, out int yt)
        {
            FormMosaic form = new FormMosaic();
            float widthForm = form.Width, heightForm = form.Height;
            float width_table = table.Width, height_table = table.Height;
            float a = 100f / table.ColumnCount, b = 100f / table.RowCount;
            float width_cell = table.Width * a / 100, height_cell = table.Height * b / 100;
            PointF table_origin = new PointF((widthForm - width_table) / 2, 0);
            cell_origin = new PointF[size, size];
            xt = -1; yt = -1;
            int i = 0, j = 0;
            while (i < size && j < size)
            {
                if (!((coord.X > table_origin.X + i * width_cell) &&
                    (coord.X < table_origin.X + (i + 1) * width_cell))) i++;
                else if (!((coord.Y > table_origin.Y + j * height_cell) &&
                        (coord.Y < table_origin.Y + (j + 1) * height_cell))) j++;
                else {
                    cell_origin[i, j] = new PointF(table_origin.X+i * width_cell, table_origin.Y+j * height_cell); //3-margin
                    xt = i;
                    yt = j;
                    break;
                }
            }
            
        }

        public void deletePicBox()
        {
            for (int i = 0; i < size*size; i++)
            {
                pic_box[i].Dispose();
            }
            table.Dispose();
        }

        public bool Add_pictire()
        {
            OpenFileDialog openImage = new OpenFileDialog();
            openImage.Filter = "Imege Files(*.JPG;*.PNG)|*.JPG;*.PNG|All files(*.*)|*.*";
            if (openImage.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Image img = Image.FromFile(openImage.FileName);
                    pic.loading(img);
                    count_img++;
                    big_img[count_img] = pic.img;
                    a++;
                    //start_game();
                    //refresh();
                    //c = count_img;
                    return true;
                }
                catch
                {
                    MessageBox.Show("Невозможно открыть файл!");
                    return false;
                }
            }
            else return false;
        }

        public bool Left_Click()
        {
            if (count_img == 0)
            {
                return false;
            }
            else
            {
                count_img--;
                //refresh();
                return true;
            }
        }

        public bool Right_Click()
        {
            if (a == count_img)
            {
                return false;
            }
            else
            {
                count_img++;
                //refresh();
                return true;
            }
        }
    }
}
