using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SG
{
    public partial class Menuadmin : Form
    {
        public Menuadmin()
        {
            InitializeComponent();
        }

        private void Btn_regop_Click(object sender, EventArgs e)
        {
            agregarop1.BringToFront();
        }

        private void Btn_establo_Click(object sender, EventArgs e)
        {
            white1.BringToFront();
        }

        private void GunaPictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void gunaPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gunaCircleButton1_Click(object sender, EventArgs e)
        {
            reg_ganado ganado = new reg_ganado();
            ganado.Show();
        }
    }
}
