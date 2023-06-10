using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace Projet1
{
    public partial class ListCommande : Form
    {
        public ListCommande()
        {
            InitializeComponent();
        }

        private void ListCommande_Load(object sender, EventArgs e)
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
            }
        }
    }
}
