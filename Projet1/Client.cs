using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.IO;
namespace Projet1
{
    public partial class Client : Form
    {
        int id;
        public Client(int id)
        {

            InitializeComponent();
            this.id = id;
        }

        private void Client_Load(object sender, EventArgs e)
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

                // TODO: This line of code loads data into the 'dataSet2.LigneCommande' table. You can move, or remove it, as needed.
                this.ligneCommandeTableAdapter.Fill(this.dataSet2.LigneCommande);
                // TODO: This line of code loads data into the 'dataSet2.Commande' table. You can move, or remove it, as needed.
                this.commandeTableAdapter.Fill(this.dataSet2.Commande);
                // TODO: This line of code loads data into the 'dataSet2.Article' table. You can move, or remove it, as needed.
                this.articleTableAdapter.Fill(this.dataSet2.Article);
            }

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
    e.RowIndex >= 0 && dataGridView1.Columns[e.ColumnIndex].HeaderText.Equals("Commander"))
            {
                Console.WriteLine(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                dataGridView1.Rows[e.RowIndex].Cells[4].Value = (int)dataGridView1.Rows[e.RowIndex].Cells[4].Value + 1;


            }

            if (dataGridView1.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
    e.RowIndex >= 0 && dataGridView1.Columns[e.ColumnIndex].HeaderText.Equals("Retirer"))
            {
                Console.WriteLine(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                if ((int)dataGridView1.Rows[e.RowIndex].Cells[4].Value > 0)
                {
                    dataGridView1.Rows[e.RowIndex].Cells[4].Value = (int)dataGridView1.Rows[e.RowIndex].Cells[4].Value - 1;
                }
                else {
                    MessageBox.Show("Rien à supprimer", "X", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Commande a = new Commande();
           
            int ci = this.id;
            a.ClientId = ci;
            
            this.commandeTableAdapter.Fill(dataSet2.Commande);
            DateTime time = DateTime.Now;
            a.date = time.ToString();
            this.commandeTableAdapter.Insert(a.date, a.ClientId);
            
            this.commandeTableAdapter.Fill(dataSet2.Commande);
            this.commandeTableAdapter.Update(dataSet2);
            


            DataTable commandeTable = this.dataSet2.Tables["Commande"];

            Console.WriteLine("Length of Achat :" + commandeTable.Rows.Count);
            foreach (DataRow row in commandeTable.Rows)
            {
                // Access the values of each column in the row
                var columnValue = row["Data_cmd"];

                // Perform any necessary operations with the column value
                Console.WriteLine(columnValue);
            }
            DataRow lastRow = dataSet2.Tables["Commande"].Rows[dataSet2.Tables["Commande"].Rows.Count - 1];
            for (int rowIndex = 0; rowIndex < dataGridView1.Rows.Count - 1; rowIndex++)
            {


                int qte = (int)dataGridView1.Rows[rowIndex].Cells[4].Value;
                Console.WriteLine("La quantite : " + qte);
                if ((int)dataGridView1.Rows[rowIndex].Cells[3].Value < qte)
                {
                    MessageBox.Show("Vous ne pouvez pas commander l'article" + dataGridView1.Rows[rowIndex].Cells[1].Value + " pour des raisons de stock", "Out of stock !!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    int neww = (int)dataGridView1.Rows[rowIndex].Cells[3].Value - qte;

                    DataRow dataRow = this.dataSet2.Tables["Article"].Rows[rowIndex];
                    dataRow["Stock"] = neww;

                    LigneCommande la = new LigneCommande();
                    la.ArtId = (int)dataRow["id"];
                    la.AchId = (int)lastRow["id"];
                    la.qte = qte;
                    this.ligneCommandeTableAdapter.Fill(dataSet2.LigneCommande);
                    this.ligneCommandeTableAdapter.Insert(la.AchId, la.ArtId, la.qte);
                    
                    this.ligneCommandeTableAdapter.Fill(dataSet2.LigneCommande);
                    this.ligneCommandeTableAdapter.Update(dataSet2);

                    dataRow.AcceptChanges();
                }
            }
            dataGridView1.Refresh();
            dataGridView1.Update();
            dataSet2.WriteXml("dataset2.xml");
            
            MessageBox.Show("Commande bien faite", "Success !!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                // Access the cell in the added column for each row
                DataGridViewCell cell = row.Cells["Quantite"]; // Replace "NewColumn" with the actual column name

                // Set the desired value for the cell
                cell.Value = 0;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.dataSet2.WriteXml("dataset2.xml");
            this.Hide();
            Form1 f = new Form1();
            f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ListCommande lc = new ListCommande();
            lc.Show();
        }
    }
}
