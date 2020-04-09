using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Oplata
{
    public partial class FormAuto : Form

    {
        public FormAuto()
        {
            InitializeComponent();
        }
        int a = 0, b = 15, s = 0, d = 15;

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string loginUser = textBoxLogin.Text;
                string passUser = textBoxPass.Text;
                ClassIniDataBase db = new ClassIniDataBase();
                DataTable table = new DataTable();

                SqlDataAdapter adapter = new SqlDataAdapter();
                SqlCommand commandagent = new SqlCommand(@"SELECT * FROM [Users] WHERE Login = @uL AND Password = @uP AND Role= 'manager'", db.GetConnection());
                commandagent.Parameters.Add("@uL", SqlDbType.VarChar).Value = loginUser;
                commandagent.Parameters.Add("@uP", SqlDbType.VarChar).Value = passUser;
                adapter.SelectCommand = commandagent;
                adapter.Fill(table);
                DataTable table1 = new DataTable();
                SqlDataAdapter adapter1 = new SqlDataAdapter();
                SqlCommand commandclient = new SqlCommand(@"SELECT * FROM [Users] WHERE Login = @uL AND Password = @uP AND Role = 'executor'", db.GetConnection());
                commandclient.Parameters.Add("@uL", SqlDbType.VarChar).Value = loginUser;
                commandclient.Parameters.Add("@uP", SqlDbType.VarChar).Value = passUser;
                adapter1.SelectCommand = commandclient;
                adapter1.Fill(table1);
                if (table.Rows.Count > 0)
                {
                    Form ifrm = new FormMeneger();
                    ifrm.Left = this.Left;
                    ifrm.Top = this.Top;
                    ifrm.Show();
                    this.Hide();
                }
                else
                {
                    if (table1.Rows.Count > 0)
                    {
                        Form efrm = new FormExecutor();
                        efrm.Show();
                        efrm.Top = this.Top;
                        efrm.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Не верный логин или пароль");
                        textBoxLogin.Clear();
                        textBoxPass.Clear();
                        a++;
                        if (a==3)
                        {
                                    timer1.Enabled = true;
                                    buttonRun.Enabled = false;
                                    label5.Visible = true;
                                    buttonRegister.Enabled=false;
                                    textBoxLogin.Enabled = false;
                                    textBoxPass.Enabled = false;
                        }
                    }
                }
            }
            finally { }

        }

      

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (b > 0)
            {
                b--;
                label5.Text = ("Вы заблокированы. Пожалуйста подождите: " + b);
                if (b == 0)
                {
                    b = d;
                    d += 5;
                    timer1.Enabled = false;
                    buttonRun.Enabled = true;
                    label5.Visible = false;
                    buttonRegister.Enabled = true;
                    label5.Text = "";
                    textBoxLogin.Enabled = true;
                    textBoxPass.Enabled = true;
                }
            }
            s++;
        }
    }
    }



