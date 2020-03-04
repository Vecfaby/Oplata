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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormExecutor));
            System.Windows.Forms.Label id_executerLabel;
            System.Windows.Forms.Label id_userLabel;
            System.Windows.Forms.Label gradeLabel;
            System.Windows.Forms.Label id_menegerLabel;
            this.zarplataDataSet = new Oplata.ZarplataDataSet();
            this.executorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.executorTableAdapter = new Oplata.ZarplataDataSetTableAdapters.ExecutorTableAdapter();
            this.tableAdapterManager = new Oplata.ZarplataDataSetTableAdapters.TableAdapterManager();
            this.executorBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.executorBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.id_executerTextBox = new System.Windows.Forms.TextBox();
            this.id_userTextBox = new System.Windows.Forms.TextBox();
            this.gradeTextBox = new System.Windows.Forms.TextBox();
            this.id_menegerTextBox = new System.Windows.Forms.TextBox();
            id_executerLabel = new System.Windows.Forms.Label();
            id_userLabel = new System.Windows.Forms.Label();
            gradeLabel = new System.Windows.Forms.Label();
            id_menegerLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.zarplataDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.executorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.executorBindingNavigator)).BeginInit();
            this.executorBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // zarplataDataSet
            // 
            this.zarplataDataSet.DataSetName = "ZarplataDataSet";
            this.zarplataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // executorBindingSource
            // 
            this.executorBindingSource.DataMember = "Executor";
            this.executorBindingSource.DataSource = this.zarplataDataSet;
            // 
            // executorTableAdapter
            // 
            this.executorTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.coefficientTableAdapter = null;
            this.tableAdapterManager.ExecutorTableAdapter = this.executorTableAdapter;
            this.tableAdapterManager.MenegerTableAdapter = null;
            this.tableAdapterManager.Task1TableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Oplata.ZarplataDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = null;
            // 
            // executorBindingNavigator
            // 
            this.executorBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.executorBindingNavigator.BindingSource = this.executorBindingSource;
            this.executorBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.executorBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.executorBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.executorBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.executorBindingNavigatorSaveItem});
            this.executorBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.executorBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.executorBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.executorBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.executorBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.executorBindingNavigator.Name = "executorBindingNavigator";
            this.executorBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.executorBindingNavigator.Size = new System.Drawing.Size(800, 27);
            this.executorBindingNavigator.TabIndex = 0;
            this.executorBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(55, 24);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // executorBindingNavigatorSaveItem
            // 
            this.executorBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.executorBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("executorBindingNavigatorSaveItem.Image")));
            this.executorBindingNavigatorSaveItem.Name = "executorBindingNavigatorSaveItem";
            this.executorBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.executorBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.executorBindingNavigatorSaveItem.Click += new System.EventHandler(this.executorBindingNavigatorSaveItem_Click);
            // 
            // id_executerLabel
            // 
            id_executerLabel.AutoSize = true;
            id_executerLabel.Location = new System.Drawing.Point(225, 102);
            id_executerLabel.Name = "id_executerLabel";
            id_executerLabel.Size = new System.Drawing.Size(81, 17);
            id_executerLabel.TabIndex = 1;
            id_executerLabel.Text = "id executer:";
            // 
            // id_executerTextBox
            // 
            this.id_executerTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.executorBindingSource, "id_executer", true));
            this.id_executerTextBox.Location = new System.Drawing.Point(314, 99);
            this.id_executerTextBox.Name = "id_executerTextBox";
            this.id_executerTextBox.Size = new System.Drawing.Size(100, 22);
            this.id_executerTextBox.TabIndex = 2;
            // 
            // id_userLabel
            // 
            id_userLabel.AutoSize = true;
            id_userLabel.Location = new System.Drawing.Point(225, 130);
            id_userLabel.Name = "id_userLabel";
            id_userLabel.Size = new System.Drawing.Size(55, 17);
            id_userLabel.TabIndex = 3;
            id_userLabel.Text = "id user:";
            // 
            // id_userTextBox
            // 
            this.id_userTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.executorBindingSource, "id_user", true));
            this.id_userTextBox.Location = new System.Drawing.Point(314, 127);
            this.id_userTextBox.Name = "id_userTextBox";
            this.id_userTextBox.Size = new System.Drawing.Size(100, 22);
            this.id_userTextBox.TabIndex = 4;
            // 
            // gradeLabel
            // 
            gradeLabel.AutoSize = true;
            gradeLabel.Location = new System.Drawing.Point(225, 158);
            gradeLabel.Name = "gradeLabel";
            gradeLabel.Size = new System.Drawing.Size(49, 17);
            gradeLabel.TabIndex = 5;
            gradeLabel.Text = "grade:";
            // 
            // gradeTextBox
            // 
            this.gradeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.executorBindingSource, "grade", true));
            this.gradeTextBox.Location = new System.Drawing.Point(314, 155);
            this.gradeTextBox.Name = "gradeTextBox";
            this.gradeTextBox.Size = new System.Drawing.Size(100, 22);
            this.gradeTextBox.TabIndex = 6;
            // 
            // id_menegerLabel
            // 
            id_menegerLabel.AutoSize = true;
            id_menegerLabel.Location = new System.Drawing.Point(225, 186);
            id_menegerLabel.Name = "id_menegerLabel";
            id_menegerLabel.Size = new System.Drawing.Size(83, 17);
            id_menegerLabel.TabIndex = 7;
            id_menegerLabel.Text = "id meneger:";
            // 
            // id_menegerTextBox
            // 
            this.id_menegerTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.executorBindingSource, "id_meneger", true));
            this.id_menegerTextBox.Location = new System.Drawing.Point(314, 183);
            this.id_menegerTextBox.Name = "id_menegerTextBox";
            this.id_menegerTextBox.Size = new System.Drawing.Size(100, 22);
            this.id_menegerTextBox.TabIndex = 8;
            // 
            // FormExecutor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(id_executerLabel);
            this.Controls.Add(this.id_executerTextBox);
            this.Controls.Add(id_userLabel);
            this.Controls.Add(this.id_userTextBox);
            this.Controls.Add(gradeLabel);
            this.Controls.Add(this.gradeTextBox);
            this.Controls.Add(id_menegerLabel);
            this.Controls.Add(this.id_menegerTextBox);
            this.Controls.Add(this.executorBindingNavigator);
            this.Name = "FormExecutor";
            this.Text = "FormExecutor";
            this.Load += new System.EventHandler(this.FormExecutor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.zarplataDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.executorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.executorBindingNavigator)).EndInit();
            this.executorBindingNavigator.ResumeLayout(false);
            this.executorBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ZarplataDataSet zarplataDataSet;
        private System.Windows.Forms.BindingSource executorBindingSource;
        private ZarplataDataSetTableAdapters.ExecutorTableAdapter executorTableAdapter;
        private ZarplataDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator executorBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton executorBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox id_executerTextBox;
        private System.Windows.Forms.TextBox id_userTextBox;
        private System.Windows.Forms.TextBox gradeTextBox;
        private System.Windows.Forms.TextBox id_menegerTextBox;
    }
}