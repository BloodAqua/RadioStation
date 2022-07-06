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
    public partial class FormSetkaVechaniya : Form
    {
        public FormSetkaVechaniya()
        {
            InitializeComponent();
        }

        private void FormSetkaVechaniya_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kursovoyDataSet.Сотрудники". При необходимости она может быть перемещена или удалена.
            this.сотрудникиTableAdapter.Fill(this.kursovoyDataSet.Сотрудники);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kursovoyDataSet.СеткаВещания". При необходимости она может быть перемещена или удалена.
            this.сеткаВещанияTableAdapter.Fill(this.kursovoyDataSet.СеткаВещания);

        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                this.фильтрПоСотрудникамTableAdapter.Fill(this.kursovoyDataSet.ФильтрПоСотрудникам, comboBox1.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void fillToolStripButton_Click_1(object sender, EventArgs e)
        {


        }


    }
}
