using EmpMenegement.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace EmpMenegement
{
    public partial class Employee : Form
    {
        List<Worker> workers;
        public Employee()
        {
            InitializeComponent();
            workers = new List<Worker>();
            GetEmployees();
            populate();
         }

        SqlConnection conn=new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Danik\source\repos\EmpMenegement\myEmployeeDb.mdf;Integrated Security=True;Connect Timeout=30");
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
                if (Convert.ToString(ds.Tables[0].Rows[i]["EmpPos"]) == "Manager")
                {
                    //Manager manager;
                    Manager Lankin = new Manager(Convert.ToString(ds.Tables[0].Rows[i]["EmpPos"]));
                    Lankin.EmpName = Convert.ToString(ds.Tables[0].Rows[i]["EmpName"]);
                    Lankin.EmpSalary = Convert.ToInt16(ds.Tables[0].Rows[i]["EmpSalary"]);
                    Lankin.EmpPos = Convert.ToString(ds.Tables[0].Rows[i]["EmpPos"]);
                    workers.Add(Lankin);
                }
                if (Convert.ToString(ds.Tables[0].Rows[i]["EmpPos"]) == "DayCleaner")
                {
                    DayCleaner Lankin = new DayCleaner();
                    Lankin.EmpName = Convert.ToString(ds.Tables[0].Rows[i]["EmpName"]);
                    Lankin.EmpSalary = Convert.ToInt16(ds.Tables[0].Rows[i]["EmpSalary"]);
                    Lankin.EmpPos = Convert.ToString(ds.Tables[0].Rows[i]["EmpPos"]);
                    workers.Add(Lankin);
                }
                if (Convert.ToString(ds.Tables[0].Rows[i]["EmpPos"]) == "EveningCleaner")
                {
                    EveningCleaner Lankin = new EveningCleaner();
                    Lankin.EmpName = Convert.ToString(ds.Tables[0].Rows[i]["EmpName"]);
                    Lankin.EmpSalary = Convert.ToInt16(ds.Tables[0].Rows[i]["EmpSalary"]);
                    Lankin.EmpPos = Convert.ToString(ds.Tables[0].Rows[i]["EmpPos"]);
                    workers.Add(Lankin);
                }
            }
            //getDb almost finish, need sallary func derived from base clases
        }
        private void AddButton_Click(object sender, EventArgs e)
        {
            if(EmpNameTb.Text == "" || EmpAddTb.Text == "" ||  EmpPhoneTb.Text == "" || EmpSalaryTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }else
            {
                try
                {
                    conn.Open();
                    string query = "insert into EmployeeTbl values('" + EmpNameTb.Text + "','" + EmpAddTb.Text + "','" + EmpPosCb.SelectedItem.ToString() + "','" + EmpDOB.Value.Date.ToString() + "','" + EmpPhoneTb.Text + "','" + EmpGenCb.SelectedItem.ToString() + "','" + int.Parse(EmpSalaryTb.Text) + "')";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Employee Successfully Added");
                    conn.Close();
                    populate();
                }catch(Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }
        private void populate()
        {
            conn.Open();
            string query = "select * from EmployeeTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, conn);
            SqlCommandBuilder builder=new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            EmpDGV.DataSource = ds.Tables[0];
            conn.Close();
        }
        

        private void Employee_Load(object sender, EventArgs e)
        {
            InitListCollection();
        }

        private void InitListCollection()
        {
            
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (EmpNameTb.Text == "")
            {
                MessageBox.Show("Enter the employee Name");
            }
            else
            {
                try
                {
                    conn.Open();
                    string query = "delete from EmployeeTbl where Empname='"+EmpNameTb.Text+"';";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    int flag = cmd.ExecuteNonQuery();
                    if (flag==0)
                        MessageBox.Show("Employee Not Found");
                    else
                        MessageBox.Show("Employee Deleted Successfully");
                    conn.Close();
                    populate();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void EmpDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if(EmpDGV.CurrentRow != null)
            {
                EmpDGV.CurrentRow.Selected = true;
                EmpNameTb.Text = EmpDGV.SelectedRows[0].Cells[0].Value.ToString();
                EmpAddTb.Text = EmpDGV.SelectedRows[0].Cells[1].Value.ToString();
                EmpPosCb.Text = EmpDGV.SelectedRows[0].Cells[2].Value.ToString();
                EmpPhoneTb.Text = EmpDGV.SelectedRows[0].Cells[4].Value.ToString();
                EmpGenCb.Text = EmpDGV.SelectedRows[0].Cells[5].Value.ToString();
            } 
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (EmpNameTb.Text == "" || EmpAddTb.Text == "" || EmpPhoneTb.Text == "" || EmpSalaryTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    conn.Open();
                    string query = "update EmployeeTbl set Empname='" + EmpNameTb.Text + "',empaddres='" + EmpAddTb.Text + "',emppos='" + EmpPosCb.SelectedItem.ToString() + "',empdob='" + EmpDOB.Value.Date.ToString() + "',empphone='" + EmpPhoneTb.Text + "',empgen='" + EmpGenCb.SelectedItem.ToString() + "',empsalary='" + EmpSalaryTb.Text + "' where empname='" + EmpNameTb.Text +"';";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Employee Updated Successfully");
                    conn.Close();
                    populate();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
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
