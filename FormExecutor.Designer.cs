namespace Oplata
{
    partial class FormExecutor
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
            this.menegerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zarplataDataSet1 = new Oplata.ZarplataDataSet1();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.fKExecutorMeneger1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.executorTableAdapter1 = new Oplata.ZarplataDataSetTableAdapters.ExecutorTableAdapter();
            this.menegerTableAdapter1 = new Oplata.ZarplataDataSetTableAdapters.MenegerTableAdapter();
            this.zarplataDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menegerTableAdapter = new Oplata.ZarplataDataSet1TableAdapters.MenegerTableAdapter();
            this.executorTableAdapter = new Oplata.ZarplataDataSet1TableAdapters.ExecutorTableAdapter();
            this.fullnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullnameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gradeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menegerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zarplataDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKExecutorMeneger1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zarplataDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fullnameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.menegerBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(25, 142);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(424, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // menegerBindingSource
            // 
            this.menegerBindingSource.DataMember = "Meneger";
            this.menegerBindingSource.DataSource = this.zarplataDataSet1;
            // 
            // zarplataDataSet1
            // 
            this.zarplataDataSet1.DataSetName = "ZarplataDataSet1";
            this.zarplataDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fullnameDataGridViewTextBoxColumn1,
            this.gradeDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.fKExecutorMeneger1BindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(25, 335);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(424, 150);
            this.dataGridView2.TabIndex = 1;
            // 
            // fKExecutorMeneger1BindingSource
            // 
            this.fKExecutorMeneger1BindingSource.DataMember = "FK_Executor_Meneger1";
            this.fKExecutorMeneger1BindingSource.DataSource = this.menegerBindingSource;
            // 
            // executorTableAdapter1
            // 
            this.executorTableAdapter1.ClearBeforeFill = true;
            // 
            // menegerTableAdapter1
            // 
            this.menegerTableAdapter1.ClearBeforeFill = true;
            // 
            // zarplataDataSet1BindingSource
            // 
            this.zarplataDataSet1BindingSource.DataSource = this.zarplataDataSet1;
            this.zarplataDataSet1BindingSource.Position = 0;
            // 
            // menegerTableAdapter
            // 
            this.menegerTableAdapter.ClearBeforeFill = true;
            // 
            // executorTableAdapter
            // 
            this.executorTableAdapter.ClearBeforeFill = true;
            // 
            // fullnameDataGridViewTextBoxColumn
            // 
            this.fullnameDataGridViewTextBoxColumn.DataPropertyName = "full_name";
            this.fullnameDataGridViewTextBoxColumn.HeaderText = "Полное имя";
            this.fullnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fullnameDataGridViewTextBoxColumn.Name = "fullnameDataGridViewTextBoxColumn";
            // 
            // fullnameDataGridViewTextBoxColumn1
            // 
            this.fullnameDataGridViewTextBoxColumn1.DataPropertyName = "full_name";
            this.fullnameDataGridViewTextBoxColumn1.HeaderText = "Полное имя";
            this.fullnameDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.fullnameDataGridViewTextBoxColumn1.Name = "fullnameDataGridViewTextBoxColumn1";
            // 
            // gradeDataGridViewTextBoxColumn
            // 
            this.gradeDataGridViewTextBoxColumn.DataPropertyName = "grade";
            this.gradeDataGridViewTextBoxColumn.HeaderText = "Грейд";
            this.gradeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.gradeDataGridViewTextBoxColumn.Name = "gradeDataGridViewTextBoxColumn";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::Oplata.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 113);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(217)))), ((int)(((byte)(187)))));
            this.button1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.button1.Location = new System.Drawing.Point(531, 405);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(189, 70);
            this.button1.TabIndex = 5;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(34, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 21);
            this.label1.TabIndex = 6;
            this.label1.Text = "Менеджер";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(34, 306);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 21);
            this.label2.TabIndex = 7;
            this.label2.Text = "Исполнитель";
            // 
            // FormExecutor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 519);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormExecutor";
            this.Text = "FormExecutor";
            this.Load += new System.EventHandler(this.FormExecutor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menegerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zarplataDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKExecutorMeneger1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zarplataDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource zarplataDataSet1BindingSource;
        private ZarplataDataSet1 zarplataDataSet1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private ZarplataDataSetTableAdapters.ExecutorTableAdapter executorTableAdapter1;
        private ZarplataDataSetTableAdapters.MenegerTableAdapter menegerTableAdapter1;
        private System.Windows.Forms.BindingSource menegerBindingSource;
        private ZarplataDataSet1TableAdapters.MenegerTableAdapter menegerTableAdapter;
        private System.Windows.Forms.BindingSource fKExecutorMeneger1BindingSource;
        private ZarplataDataSet1TableAdapters.ExecutorTableAdapter executorTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullnameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn gradeDataGridViewTextBoxColumn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}