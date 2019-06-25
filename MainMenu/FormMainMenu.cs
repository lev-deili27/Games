using System;
using System.Windows.Forms;

namespace MainMenu
{
    public partial class FormMainMenu : Form
    {
        public FormMainMenu()
        {
            InitializeComponent();
        }

        private void but_Game15_Click(object sender, EventArgs e)
        {
            Game15.FormGame15 game15 = new Game15.FormGame15();
            game15.Show();
        }

        private void but_mosaic_Click(object sender, EventArgs e)
        {
            Mosaic.FormMosaic mosaic = new Mosaic.FormMosaic();
            mosaic.Show();
            
        }
    }
}
