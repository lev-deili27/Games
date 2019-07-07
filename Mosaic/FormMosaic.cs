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
        }
        
        private void generatoinPicBox(int size)
        {
            con.GeneratoinPicBox();
            for (int i = 0; i < size*size; i++)
            {
                Controls.Add(con.pic_box[i]);
            }
            Controls.Add(con.table);
        }
        
        private void level1_Click(object sender, EventArgs e)
        {
            int size = 6;
            con.DeletePicBox();
            con = new ControlMos(size);
            generatoinPicBox(size);
        }

        private void level2_Click(object sender, EventArgs e)
        {
            int size = 10;
            con.DeletePicBox();
            con = new ControlMos(size);
            generatoinPicBox(size);
        }

        private void level3_Click(object sender, EventArgs e)
        {
            int size = 16;
            con.DeletePicBox();
            con = new ControlMos(size);
            generatoinPicBox(size);
        }

        private void menu_Click(object sender, EventArgs e)
        {
            con.start_game();
        } //start - Кнопка начать заново

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (con.Add_picture() == true)
            {
                buttonRight.Enabled = true;
                buttonLeft.Enabled = true;
            }
        }

        private void buttonLeft_Click(object sender, EventArgs e)
        {
            if(con.Left_Click() == false)
            {
                buttonLeft.Enabled = false;
            }
            else
            {
                buttonRight.Enabled = true;
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
            }
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            FormHelp newForm = new FormHelp(con.Help());
            newForm.Show();
        }

        private void savegame_Click(object sender, EventArgs e)
        {
            con.Save();
        }

        private void loadSavedGame_Click(object sender, EventArgs e)
        {
            int size = con.loadsize();
            con.DeletePicBox();
            con = new ControlMos(size);
            generatoinPicBox(size);
            con.loadSavedGame();
        }
    }
}
