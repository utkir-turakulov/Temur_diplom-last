using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Повышение_квалификации.Data;

namespace Повышение_квалификации
{
    public partial class МенюКадровика : Form
    {
        ВыборПользователя Выбор = null;
        private User _user = null;

        public МенюКадровика(ВыборПользователя выбор, User user)
        {
            _user = user;
            Выбор = выбор;
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ВыдачаНаправлений одобритьКурс = new ВыдачаНаправлений(this);
            одобритьКурс.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            СформироватьОтчет сформироватьОтчет = new СформироватьОтчет(this);
            сформироватьОтчет.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {            
            Выбор.Show();
            this.Hide();
        }

        private void FormClosingEvent(object sender, FormClosingEventArgs e)
        {
            Выбор.Show();
           // this.Hide();
        }
    }
}
