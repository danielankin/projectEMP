using EmpMenegement.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmpMenegement
{
    public partial class temp : Form
    {
        List<Job> jobs;
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Danik\source\repos\EmpMenegement\myEmployeeDb.mdf;Integrated Security=True;Connect Timeout=30");
        public temp()
        {
            InitializeComponent();
            jobs = new List<Job>();
        }
        private void populateDb()
        {
            conn.Open();
            string query = "select * from JobTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, conn);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            EmpDGV.DataSource = ds.Tables[0];
            conn.Close();
        }
        private void populateList()
        {
            EmpDGV.DataSource = jobs;
            
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if(EmpNameTb.Text == "" || DescriptionTb.Text == "" || PlaceTb.Text == "")
                MessageBox.Show("Missing Information");
            else 
            {
                
                Job NewJob = new Job(0, DescriptionTb.Text, int.Parse(TimeTb.Text), PlaceTb.Text, EmpNameTb.Text);
                jobs.Add(NewJob);
                MessageBox.Show("Job added to list");
                populateList();

      
            }
            PlaceTb.Text = "c"; TimeTb.Text = "5"; DescriptionTb.Text = "b"; EmpNameTb.Text = "a";
        }

        private void EditButton_Click(object sender, EventArgs e)
        {

            if (EmpNameTb.Text == "" || DescriptionTb.Text == "" || PlaceTb.Text == "")
                MessageBox.Show("Missing Information");
            else
            {

                for (int i = 0; i < jobs.Count; i++)
                {
                    if (jobs[i].WorkerName == EmpNameTb.Text)
                    {
                        jobs[i].Description = DescriptionTb.Text;
                        jobs[i].Time = int.Parse(TimeTb.Text);
                        jobs[i].Place = PlaceTb.Text;
                        break;
                    }
                }
                MessageBox.Show("Job Updated");
                populateList();
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (EmpNameTb.Text == "")
                MessageBox.Show("Missing Id");
            else
            {

                for (int i = 0; i < jobs.Count; i++)
                {
                    if (jobs[i].WorkerName == EmpNameTb.Text)
                    {
                        jobs.Remove(jobs[i]);
                        break;
                    }
                }
                MessageBox.Show("Job Deleted");
                populateList();
            }
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }
    }
}
