using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Повышение_квалификации
{
    public partial class ПросмотКурсов : Form
    {
        МенюПреподавателя _menu = null;

        public ПросмотКурсов(МенюПреподавателя menu)
        {
            _menu = menu;
            InitializeComponent();
        }

        private void ПросмотКурсов_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "silverHa.Курсы". При необходимости она может быть перемещена или удалена.
            //this.курсыTableAdapter1.Fill(this.silverHa.Курсы);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "курсы_ОбученяDataSet.Курсы". При необходимости она может быть перемещена или удалена.
            //  this.курсыTableAdapter.Fill(this.курсы_ОбученяDataSet.Курсы);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            _menu.Show();
        }

        private void FormClosingEvent(object sender, FormClosingEventArgs e)
        {
            _menu.Show();
        }
    }
}
