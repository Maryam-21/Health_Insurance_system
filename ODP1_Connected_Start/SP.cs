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

    public partial class SP_form : Form
    {
        string ordb = "data source=orcl; user id=hr; password=hr;";
        OracleConnection conn;
        private int sp_id;

        public void setSpId(int id)
        {
            this.sp_id = id;
        }
        public int getSpId()
        {
            return sp_id;
        }

        public SP_form()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }


        private void SP_form_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "Select RECIEVABLES from service_provider where SP_ID = :id";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("id", this.sp_id);
            OracleDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                textBox3.Text = dr[0].ToString();
            }
            dr.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (typesvs_txt.Text == "" || price_txt.Text == "" )
            {
                MessageBox.Show("Please enter all fields!");
            }
            else
            {
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = "Select  MAX(r_id) from report";
                cmd.CommandType = CommandType.Text;
                OracleDataReader dr = cmd.ExecuteReader();
                int max_report_id = -1;
                if (dr.Read())
                {
                    if (dr[0].ToString() != "")
                        max_report_id = int.Parse(dr[0].ToString());
                    else
                        max_report_id = 0;
                }
                dr.Close();
                cmd.CommandText = "insert into REPORT values (:max_report_id, :typeSvs, :price, :sp_id)";
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add("max_report_id", max_report_id + 1);
                cmd.Parameters.Add("typeSvs", typesvs_txt.Text);
                cmd.Parameters.Add("price", int.Parse(price_txt.Text));
                cmd.Parameters.Add("sp_id", this.sp_id);
                cmd.ExecuteNonQuery();

                OracleCommand c = new OracleCommand();
                c.Connection = conn;
                c.CommandText = "update service_provider set RECIEVABLES= :rec where SP_ID = :s_id";
                c.CommandType = CommandType.Text;
                int sum = int.Parse(price_txt.Text) + int.Parse(textBox3.Text);
                c.Parameters.Add("rec", sum);
                c.Parameters.Add("s_id", this.sp_id);
                c.ExecuteNonQuery();

                textBox3.Text = sum.ToString();

                typesvs_txt.Text = "";
                price_txt.Text = "";

                MessageBox.Show("Report added successfully!");
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
