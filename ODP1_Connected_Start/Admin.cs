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
    public partial class Admin_Form : Form
    {
        string ordb = "data source=orcl; user id=hr; password=hr;";
        OracleConnection conn;
        public Admin_Form()
        {
            InitializeComponent();
        }

        private void Admin_Form_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
        }
        private void ServiceProvider_CheckedChanged(object sender, EventArgs e)
        {
            SerProGroup.Visible = true;
            SubGroup.Visible = false;
            DepCheck.Checked = false;
            Depandancies.Visible = false;
        }

        private void Sub_CheckedChanged(object sender, EventArgs e)
        {
            SerProGroup.Visible = false;
            SubGroup.Visible = true;
        }

        private void DepCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (DepCheck.Checked)
                Depandancies.Visible = true;

            else
            {
                Depandancies.Visible = false;
                Sub_Name.Text = " ";
                Sub_Address.Text = " ";
                Sub_Age.Text = " ";
                Sub_Job.Text = " ";
                Sub_SSN.Text = " ";
            }

            }
        private void AddDep_Click(object sender, EventArgs e)
        {
            if (Dep_Name.Text != "" && Sub_SSN.Text!="" && Dep_Age.Text!="")
            {
                try {
                    OracleCommand cmd = new OracleCommand();
                    cmd.Connection = conn;
                    //cmd.CommandType = CommandType.Text;

                    cmd.CommandText = "insert into dependent values(:Name,:DSSN,:Age)";
                    cmd.Parameters.Add("Name", Dep_Name.Text);
                    cmd.Parameters.Add("DSSN", Sub_SSN.Text);
                    cmd.Parameters.Add("Age", Dep_Age.Text);
                    int r = cmd.ExecuteNonQuery();
                    if (r != -1)
                    {
                        MessageBox.Show("New Dependent is Added");
                        Dep_Name.Text = " ";
                        Dep_Age.Text = " ";
                    }
                }
                catch
                {
                    MessageBox.Show("Please add the subscriber first, then add dependents!");
                }
                
            }
            else
            {
                MessageBox.Show("please fill missing sections");
            }

        }

        private void Add_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            OracleCommand c = new OracleCommand();
            c.Connection = conn;
            cmd.Connection = conn;
            int max_id;
            int next_id;
            if (Sub.Checked)
            {
                if(Sub_SSN.Text!="" && Sub_Name.Text!="" && Sub_Age.Text!="" && Sub_Job.Text!=""&& Sub_Address.Text != "")
                {
                    cmd.CommandText = "insert into subscriber values(:DSSN,:Name,:Age,:Job,:Address,:BundleID,:Pass)";
                    cmd.Parameters.Add("DSSN", Sub_SSN.Text);
                    cmd.Parameters.Add("Name", Sub_Name.Text);
                    cmd.Parameters.Add("Age", Sub_Age.Text);
                    cmd.Parameters.Add("Job", Sub_Job.Text);
                    cmd.Parameters.Add("Address", Sub_Address.Text);
                    cmd.Parameters.Add("BundleID", Convert.ToInt32(0));
                    cmd.Parameters.Add("Pass", "Default123");
                    int r = cmd.ExecuteNonQuery();
                    if (r != -1)
                    {
                        MessageBox.Show("New Subscriber is Added");
                        if (!DepCheck.Checked)
                        {
                            Sub_Name.Text = " ";
                            Sub_Address.Text = " ";
                            Sub_Age.Text = " ";
                            Sub_Job.Text = " ";
                            Sub_SSN.Text = " ";
                        }
                    }
                }
                else
                {
                    MessageBox.Show("please fill missing sections");
                }

            }
            else
            {
                if(SP__Name.Text!=""&& SP_ServiceProvided.Text!="" && SP_Address.Text != "")
                {
                    c.CommandText = "generat_id";
                    c.CommandType = CommandType.StoredProcedure;
                    c.Parameters.Add("max_id", OracleDbType.Int32, ParameterDirection.Output);
                    c.ExecuteNonQuery();
                    try
                    {
                        max_id = Convert.ToInt32(c.Parameters["max_id"].Value.ToString());
                        next_id = max_id + 1;
                    }
                    catch
                    {
                        next_id = 100;
                    }

                    cmd.CommandText = "insert into service_provider values(:ID,:Name,:rec,:SP,:Address,:recFlag,'Default123')";
                    cmd.Parameters.Add("ID", next_id);
                    cmd.Parameters.Add("Name", SP__Name.Text);
                    cmd.Parameters.Add("rec", Convert.ToInt32(0));
                    cmd.Parameters.Add("SP", SP_ServiceProvided.Text);
                    cmd.Parameters.Add("Address", SP_Address.Text);
                    cmd.Parameters.Add("recFlag", Convert.ToInt32(0));
                    int r = cmd.ExecuteNonQuery();
                    if (r != -1)
                    {
                        MessageBox.Show("New Service Provider is Added");
                        SP__Name.Text = " ";
                        SP_Address.Text = " ";
                        SP_ServiceProvided.Text = " ";

                    }
                }
                else
                {
                    MessageBox.Show("please fill missing sections");
                }


            }
        }

        private void Admin_Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            conn.Dispose();
        }
    }
}
