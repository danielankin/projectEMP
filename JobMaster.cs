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
    public partial class JobMaster : Form
    {
        List<Job> jobs;
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Danik\source\repos\EmpMenegement\myEmployeeDb.mdf;Integrated Security=True;Connect Timeout=30");
        public JobMaster()
        {
            InitializeComponent();
            jobs = new List<Job>();
        }
        
        private void AddButton_Click(object sender, EventArgs e)
        {
            if (NameTb.Text == "" || DescriptionTb.Text == "" || TimeTb.Text == "" || PlaceTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    conn.Open();
                    string query = "insert into Jobs values('" + NameTb.Text + "','" + DescriptionTb.Text + "','" + int.Parse(TimeTb.Text) + "','" + PlaceTb.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Employee Successfully Added");
                    conn.Close();
                    populate();
                    AddToList();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void populate()
        {
            conn.Open();
            string query = "select * from Jobs";
            SqlDataAdapter sda = new SqlDataAdapter(query, conn);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            JobsDGV.DataSource = ds.Tables[0];
            conn.Close();
            JobsDGV.DataSource = jobs;
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (NameTb.Text == "" || DescriptionTb.Text == "" || TimeTb.Text == "" || PlaceTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    conn.Open();
                    string query = "update Jobs set workerName='" + NameTb.Text + "',description='" + DescriptionTb.Text + "',time='" + TimeTb.Text + "',place='" + PlaceTb.Text + "' where workerName='" + NameTb.Text + "';";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Employee Updated Successfully");
                    conn.Close();
                    UpdateList();
                    populate();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void UpdateList()
        {
            for (int i = 0; i < jobs.Count; i++)
            {
                if (jobs[i].WorkerName==NameTb.Text)
                {
                    jobs.RemoveAt(i);
                    Job job = new Job(NameTb.Text, DescriptionTb.Text, int.Parse(TimeTb.Text), PlaceTb.Text);
                    jobs.Add(job);
                }
            }
        }

        private void AddToList()
        {
            Job job = new Job(NameTb.Text, DescriptionTb.Text, int.Parse(TimeTb.Text), PlaceTb.Text);
            jobs.Add(job);
        }

        private void JobMaster_Load(object sender, EventArgs e)
        {
            GetDbData();
            populate();
        }

        private void GetDbData()
        {
            conn.Open();
            string query = "select * from Jobs";
            SqlDataAdapter sda = new SqlDataAdapter(query, conn);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
          
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                Job job = new Job();
                job.WorkerName = Convert.ToString(ds.Tables[0].Rows[i]["workerName"]);
                job.Description = Convert.ToString(ds.Tables[0].Rows[i]["description"]);
                job.Time=Convert.ToInt32(ds.Tables[0].Rows[i]["time"]);
                job.Place = Convert.ToString(ds.Tables[0].Rows[i]["place"]);
                jobs.Add(job);
            }
            conn.Close();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (NameTb.Text == "")
            {
                MessageBox.Show("Missing Name");
            }
            else
            {
                try
                {
                    conn.Open();
                    string query = "delete from Jobs where workerName='" + NameTb.Text + "';";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    int flag = cmd.ExecuteNonQuery();
                    if (flag == 0)
                        MessageBox.Show("Employee Not Found");
                    else
                        MessageBox.Show("Employee Deleted Successfully");
                    conn.Close();
                    populate();
                    DeleteFromList();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void DeleteFromList()
        {
            for (int i = 0; i < jobs.Count; i++)
                if (jobs[i].WorkerName == NameTb.Text)
                    jobs.RemoveAt(i);
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void JobsDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (JobsDGV.CurrentRow != null)
            {
                JobsDGV.CurrentRow.Selected = true;
                NameTb.Text = JobsDGV.SelectedRows[0].Cells[0].Value.ToString();
                DescriptionTb.Text = JobsDGV.SelectedRows[0].Cells[1].Value.ToString();
                TimeTb.Text = JobsDGV.SelectedRows[0].Cells[2].Value.ToString();
                PlaceTb.Text = JobsDGV.SelectedRows[0].Cells[3].Value.ToString();
            }
        }
    }
}
