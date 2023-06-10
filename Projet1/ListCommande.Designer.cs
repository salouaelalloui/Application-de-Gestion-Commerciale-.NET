namespace Projet1
{
    partial class ListCommande
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataSet2 = new Projet1.DataSet2();
            this.ligneCommandeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ligneCommandeTableAdapter = new Projet1.DataSet2TableAdapters.LigneCommandeTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmdIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.artIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ligneCommandeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Script MT Bold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(175, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mes commandes ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.cmdIdDataGridViewTextBoxColumn,
            this.artIdDataGridViewTextBoxColumn,
            this.qteDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.ligneCommandeBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(45, 127);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(441, 279);
            this.dataGridView1.TabIndex = 1;
            // 
            // dataSet2
            // 
            this.dataSet2.DataSetName = "DataSet2";
            this.dataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ligneCommandeBindingSource
            // 
            this.ligneCommandeBindingSource.DataMember = "LigneCommande";
            this.ligneCommandeBindingSource.DataSource = this.dataSet2;
            // 
            // ligneCommandeTableAdapter
            // 
            this.ligneCommandeTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cmdIdDataGridViewTextBoxColumn
            // 
            this.cmdIdDataGridViewTextBoxColumn.DataPropertyName = "CmdId";
            this.cmdIdDataGridViewTextBoxColumn.HeaderText = "CmdId";
            this.cmdIdDataGridViewTextBoxColumn.Name = "cmdIdDataGridViewTextBoxColumn";
            // 
            // artIdDataGridViewTextBoxColumn
            // 
            this.artIdDataGridViewTextBoxColumn.DataPropertyName = "ArtId";
            this.artIdDataGridViewTextBoxColumn.HeaderText = "ArtId";
            this.artIdDataGridViewTextBoxColumn.Name = "artIdDataGridViewTextBoxColumn";
            // 
            // qteDataGridViewTextBoxColumn
            // 
            this.qteDataGridViewTextBoxColumn.DataPropertyName = "Qte";
            this.qteDataGridViewTextBoxColumn.HeaderText = "Qte";
            this.qteDataGridViewTextBoxColumn.Name = "qteDataGridViewTextBoxColumn";
            // 
            // ListCommande
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "ListCommande";
            this.Text = "ListCommande";
            this.Load += new System.EventHandler(this.ListCommande_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ligneCommandeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSet2 dataSet2;
        private System.Windows.Forms.BindingSource ligneCommandeBindingSource;
        private DataSet2TableAdapters.LigneCommandeTableAdapter ligneCommandeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmdIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn artIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qteDataGridViewTextBoxColumn;
    }
}