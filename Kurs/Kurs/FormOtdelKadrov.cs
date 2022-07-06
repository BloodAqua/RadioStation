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
    public partial class FormOtdelKadrov : Form
    {
        public FormOtdelKadrov()
        {
            InitializeComponent();
        }

        private void FormOtdelKadrov_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kursovoyDataSet.Должности". При необходимости она может быть перемещена или удалена.
            this.должностиTableAdapter.Fill(this.kursovoyDataSet.Должности);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kursovoyDataSet.Отдел_кадров". При необходимости она может быть перемещена или удалена.
            this.отдел_кадровTableAdapter.Fill(this.kursovoyDataSet.Отдел_кадров);

        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                this.фильтрПоДолжностямTableAdapter.Fill(this.kursovoyDataSet.ФильтрПоДолжностям, comboBox1.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
    }
}
