using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
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
        public PictureBox[] pic_box; // Массив кусочков мозайки
        int count_img = 0, a = 0; // Для перелистывания добавленных изоражений
        public static Image[] big_img; // Кадрированные добавленные изоражений для FormHelp
        int num, size_cell; //num - номер кусочка мозайки 
        public Point loc=new Point();
        static Random rand = new Random();
        public TableLayoutPanel table; //Таблица для размещения кусочков мозайки
        public PointF cell_origin;

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
            GeneratoinPicBox();
        }

        public void start_game()
        {
            game.start();
            int j1 = rand.Next(0, size), j2 = rand.Next(0, size);
            for (int i = 0; i < size * size; ++i)
            {
                pic_box[i].Location = new Point(game.x[j1], game.y[j2]);
                j1 = rand.Next(0, size);
                j2 = rand.Next(0, size);
            }
        }

        private void generatoinTable()
        {
            table = new TableLayoutPanel();
            table.Size = new Size(500, 500);
            table.ColumnCount = size;
            table.Name = "table";
            table.Location = new Point(0, 24);
            table.RowCount = size;
            table.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            table.BackColor = Color.White;

            int width = Convert.ToInt16(Math.Round(100f / table.ColumnCount));
            int height = Convert.ToInt16(Math.Round(100f / table.RowCount));

            for (int col = 0; col < table.ColumnCount; col++)
            {
                
                table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, width));// добавляем колонку
                for (int row = 0; row < table.RowCount; row++)
                {
                    if (col == 0)// добавляем строку
                    {
                        table.RowStyles.Add(new RowStyle(SizeType.Percent, height));
                    }
                }
            }
        }

        //Загружет начальное изображение из ресурсов
        public Image start_pic()
        {
            big_img = new Image[size];
            big_img[0] = pic.loading(Properties.Resources._1);
            return big_img[0];
        } 

        public void GeneratoinPicBox()
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
                    pic_box[i].MouseMove += PicBoxMouseMove;
                    pic_box[i].MouseDown += PicBoxMouseDown;
                    pic_box[i].MouseUp += PicBoxMouseUp;
                    pic_box[i].Image = pic.img1.Images[(count_img * size * size) + i];
                    pic_box[i].Visible = true;
                    a++;
                j1 = rand.Next(0, size);
                j2 = rand.Next(0, size);
            }
        }

        private bool _moving;
        private Point _startLocation;

        private void PicBoxMouseUp(object sender, MouseEventArgs e)
        {
            if (Check() == true)
            {
                ((PictureBox)sender).Location = new Point(loc.X, loc.Y);
                ((PictureBox)sender).Enabled = false;
                if (game.check())
                {
                    MessageBox.Show("Вы победили!");
                }
            }
            _moving = false;
        }

        private bool Check()
        {
            int xt, yt;
            Absolute_to_table(loc, out xt, out yt);
            int position_true = num;
            int position_real = game.coordinates_to_position(xt, yt);
            if (position_true == position_real&&xt!=-1&&yt!=-1)
            {
                loc = new Point((int)cell_origin.X, (int)cell_origin.Y);
                return true;
            }
            else return false;
        }

        private void PicBoxMouseMove(object sender, MouseEventArgs e)
        {
            if (_moving)
            {
                loc.X=((PictureBox)sender).Left += e.Location.X - _startLocation.X;
                loc.Y=((PictureBox)sender).Top += e.Location.Y - _startLocation.Y;
            }
        }

        private void PicBoxMouseDown(object sender, MouseEventArgs e)
        {
            _moving = true;
            _startLocation = e.Location;
            num = Convert.ToInt16(((PictureBox)sender).Tag);
        }

        //Переводит абсолютные координаты в табличные
        private void Absolute_to_table(PointF coord, out int xt, out int yt) 
        {
            float a = 100f / table.ColumnCount, b = 100f / table.RowCount;
            float width_cell = table.Width * a / 100, height_cell = table.Height * b / 100;
            xt = -1; yt = -1;
            int i = 0, j = 0;
            while (i < size && j < size) 
            {
                if (!((coord.X > table.Location.X + i * width_cell) &&
                    (coord.X < table.Location.X + (i + 1) * width_cell))) i++;
                else if (!((coord.Y > table.Location.Y + j * height_cell) &&
                        (coord.Y < table.Location.Y + (j + 1) * height_cell))) j++;
                else {
                    cell_origin = new PointF(table.Location.X+i * width_cell, table.Location.Y+j * height_cell); //3-margin
                    xt = i;
                    yt = j;
                    break;
                }
            }
        }

        public void DeletePicBox()
        {
            for (int i = 0; i < size*size; i++)
            {
                pic_box[i].Dispose();
            }
            table.Dispose();
        }

        public bool Add_picture()
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
                    Refresh();
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
                Refresh();
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
                Refresh();
                return true;
            }
        }

        private void Refresh()
        {
            for (int i = 0; i < size * size; ++i)
            {
                pic_box[i].Image = null;
                pic_box[i].Image = pic.img1.Images[(count_img * size * size) + i];
            }
        }

        //Возвращает изображение для FormHelp
        public Image Help()
        {
            return big_img[count_img];
        }

        public void Save()
        {
            using (StreamWriter str = new StreamWriter(@"E:\isd\Games\SaveGame.txt"))
            {
                str.WriteLine(size);
                for (int i = 0; i < size * size; i++)
                {
                    int x = pic_box[i].Location.X;
                    str.WriteLine(x);
                    int y = pic_box[i].Location.Y;
                    str.WriteLine(y);
                }
                str.Close();
            }
        }

        public void loadSavedGame()
        {
            var fi = new FileInfo(@"E:\isd\Games\SaveGame.txt");
            if (fi.Length == 0)
            {
                MessageBox.Show("Нет сохранненой игры.");
            }
            else
            {
                using (StreamReader str = new StreamReader(@"E:\isd\Games\SaveGame.txt", System.Text.Encoding.Default))
                {
                    int[] X = new int[size*size];
                    int[] Y = new int[size*size];
                    string line;
                    line = str.ReadLine();
                    for (int i = 0; i < size*size; i++)
                    {
                        line = str.ReadLine();
                        X[i] = Convert.ToInt32(line);
                        line = str.ReadLine();
                        Y[i] = Convert.ToInt32(line);
                        pic_box[i].Location = new Point(X[i], Y[i]);
                    }
                    //rewrite_m();
                    //refresh();
                }
            }
        }

        public int loadsize()
        {
            int s;
            using (StreamReader str = new StreamReader(@"E:\isd\Games\SaveGame.txt", System.Text.Encoding.Default))
            {
                s = Convert.ToInt32(str.ReadLine());
            }
            return s;
        }
    }
}
