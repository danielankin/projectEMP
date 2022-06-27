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
   //test1
    public partial class Salary : Form
    {
        List<Job> jobs;
        List<Worker> workers;
        SqlConnection conn;
        public Salary()
        {
            InitializeComponent();
            jobs = new List<Job>(); 
            workers = new List<Worker>();
            conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Danik\source\repos\EmpMenegement\myEmployeeDb.mdf;Integrated Security=True;Connect Timeout=30");
        }

        private void Salary_Load(object sender, EventArgs e)
        {
            LoadDbData();
            UpdateScreen();
        }

        private void UpdateScreen()
        {
            JobsDGV.DataSource = workers;
            salaryTb.Text=workers.ToString();
        }

        private void LoadDbData()
        {
            GetJobs();
            GetEmployees();
        }
        
        private void GetEmployees()
        {
            conn.Open();
            string query = "select * from EmployeeTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, conn);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            conn.Close();
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {//workers
                
                if (Convert.ToString(ds.Tables[0].Rows[i]["EmpPos"])=="Manager")
                {
                    //Manager manager;
                    Manager Lankin = new Manager();
                    Lankin.EmpName = Convert.ToString(ds.Tables[0].Rows[i]["EmpName"]);
                    Lankin.EmpSalary = Convert.ToInt16(ds.Tables[0].Rows[i]["EmpSalary"]);
                    Lankin.EmpPos= Convert.ToString(ds.Tables[0].Rows[i]["EmpPos"]);
                    foreach (var job in jobs)
                    {
                        if (job.WorkerName == Lankin.EmpName)
                        {
                            Lankin.hours = job.Time;
                            break;
                        }
                    }
                    Lankin.EmpDOB = Lankin.salaryFunc().ToString()+" Per This Mounth";
                    workers.Add(Lankin);
                    
                }
                if (Convert.ToString(ds.Tables[0].Rows[i]["EmpPos"]) == "DayCleaner")
                {
                    DayCleaner Lankin = new DayCleaner();
                    Lankin.EmpName = Convert.ToString(ds.Tables[0].Rows[i]["EmpName"]);
                    Lankin.EmpSalary = Convert.ToInt16(ds.Tables[0].Rows[i]["EmpSalary"]);
                    Lankin.EmpPos = Convert.ToString(ds.Tables[0].Rows[i]["EmpPos"]);
                    foreach (var job in jobs)
                    {
                        if (job.WorkerName==Lankin.EmpName)
                        {
                            Lankin.hours = job.Time;
                            break;
                        }
                    }
                        // foreach job in jobs ->if(job.name==Lankin.EmpName)->lankin.H=job.H
                    workers.Add(Lankin);
                }
                if (Convert.ToString(ds.Tables[0].Rows[i]["EmpPos"]) == "EveningCleaner")
                {
                    EveningCleaner Lankin = new EveningCleaner();
                    Lankin.EmpName = Convert.ToString(ds.Tables[0].Rows[i]["EmpName"]);
                    Lankin.EmpSalary = Convert.ToInt16(ds.Tables[0].Rows[i]["EmpSalary"]);
                    Lankin.EmpPos = Convert.ToString(ds.Tables[0].Rows[i]["EmpPos"]);
                    foreach (var job in jobs)
                    {
                        if (job.WorkerName == Lankin.EmpName)
                        {
                            Lankin.hours = job.Time;
                            break;
                        }
                    }
                    workers.Add(Lankin);
                }
                
            }
            //getDb almost finish, need sallary func derived from base clases
        }

        private void GetJobs()
        {
            conn.Open();
            string query = "select * from Jobs";
            SqlDataAdapter sda = new SqlDataAdapter(query, conn);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            conn.Close();

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {//jobs
                Job job = new Job();
                job.WorkerName = Convert.ToString(ds.Tables[0].Rows[i]["workerName"]).Trim();
                job.Description = Convert.ToString(ds.Tables[0].Rows[i]["description"]).Trim();
                job.Time = Convert.ToInt32(ds.Tables[0].Rows[i]["time"]);
                job.Place = Convert.ToString(ds.Tables[0].Rows[i]["place"]).Trim();
                jobs.Add(job);
            }
        }

    }
}
