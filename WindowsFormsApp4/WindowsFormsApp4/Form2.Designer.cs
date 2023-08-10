namespace WindowsFormsApp4
{
    partial class Form2
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
            this.pecasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pecasBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pecasBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.pecasBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.pecas11DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.pecas11DataSet = new WindowsFormsApp4.pecas11DataSet();
            this.pecasBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.pecasTableAdapter = new WindowsFormsApp4.pecas11DataSetTableAdapters.PecasTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pecas11DataSet1 = new WindowsFormsApp4.pecas11DataSet1();
            this.pecas11DataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pecasBindingSource5 = new System.Windows.Forms.BindingSource(this.components);
            this.pecasTableAdapter1 = new WindowsFormsApp4.pecas11DataSet1TableAdapters.PecasTableAdapter();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pecasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pecasBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pecasBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pecasBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pecas11DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pecas11DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pecasBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pecas11DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pecas11DataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pecasBindingSource5)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(507, 408);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 30);
            this.button1.TabIndex = 1;
            this.button1.Text = "Sair";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pecas11DataSet
            // 
            this.pecas11DataSet.DataSetName = "pecas11DataSet";
            this.pecas11DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pecasBindingSource4
            // 
            this.pecasBindingSource4.DataMember = "Pecas";
            this.pecasBindingSource4.DataSource = this.pecas11DataSet;
            // 
            // pecasTableAdapter
            // 
            this.pecasTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.dataGridView1.DataSource = this.pecasBindingSource5;
            this.dataGridView1.Location = new System.Drawing.Point(12, 117);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(450, 321);
            this.dataGridView1.TabIndex = 2;
            // 
            // pecas11DataSet1
            // 
            this.pecas11DataSet1.DataSetName = "pecas11DataSet1";
            this.pecas11DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pecas11DataSet1BindingSource
            // 
            this.pecas11DataSet1BindingSource.DataSource = this.pecas11DataSet1;
            this.pecas11DataSet1BindingSource.Position = 0;
            // 
            // pecasBindingSource5
            // 
            this.pecasBindingSource5.DataMember = "Pecas";
            this.pecasBindingSource5.DataSource = this.pecas11DataSet1BindingSource;
            // 
            // pecasTableAdapter1
            // 
            this.pecasTableAdapter1.ClearBeforeFill = true;
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(172, 12);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(100, 20);
            this.txtFiltro.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Filtrar por:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(295, 10);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(140, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Filtrar por máquina";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Código";
            this.Column2.HeaderText = "Codigo";
            this.Column2.Name = "Column2";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Maquina";
            this.dataGridViewTextBoxColumn2.HeaderText = "Maquina";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "nome";
            this.dataGridViewTextBoxColumn3.HeaderText = "nome";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "codigo";
            this.dataGridViewTextBoxColumn4.HeaderText = "codigo";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "quantidade";
            this.dataGridViewTextBoxColumn5.HeaderText = "quantidade";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(295, 39);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(140, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "Filtrar por nome";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(639, 408);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(107, 30);
            this.button4.TabIndex = 7;
            this.button4.Text = "Voltar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFiltro);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pecasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pecasBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pecasBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pecasBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pecas11DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pecas11DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pecasBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pecas11DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pecas11DataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pecasBindingSource5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        
        private System.Windows.Forms.BindingSource pecasBindingSource;
       
        private System.Windows.Forms.BindingSource pecasBindingSource1;
        
        private System.Windows.Forms.BindingSource pecasBindingSource2;
        
        private System.Windows.Forms.BindingSource pecas11DataSetBindingSource;
       
        private System.Windows.Forms.BindingSource pecasBindingSource3;
       
        private System.Windows.Forms.DataGridViewTextBoxColumn códigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maquinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private pecas11DataSet pecas11DataSet;
        private System.Windows.Forms.BindingSource pecasBindingSource4;
        private pecas11DataSetTableAdapters.PecasTableAdapter pecasTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource pecas11DataSet1BindingSource;
        private pecas11DataSet1 pecas11DataSet1;
        private System.Windows.Forms.BindingSource pecasBindingSource5;
        private pecas11DataSet1TableAdapters.PecasTableAdapter pecasTableAdapter1;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}