using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using System.Windows.Forms;

namespace SWE_project_gui
{
    public partial class landingPage : Form
    {
        string ordb = "data source=orcl; user id=hr; password=hr;";
        OracleConnection conn;
        public landingPage()
        {
            InitializeComponent();
        }

        private void landingPage_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void subsc_rb_CheckedChanged(object sender, EventArgs e)
        {
            //name_label.Visible = true;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            if (name_txt.Text == "" || password_txt.Text == "")
            {
                MessageBox.Show("Please enter all fields!");
            }
            if (name_txt.Text == "admin" && password_txt.Text == "Admin")
            {
                this.Hide();
                Admin_Form AF = new Admin_Form();
                AF.ShowDialog();
                this.Dispose();
            }
            if (!sp_rb.Checked && !subsc_rb.Checked)
            {
                MessageBox.Show("Please select user type!");
            }

            //try
            //{             
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            if (sp_rb.Checked)
            {
                cmd.CommandText = "select sp_id from service_provider where sp_name=:n and pass=:p";
            }
            else if (subsc_rb.Checked)
            {
                cmd.CommandText = "select ssn from subscriber where s_name=:n and pass=:p";
            }

            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("n", name_txt.Text);
            cmd.Parameters.Add("p", password_txt.Text);

            OracleDataReader dr = cmd.ExecuteReader();
            int id = -1;
            if (dr.Read())
            {
                if (dr[0] != null)
                    id = int.Parse(dr[0].ToString());
            }
            dr.Close();
            if (id != -1)
            {
                if (sp_rb.Checked)
                {
                    this.Hide();
                    SP_form spf = new SP_form();
                    spf.setSpId(id);
                    spf.ShowDialog();
                    this.Dispose();
                }
                else if (subsc_rb.Checked)
                {
                    this.Hide();
                    subscriber_form sbf = new subscriber_form();
                    //sbf.setSpId(id);
                    sbf.ShowDialog();
                    this.Dispose();
                }
            }
            else
            {

                MessageBox.Show("Name or password is incorrect");
            }
            /*
            }
            catch(Exception E)
            {
                MessageBox.Show(E.Message);
            }
            */
        }

        private void landingPage_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

        private void landingPage_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
