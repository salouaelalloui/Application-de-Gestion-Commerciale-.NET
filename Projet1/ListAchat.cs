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
    public partial class ListAchat : Form
    {
        public ListAchat()
        {
            InitializeComponent();
        }

        private void ListAchat_Load(object sender, EventArgs e)
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
                // TODO: This line of code loads data into the 'dataSet2.Ligne_Achat' table. You can move, or remove it, as needed.
                this.ligne_AchatTableAdapter.Fill(this.dataSet2.Ligne_Achat);
                // TODO: This line of code loads data into the 'dataSet2.Achat' table. You can move, or remove it, as needed.
                this.achatTableAdapter.Fill(this.dataSet2.Achat);
            }
        }
    }
}
