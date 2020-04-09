namespace Oplata
{
    partial class Formcoeficient1
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
            this.idcoefficientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.juniorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.middleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seniorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kapDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kuoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ktosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kvDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ksDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kpdeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coefficientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zarplataDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zarplataDataSet = new Oplata.ZarplataDataSet();
            this.coefficientTableAdapter = new Oplata.ZarplataDataSetTableAdapters.coefficientTableAdapter();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coefficientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zarplataDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zarplataDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idcoefficientDataGridViewTextBoxColumn,
            this.juniorDataGridViewTextBoxColumn,
            this.middleDataGridViewTextBoxColumn,
            this.seniorDataGridViewTextBoxColumn,
            this.kapDataGridViewTextBoxColumn,
            this.kuoDataGridViewTextBoxColumn,
            this.ktosDataGridViewTextBoxColumn,
            this.kvDataGridViewTextBoxColumn,
            this.ksDataGridViewTextBoxColumn,
            this.kpdeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.coefficientBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(55, 100);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(776, 315);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dataGridView1_UserDeletingRow);
            // 
            // idcoefficientDataGridViewTextBoxColumn
            // 
            this.idcoefficientDataGridViewTextBoxColumn.DataPropertyName = "id_coefficient";
            this.idcoefficientDataGridViewTextBoxColumn.HeaderText = "Коэффициент";
            this.idcoefficientDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idcoefficientDataGridViewTextBoxColumn.Name = "idcoefficientDataGridViewTextBoxColumn";
            // 
            // juniorDataGridViewTextBoxColumn
            // 
            this.juniorDataGridViewTextBoxColumn.DataPropertyName = "Junior";
            this.juniorDataGridViewTextBoxColumn.HeaderText = "Начальный уровень";
            this.juniorDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.juniorDataGridViewTextBoxColumn.Name = "juniorDataGridViewTextBoxColumn";
            // 
            // middleDataGridViewTextBoxColumn
            // 
            this.middleDataGridViewTextBoxColumn.DataPropertyName = "Middle";
            this.middleDataGridViewTextBoxColumn.HeaderText = "Средний уровень";
            this.middleDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.middleDataGridViewTextBoxColumn.Name = "middleDataGridViewTextBoxColumn";
            // 
            // seniorDataGridViewTextBoxColumn
            // 
            this.seniorDataGridViewTextBoxColumn.DataPropertyName = "Senior";
            this.seniorDataGridViewTextBoxColumn.HeaderText = "Высокий уровень";
            this.seniorDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.seniorDataGridViewTextBoxColumn.Name = "seniorDataGridViewTextBoxColumn";
            // 
            // kapDataGridViewTextBoxColumn
            // 
            this.kapDataGridViewTextBoxColumn.DataPropertyName = "kap";
            this.kapDataGridViewTextBoxColumn.HeaderText = "Коэффициент для Анализ и проектирование";
            this.kapDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kapDataGridViewTextBoxColumn.Name = "kapDataGridViewTextBoxColumn";
            // 
            // kuoDataGridViewTextBoxColumn
            // 
            this.kuoDataGridViewTextBoxColumn.DataPropertyName = "kuo";
            this.kuoDataGridViewTextBoxColumn.HeaderText = "Коэффициент для Установка оборудования";
            this.kuoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kuoDataGridViewTextBoxColumn.Name = "kuoDataGridViewTextBoxColumn";
            // 
            // ktosDataGridViewTextBoxColumn
            // 
            this.ktosDataGridViewTextBoxColumn.DataPropertyName = "ktos";
            this.ktosDataGridViewTextBoxColumn.HeaderText = "Коэффициент для Техническое обслуживание и сопровождение";
            this.ktosDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ktosDataGridViewTextBoxColumn.Name = "ktosDataGridViewTextBoxColumn";
            // 
            // kvDataGridViewTextBoxColumn
            // 
            this.kvDataGridViewTextBoxColumn.DataPropertyName = "kv";
            this.kvDataGridViewTextBoxColumn.HeaderText = "Коэффициент времени";
            this.kvDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kvDataGridViewTextBoxColumn.Name = "kvDataGridViewTextBoxColumn";
            // 
            // ksDataGridViewTextBoxColumn
            // 
            this.ksDataGridViewTextBoxColumn.DataPropertyName = "ks";
            this.ksDataGridViewTextBoxColumn.HeaderText = "Коэффициент сложности";
            this.ksDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ksDataGridViewTextBoxColumn.Name = "ksDataGridViewTextBoxColumn";
            // 
            // kpdeDataGridViewTextBoxColumn
            // 
            this.kpdeDataGridViewTextBoxColumn.DataPropertyName = "kpde";
            this.kpdeDataGridViewTextBoxColumn.HeaderText = "Коэффициент для перевода в денежный эквивалент";
            this.kpdeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kpdeDataGridViewTextBoxColumn.Name = "kpdeDataGridViewTextBoxColumn";
            // 
            // coefficientBindingSource
            // 
            this.coefficientBindingSource.DataMember = "coefficient";
            this.coefficientBindingSource.DataSource = this.zarplataDataSetBindingSource;
            // 
            // zarplataDataSetBindingSource
            // 
            this.zarplataDataSetBindingSource.DataSource = this.zarplataDataSet;
            this.zarplataDataSetBindingSource.Position = 0;
            // 
            // zarplataDataSet
            // 
            this.zarplataDataSet.DataSetName = "ZarplataDataSet";
            this.zarplataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // coefficientTableAdapter
            // 
            this.coefficientTableAdapter.ClearBeforeFill = true;
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(217)))), ((int)(((byte)(187)))));
            this.buttonSave.Location = new System.Drawing.Point(55, 430);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(152, 53);
            this.buttonSave.TabIndex = 1;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(217)))), ((int)(((byte)(187)))));
            this.buttonBack.Location = new System.Drawing.Point(660, 430);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(152, 53);
            this.buttonBack.TabIndex = 2;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::Oplata.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(916, 94);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(217)))), ((int)(((byte)(187)))));
            this.buttonDelete.Location = new System.Drawing.Point(263, 430);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(152, 53);
            this.buttonDelete.TabIndex = 4;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // Formcoeficient1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(916, 495);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Formcoeficient1";
            this.Text = "Formcoeficient1";
            this.Load += new System.EventHandler(this.Formcoeficient1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coefficientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zarplataDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zarplataDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource zarplataDataSetBindingSource;
        private ZarplataDataSet zarplataDataSet;
        private System.Windows.Forms.BindingSource coefficientBindingSource;
        private ZarplataDataSetTableAdapters.coefficientTableAdapter coefficientTableAdapter;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcoefficientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn juniorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn middleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn seniorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kapDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kuoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ktosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kvDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ksDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kpdeDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button buttonDelete;
    }
}