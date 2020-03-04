using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oplata
{
    public partial class FormMeneger : Form
    {
        public FormMeneger()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form f1 = new FormExecutor();
            f1.Left = this.Left;
            f1.Top = this.Top;
            f1.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form f2 = new Formcoeficient();
            f2.Left = this.Left;
            f2.Top = this.Top;
            f2.Show();
            this.Hide();
        }
    }
}
