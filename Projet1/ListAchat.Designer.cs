namespace Projet1
{
    partial class ListAchat
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
            this.dataSet2 = new Projet1.DataSet2();
            this.achatBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.achatTableAdapter = new Projet1.DataSet2TableAdapters.AchatTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ligneAchatBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ligne_AchatTableAdapter = new Projet1.DataSet2TableAdapters.Ligne_AchatTableAdapter();
            this.achIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.artIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.achatBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ligneAchatBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(170, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mes achats";
            // 
            // dataSet2
            // 
            this.dataSet2.DataSetName = "DataSet2";
            this.dataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // achatBindingSource
            // 
            this.achatBindingSource.DataMember = "Achat";
            this.achatBindingSource.DataSource = this.dataSet2;
            // 
            // achatTableAdapter
            // 
            this.achatTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.achIdDataGridViewTextBoxColumn,
            this.artIdDataGridViewTextBoxColumn,
            this.qteDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.ligneAchatBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(84, 117);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(343, 295);
            this.dataGridView1.TabIndex = 1;
            // 
            // ligneAchatBindingSource
            // 
            this.ligneAchatBindingSource.DataMember = "Ligne_Achat";
            this.ligneAchatBindingSource.DataSource = this.dataSet2;
            // 
            // ligne_AchatTableAdapter
            // 
            this.ligne_AchatTableAdapter.ClearBeforeFill = true;
            // 
            // achIdDataGridViewTextBoxColumn
            // 
            this.achIdDataGridViewTextBoxColumn.DataPropertyName = "Ach_Id";
            this.achIdDataGridViewTextBoxColumn.HeaderText = "Ach_Id";
            this.achIdDataGridViewTextBoxColumn.Name = "achIdDataGridViewTextBoxColumn";
            // 
            // artIdDataGridViewTextBoxColumn
            // 
            this.artIdDataGridViewTextBoxColumn.DataPropertyName = "Art_Id";
            this.artIdDataGridViewTextBoxColumn.HeaderText = "Art_Id";
            this.artIdDataGridViewTextBoxColumn.Name = "artIdDataGridViewTextBoxColumn";
            // 
            // qteDataGridViewTextBoxColumn
            // 
            this.qteDataGridViewTextBoxColumn.DataPropertyName = "Qte";
            this.qteDataGridViewTextBoxColumn.HeaderText = "Qte";
            this.qteDataGridViewTextBoxColumn.Name = "qteDataGridViewTextBoxColumn";
            // 
            // ListAchat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "ListAchat";
            this.Text = "ListAchat";
            this.Load += new System.EventHandler(this.ListAchat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.achatBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ligneAchatBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private DataSet2 dataSet2;
        private System.Windows.Forms.BindingSource achatBindingSource;
        private DataSet2TableAdapters.AchatTableAdapter achatTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource ligneAchatBindingSource;
        private DataSet2TableAdapters.Ligne_AchatTableAdapter ligne_AchatTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn achIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn artIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qteDataGridViewTextBoxColumn;
    }
}