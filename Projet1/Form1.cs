using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet1
{
    public partial class Form1 : Form
    {
        DataTable userTable;

        DataSet1 dataset;
        public Form1()
        { 
            
            dataset = new DataSet1();
            
            
            
                InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.password.UseSystemPasswordChar = true;
            // TODO: This line of code loads data into the 'dataSet1.Article' table. You can move, or remove it, as needed.
            this.articleTableAdapter.Fill(this.dataSet1.Article);
            // TODO: This line of code loads data into the 'dataSet1.Article' table. You can move, or remove it, as needed.
            this.articleTableAdapter.Fill(this.dataSet1.Article);

            this.userTableAdapter.Fill(this.dataSet1.User);
            userTable = this.dataSet1.Tables["User"];
            DataTable artTable = this.dataSet1.Tables["Article"];
            //Console.WriteLine("length" + userTable.Rows.Count);
            foreach (DataRow row in artTable.Rows)
            {
            //    User a = new User();
              //  Console.WriteLine("A name");
                Console.WriteLine(row["Libelle"].ToString());
            }
            

            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Boolean deja = false;
            if (this.email.Text.Equals("") || this.password.Text.Equals("")) {
                deja = true;
                MessageBox.Show("S'il vous plait , insérez tout les champs", "Empty credentials", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            bool found=false;
           
            foreach (DataRow row in userTable.Rows)
            {
                //User a = new User();
                
                Console.WriteLine("A name");
                Console.WriteLine(row["Name"].ToString());
                if ((int)row["RoleId"] == 1 && this.email.Text.Equals(row["Email"]) && this.password.Text.Equals(row["Password"]))
                {
                    //Console.WriteLine("Im an admin");
                    this.Hide();
                    Admin admin = new Admin(this.dataSet1);
                    admin.Show();
                    found = true;
                }
                if ((int)row["RoleId"] == 2 && this.email.Text.Equals(row["Email"]) && this.password.Text.Equals(row["Password"]))
                {
                    //Console.WriteLine("Im an admin");
                    this.Hide();
                    Client client = new Client((int)row["Id"]);
                    client.Show();
                    found = true;
                }
            }

            if (!found && !deja) {
                MessageBox.Show("Informations incorrecte !!", "Wrong crediantials", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            deja = false;


            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void userBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
