using Projet1.DataSet1TableAdapters;
using Projet1.DataSet2TableAdapters;
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
using System.Xml.Linq;
using System.IO;
namespace Projet1
{
    public partial class Admin : Form
    {
        DataSet1 dataset;
        DataTable fournisseurTable;
        DataSet2TableAdapters.ArticleTableAdapter artadapter; 
        List<Fournisseur> myObjects = new List<Fournisseur>();
        public Admin()
        {
            InitializeComponent();
        }
        public Admin(DataSet1 d) {
            InitializeComponent();
            //this.artadapter = a;
            this.dataset = d;
        }
        DataSet2TableAdapters.AchatTableAdapter achatAdap;
        private void Admin_Load(object sender, EventArgs e)

        {
            string filePath = "dataset2.xml";

            // Check if the file exists
            if (File.Exists(filePath))
            {
                // File exists
                this.dataSet2.ReadXml("dataset2.xml");
            }
            else
            {
                // File does not exist

                // TODO: This line of code loads data into the 'dataSet2.Ligne_Achat' table. You can move, or remove it, as needed.
                this.ligne_AchatTableAdapter.Fill(this.dataSet2.Ligne_Achat);
                // TODO: This line of code loads data into the 'dataSet2.Achat' table. You can move, or remove it, as needed.
                this.achatTableAdapter.Fill(this.dataSet2.Achat);
                this.achatAdap = new DataSet2TableAdapters.AchatTableAdapter();
                // TODO: This line of code loads data into the 'dataSet2.Article' table. You can move, or remove it, as needed.
                this.articleTableAdapter1.Fill(this.dataSet2.Article);
                // TODO: This line of code loads data into the 'dataSet1.User' table. You can move, or remove it, as needed.
                this.userTableAdapter.Fill(this.dataSet1.User);

                //ArticleTableAdapter artadapter=new ArticleTableAdapter();
                //artadapter =  this.articleTableAdapter;
                // this.artadapter.Fill(this.dataset.Article);
                DataSet2TableAdapters.FournisseurTableAdapter adapter = new DataSet2TableAdapters.FournisseurTableAdapter();
                adapter.Fill(this.dataSet2.Fournisseur);
            }
            DataTable r = this.dataSet2.Tables["Article"];
            Console.WriteLine("Articles");
            Console.WriteLine("length :" + r.Rows.Count);
            fournisseurTable = this.dataSet2.Tables["Fournisseur"];
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                // Access the cell in the added column for each row
                DataGridViewCell cell = row.Cells["Quantite"]; // Replace "NewColumn" with the actual column name

                // Set the desired value for the cell
               cell.Value = 0;
            }
            /*foreach (DataTable table in dataset.Tables)
            {
                Console.WriteLine(table.TableName);
                
            }*/

//            Console.WriteLine("Length");
  //          Console.WriteLine(fournisseurTable.Rows.Count);
            foreach (DataRow row in fournisseurTable.Rows) { 
                Fournisseur a=new Fournisseur();
                //Console.WriteLine(row["Nom"].ToString());
                a.Id= Convert.ToInt32(row["Id"]);
                a.Name = row["Nom"].ToString();
                myObjects.Add(a);
            }
            comboBox1.DataSource = myObjects;
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "Id";
            // TODO: This line of code loads data into the 'dataSet11.Article' table. You can move, or remove it, as needed.
            //this.articleTableAdapter.Fill(this.dataSet11.Article);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Achat a = new Achat();
            Fournisseur f = (Fournisseur)comboBox1.SelectedItem;
            int fi = f.Id;
            a.Fourn_id = fi;
            this.achatTableAdapter.Fill(dataSet2.Achat);
            DateTime time= DateTime.Now;
            a.date = time.ToString();
            this.achatTableAdapter.Insert(a.date,a.Fourn_id);
            
            this.achatTableAdapter.Fill(dataSet2.Achat);
            this.achatTableAdapter.Update(dataSet2);




            DataTable achatTable = this.dataSet2.Tables["Achat"];
                
            Console.WriteLine("Length of Achat :"+achatTable.Rows.Count);
            foreach (DataRow row in achatTable.Rows)
            {
                // Access the values of each column in the row
                var columnValue = row["Date_achat"];

                // Perform any necessary operations with the column value
                Console.WriteLine(columnValue);
            }
            DataRow lastRow = dataSet2.Tables["Achat"].Rows[dataSet2.Tables["Achat"].Rows.Count - 1];
            for (int rowIndex = 0; rowIndex < dataGridView1.Rows.Count - 1; rowIndex++)
            {
                

                int qte = (int)dataGridView1.Rows[rowIndex].Cells[4].Value;
                Console.WriteLine("La quantite : " + qte);
                int neww= (int)dataGridView1.Rows[rowIndex].Cells[3].Value + qte;
                DataRow dataRow = this.dataSet2.Tables["Article"].Rows[rowIndex];
                dataRow["Stock"] = neww;
                LigneAchat la = new LigneAchat();
                la.ArtId = (int)dataRow["id"];
                la.AchId = (int)lastRow["id"];
                la.qte = qte;
                this.ligne_AchatTableAdapter.Fill(dataSet2.Ligne_Achat);
                this.ligne_AchatTableAdapter.Insert(la.AchId,la.ArtId,la.qte);
                
                this.ligne_AchatTableAdapter.Fill(dataSet2.Ligne_Achat);
                this.ligne_AchatTableAdapter.Update(dataSet2);

                dataRow.AcceptChanges();
            }
            dataGridView1.Refresh();
            dataGridView1.Update();
            this.dataSet2.WriteXml("dataset2.xml");
            MessageBox.Show("Achat bien fait", "Success !!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                // Access the cell in the added column for each row
                DataGridViewCell cell = row.Cells["Quantite"]; // Replace "NewColumn" with the actual column name

                // Set the desired value for the cell
                cell.Value = 0;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
    e.RowIndex >= 0 && dataGridView1.Columns[e.ColumnIndex].HeaderText.Equals("Ajouter")) {
    Console.WriteLine(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                dataGridView1.Rows[e.RowIndex].Cells[4].Value = (int)dataGridView1.Rows[e.RowIndex].Cells[4].Value + 1;


         }

            if (dataGridView1.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
    e.RowIndex >= 0 && dataGridView1.Columns[e.ColumnIndex].HeaderText.Equals("Supprimer"))
            {
                if ((int)dataGridView1.Rows[e.RowIndex].Cells[4].Value > 0)
                {
                    Console.WriteLine(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                    dataGridView1.Rows[e.RowIndex].Cells[4].Value = (int)dataGridView1.Rows[e.RowIndex].Cells[4].Value - 1;
                }
                else {
                    MessageBox.Show("Rien à supprimer", "X", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }


            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // this.Hide();
           // this.dataSet2.ReadXml("dataset2.xml");
            ListAchat l=new ListAchat();
            l.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataSet2.WriteXml("dataset2.xml");
            this.Close();
            Form1 f = new Form1();
            f.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            ListCommande listCommande = new ListCommande();
            listCommande.Show();

        }
    }
}
