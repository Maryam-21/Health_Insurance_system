using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace SWE_project_gui
{
    public partial class subscriber_form : Form
    {

        string ordb = "Data Source=orcl;User ID=hr;Password=hr;";
        OracleConnection conn;

        OracleDataAdapter data_adapter;
        OracleCommandBuilder cmd_builder;   
        DataSet Ds;




        public subscriber_form()
        {
            InitializeComponent();
        }

        private void subscriber_form_Load(object sender, EventArgs e)
        {
            display_all();

            conn = new OracleConnection(ordb);
            conn.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "getbundle";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("b",OracleDbType.RefCursor, ParameterDirection.Output);
            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                buncle_cbox.Items.Add(dr[0]);
            }
            dr.Close();
        }


        private void display_all()
        {
            string op = "select SP_NAME, ADDRESS, SERVICE_PROVIDED from service_provider";
            //string op = "select * from service_provider";

            data_adapter = new OracleDataAdapter(op, ordb);
            Ds = new DataSet();
            data_adapter.Fill(Ds);

            dataGridView1.DataSource = Ds.Tables[0];
        }



        private void buncle_cbox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select B_LIMIT from bundle where B_ID = :id";
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add("id", int.Parse(buncle_cbox.SelectedItem.ToString()));

            OracleDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                textBox2.Text = Convert.ToString(dr["B_LIMIT"]);

            }
            dr.Close();
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            if (textBox1.Text.ToString() == "")
            {
                display_all();
            }
            else
            {
                string op = "select SP_NAME, ADDRESS from service_provider where Service_provided= '"; op += (string)textBox1.Text.ToString() + "'";
                //string op = "select * from service_provider";

                data_adapter = new OracleDataAdapter(op, ordb);
                Ds = new DataSet();
                data_adapter.Fill(Ds);

                dataGridView1.DataSource = Ds.Tables[0];
            }
        }
    }
}
