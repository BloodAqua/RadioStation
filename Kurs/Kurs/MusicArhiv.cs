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
    public partial class MusicArhiv : Form
    {
        public MusicArhiv()
        {
            InitializeComponent();
        }

        private void MusicArhiv_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kursovoyDataSet.Исполнители". При необходимости она может быть перемещена или удалена.
            this.исполнителиTableAdapter.Fill(this.kursovoyDataSet.Исполнители);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kursovoyDataSet.Жанры". При необходимости она может быть перемещена или удалена.
            this.жанрыTableAdapter.Fill(this.kursovoyDataSet.Жанры);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kursovoyDataSet.Музыкльный_архив". При необходимости она может быть перемещена или удалена.
            this.музыкльный_архивTableAdapter.Fill(this.kursovoyDataSet.Музыкльный_архив);

        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                this.фильтрПоЖанрамTableAdapter.Fill(this.kursovoyDataSet.ФильтрПоЖанрам, comboBox1.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void fillToolStripButton_Click_1(object sender, EventArgs e)
        {


        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                this.фильтрПоИсполнителямTableAdapter.Fill(this.kursovoyDataSet.ФильтрПоИсполнителям, comboBox2.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
    }
}
