namespace Projet1
{
    partial class Client
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.libelleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.puDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Commander = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Retirer = new System.Windows.Forms.DataGridViewButtonColumn();
            this.articleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet2 = new Projet1.DataSet2();
            this.articleTableAdapter = new Projet1.DataSet2TableAdapters.ArticleTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.commandeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.commandeTableAdapter = new Projet1.DataSet2TableAdapters.CommandeTableAdapter();
            this.ligneCommandeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ligneCommandeTableAdapter = new Projet1.DataSet2TableAdapters.LigneCommandeTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.articleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ligneCommandeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.DarkKhaki;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.libelleDataGridViewTextBoxColumn,
            this.puDataGridViewTextBoxColumn,
            this.stockDataGridViewTextBoxColumn,
            this.Quantite,
            this.Commander,
            this.Retirer});
            this.dataGridView1.DataSource = this.articleBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(23, 112);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(744, 239);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // libelleDataGridViewTextBoxColumn
            // 
            this.libelleDataGridViewTextBoxColumn.DataPropertyName = "Libelle";
            this.libelleDataGridViewTextBoxColumn.HeaderText = "Libelle";
            this.libelleDataGridViewTextBoxColumn.Name = "libelleDataGridViewTextBoxColumn";
            // 
            // puDataGridViewTextBoxColumn
            // 
            this.puDataGridViewTextBoxColumn.DataPropertyName = "Pu";
            this.puDataGridViewTextBoxColumn.HeaderText = "Pu";
            this.puDataGridViewTextBoxColumn.Name = "puDataGridViewTextBoxColumn";
            // 
            // stockDataGridViewTextBoxColumn
            // 
            this.stockDataGridViewTextBoxColumn.DataPropertyName = "Stock";
            this.stockDataGridViewTextBoxColumn.HeaderText = "Stock";
            this.stockDataGridViewTextBoxColumn.Name = "stockDataGridViewTextBoxColumn";
            // 
            // Quantite
            // 
            this.Quantite.HeaderText = "Quantite";
            this.Quantite.Name = "Quantite";
            this.Quantite.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Commander
            // 
            this.Commander.HeaderText = "Commander";
            this.Commander.Name = "Commander";
            this.Commander.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Commander.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Retirer
            // 
            this.Retirer.HeaderText = "Retirer";
            this.Retirer.Name = "Retirer";
            this.Retirer.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Retirer.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // articleBindingSource
            // 
            this.articleBindingSource.DataMember = "Article";
            this.articleBindingSource.DataSource = this.dataSet2;
            // 
            // dataSet2
            // 
            this.dataSet2.DataSetName = "DataSet2";
            this.dataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // articleTableAdapter
            // 
            this.articleTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Script MT Bold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label1.Location = new System.Drawing.Point(26, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bienvenu chez nous";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Olive;
            this.button2.Font = new System.Drawing.Font("Script MT Bold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Ivory;
            this.button2.Location = new System.Drawing.Point(601, 392);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(155, 32);
            this.button2.TabIndex = 3;
            this.button2.Text = "Commander";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // commandeBindingSource
            // 
            this.commandeBindingSource.DataMember = "Commande";
            this.commandeBindingSource.DataSource = this.dataSet2;
            // 
            // commandeTableAdapter
            // 
            this.commandeTableAdapter.ClearBeforeFill = true;
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
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Olive;
            this.button1.Font = new System.Drawing.Font("Script MT Bold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(692, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 33);
            this.button1.TabIndex = 4;
            this.button1.Text = "Logout";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Client";
            this.Text = "Client";
            this.Load += new System.EventHandler(this.Client_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.articleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ligneCommandeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSet2 dataSet2;
        private System.Windows.Forms.BindingSource articleBindingSource;
        private DataSet2TableAdapters.ArticleTableAdapter articleTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn libelleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn puDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantite;
        private System.Windows.Forms.DataGridViewButtonColumn Commander;
        private System.Windows.Forms.DataGridViewButtonColumn Retirer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.BindingSource commandeBindingSource;
        private DataSet2TableAdapters.CommandeTableAdapter commandeTableAdapter;
        private System.Windows.Forms.BindingSource ligneCommandeBindingSource;
        private DataSet2TableAdapters.LigneCommandeTableAdapter ligneCommandeTableAdapter;
        private System.Windows.Forms.Button button1;
    }
}