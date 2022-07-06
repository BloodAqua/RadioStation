using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kurs
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MusicArhiv musicArhiv = new MusicArhiv();
            musicArhiv.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormOtdelKadrov formOtdelKadrov = new FormOtdelKadrov();
            formOtdelKadrov.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormSetkaVechaniya formSetkaVechaniya = new FormSetkaVechaniya();
            formSetkaVechaniya.ShowDialog();
        }
    }
}
