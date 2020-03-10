namespace Oplata
{
    partial class Formcoeficient
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
            System.Windows.Forms.Label id_coefficientLabel;
            System.Windows.Forms.Label juniorLabel;
            System.Windows.Forms.Label middleLabel;
            System.Windows.Forms.Label seniorLabel;
            System.Windows.Forms.Label kapLabel;
            System.Windows.Forms.Label kuoLabel;
            System.Windows.Forms.Label ktosLabel;
            System.Windows.Forms.Label kvLabel;
            System.Windows.Forms.Label ksLabel;
            System.Windows.Forms.Label kpdeLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Formcoeficient));
            this.zarplataDataSet = new Oplata.ZarplataDataSet();
            this.coefficientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.coefficientTableAdapter = new Oplata.ZarplataDataSetTableAdapters.coefficientTableAdapter();
            this.tableAdapterManager = new Oplata.ZarplataDataSetTableAdapters.TableAdapterManager();
            this.coefficientBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.coefficientBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.id_coefficientTextBox = new System.Windows.Forms.TextBox();
            this.juniorTextBox = new System.Windows.Forms.TextBox();
            this.middleTextBox = new System.Windows.Forms.TextBox();
            this.seniorTextBox = new System.Windows.Forms.TextBox();
            this.kapTextBox = new System.Windows.Forms.TextBox();
            this.kuoTextBox = new System.Windows.Forms.TextBox();
            this.ktosTextBox = new System.Windows.Forms.TextBox();
            this.kvTextBox = new System.Windows.Forms.TextBox();
            this.ksTextBox = new System.Windows.Forms.TextBox();
            this.kpdeTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            id_coefficientLabel = new System.Windows.Forms.Label();
            juniorLabel = new System.Windows.Forms.Label();
            middleLabel = new System.Windows.Forms.Label();
            seniorLabel = new System.Windows.Forms.Label();
            kapLabel = new System.Windows.Forms.Label();
            kuoLabel = new System.Windows.Forms.Label();
            ktosLabel = new System.Windows.Forms.Label();
            kvLabel = new System.Windows.Forms.Label();
            ksLabel = new System.Windows.Forms.Label();
            kpdeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.zarplataDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coefficientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coefficientBindingNavigator)).BeginInit();
            this.coefficientBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // id_coefficientLabel
            // 
            id_coefficientLabel.AutoSize = true;
            id_coefficientLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            id_coefficientLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            id_coefficientLabel.Location = new System.Drawing.Point(190, 166);
            id_coefficientLabel.Name = "id_coefficientLabel";
            id_coefficientLabel.Size = new System.Drawing.Size(132, 24);
            id_coefficientLabel.TabIndex = 1;
            id_coefficientLabel.Text = "Коэффициент:";
            // 
            // juniorLabel
            // 
            juniorLabel.AutoSize = true;
            juniorLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            juniorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            juniorLabel.Location = new System.Drawing.Point(190, 218);
            juniorLabel.Name = "juniorLabel";
            juniorLabel.Size = new System.Drawing.Size(186, 24);
            juniorLabel.TabIndex = 3;
            juniorLabel.Text = "Начальный уровень:";
            // 
            // middleLabel
            // 
            middleLabel.AutoSize = true;
            middleLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            middleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            middleLabel.Location = new System.Drawing.Point(190, 267);
            middleLabel.Name = "middleLabel";
            middleLabel.Size = new System.Drawing.Size(167, 24);
            middleLabel.TabIndex = 5;
            middleLabel.Text = "Средний уровень:";
            // 
            // seniorLabel
            // 
            seniorLabel.AutoSize = true;
            seniorLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            seniorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            seniorLabel.Location = new System.Drawing.Point(190, 311);
            seniorLabel.Name = "seniorLabel";
            seniorLabel.Size = new System.Drawing.Size(165, 24);
            seniorLabel.TabIndex = 7;
            seniorLabel.Text = "Высокий уровень:";
            // 
            // kapLabel
            // 
            kapLabel.AutoSize = true;
            kapLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            kapLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            kapLabel.Location = new System.Drawing.Point(190, 361);
            kapLabel.Name = "kapLabel";
            kapLabel.Size = new System.Drawing.Size(397, 24);
            kapLabel.TabIndex = 9;
            kapLabel.Text = "Коэффициент для анализ и проектирование:";
            // 
            // kuoLabel
            // 
            kuoLabel.AutoSize = true;
            kuoLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            kuoLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            kuoLabel.Location = new System.Drawing.Point(190, 411);
            kuoLabel.Name = "kuoLabel";
            kuoLabel.Size = new System.Drawing.Size(388, 24);
            kuoLabel.TabIndex = 11;
            kuoLabel.Text = "Коэффициент для установка оборудования:";
            // 
            // ktosLabel
            // 
            ktosLabel.AutoSize = true;
            ktosLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            ktosLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            ktosLabel.Location = new System.Drawing.Point(190, 459);
            ktosLabel.Name = "ktosLabel";
            ktosLabel.Size = new System.Drawing.Size(569, 24);
            ktosLabel.TabIndex = 13;
            ktosLabel.Text = "Коэффициент для техническое обслуживание и сопровождение:";
            // 
            // kvLabel
            // 
            kvLabel.AutoSize = true;
            kvLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            kvLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            kvLabel.Location = new System.Drawing.Point(190, 507);
            kvLabel.Name = "kvLabel";
            kvLabel.Size = new System.Drawing.Size(214, 24);
            kvLabel.TabIndex = 15;
            kvLabel.Text = "Коэффициент времени:";
            // 
            // ksLabel
            // 
            ksLabel.AutoSize = true;
            ksLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            ksLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            ksLabel.Location = new System.Drawing.Point(190, 557);
            ksLabel.Name = "ksLabel";
            ksLabel.Size = new System.Drawing.Size(229, 24);
            ksLabel.TabIndex = 17;
            ksLabel.Text = "Коэффициент сложности:";
            // 
            // kpdeLabel
            // 
            kpdeLabel.AutoSize = true;
            kpdeLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            kpdeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            kpdeLabel.Location = new System.Drawing.Point(190, 605);
            kpdeLabel.Name = "kpdeLabel";
            kpdeLabel.Size = new System.Drawing.Size(463, 24);
            kpdeLabel.TabIndex = 19;
            kpdeLabel.Text = "Коэффициент для перевода в денежный эквивалент\r\n";
            // 
            // zarplataDataSet
            // 
            this.zarplataDataSet.DataSetName = "ZarplataDataSet";
            this.zarplataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // coefficientBindingSource
            // 
            this.coefficientBindingSource.DataMember = "coefficient";
            this.coefficientBindingSource.DataSource = this.zarplataDataSet;
            // 
            // coefficientTableAdapter
            // 
            this.coefficientTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.coefficientTableAdapter = this.coefficientTableAdapter;
            this.tableAdapterManager.ExecutorTableAdapter = null;
            this.tableAdapterManager.MenegerTableAdapter = null;
            this.tableAdapterManager.Task1TableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Oplata.ZarplataDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = null;
            // 
            // coefficientBindingNavigator
            // 
            this.coefficientBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.coefficientBindingNavigator.BindingSource = this.coefficientBindingSource;
            this.coefficientBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.coefficientBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.coefficientBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.coefficientBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.coefficientBindingNavigatorSaveItem});
            this.coefficientBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.coefficientBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.coefficientBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.coefficientBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.coefficientBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.coefficientBindingNavigator.Name = "coefficientBindingNavigator";
            this.coefficientBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.coefficientBindingNavigator.Size = new System.Drawing.Size(1241, 31);
            this.coefficientBindingNavigator.TabIndex = 0;
            this.coefficientBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(55, 24);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
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
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
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
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // coefficientBindingNavigatorSaveItem
            // 
            this.coefficientBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.coefficientBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("coefficientBindingNavigatorSaveItem.Image")));
            this.coefficientBindingNavigatorSaveItem.Name = "coefficientBindingNavigatorSaveItem";
            this.coefficientBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.coefficientBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.coefficientBindingNavigatorSaveItem.Click += new System.EventHandler(this.coefficientBindingNavigatorSaveItem_Click);
            // 
            // id_coefficientTextBox
            // 
            this.id_coefficientTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.coefficientBindingSource, "id_coefficient", true));
            this.id_coefficientTextBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.id_coefficientTextBox.Location = new System.Drawing.Point(777, 163);
            this.id_coefficientTextBox.Name = "id_coefficientTextBox";
            this.id_coefficientTextBox.Size = new System.Drawing.Size(201, 32);
            this.id_coefficientTextBox.TabIndex = 2;
            // 
            // juniorTextBox
            // 
            this.juniorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.coefficientBindingSource, "Junior", true));
            this.juniorTextBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.juniorTextBox.Location = new System.Drawing.Point(777, 210);
            this.juniorTextBox.Name = "juniorTextBox";
            this.juniorTextBox.Size = new System.Drawing.Size(201, 32);
            this.juniorTextBox.TabIndex = 4;
            // 
            // middleTextBox
            // 
            this.middleTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.coefficientBindingSource, "Middle", true));
            this.middleTextBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.middleTextBox.Location = new System.Drawing.Point(777, 259);
            this.middleTextBox.Name = "middleTextBox";
            this.middleTextBox.Size = new System.Drawing.Size(201, 32);
            this.middleTextBox.TabIndex = 6;
            // 
            // seniorTextBox
            // 
            this.seniorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.coefficientBindingSource, "Senior", true));
            this.seniorTextBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.seniorTextBox.Location = new System.Drawing.Point(777, 308);
            this.seniorTextBox.Name = "seniorTextBox";
            this.seniorTextBox.Size = new System.Drawing.Size(201, 32);
            this.seniorTextBox.TabIndex = 8;
            // 
            // kapTextBox
            // 
            this.kapTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.coefficientBindingSource, "kap", true));
            this.kapTextBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.kapTextBox.Location = new System.Drawing.Point(777, 358);
            this.kapTextBox.Name = "kapTextBox";
            this.kapTextBox.Size = new System.Drawing.Size(201, 32);
            this.kapTextBox.TabIndex = 10;
            // 
            // kuoTextBox
            // 
            this.kuoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.coefficientBindingSource, "kuo", true));
            this.kuoTextBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.kuoTextBox.Location = new System.Drawing.Point(777, 408);
            this.kuoTextBox.Name = "kuoTextBox";
            this.kuoTextBox.Size = new System.Drawing.Size(201, 32);
            this.kuoTextBox.TabIndex = 12;
            // 
            // ktosTextBox
            // 
            this.ktosTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.coefficientBindingSource, "ktos", true));
            this.ktosTextBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ktosTextBox.Location = new System.Drawing.Point(777, 602);
            this.ktosTextBox.Name = "ktosTextBox";
            this.ktosTextBox.Size = new System.Drawing.Size(201, 32);
            this.ktosTextBox.TabIndex = 14;
            // 
            // kvTextBox
            // 
            this.kvTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.coefficientBindingSource, "kv", true));
            this.kvTextBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.kvTextBox.Location = new System.Drawing.Point(777, 456);
            this.kvTextBox.Name = "kvTextBox";
            this.kvTextBox.Size = new System.Drawing.Size(201, 32);
            this.kvTextBox.TabIndex = 16;
            // 
            // ksTextBox
            // 
            this.ksTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.coefficientBindingSource, "ks", true));
            this.ksTextBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ksTextBox.Location = new System.Drawing.Point(777, 504);
            this.ksTextBox.Name = "ksTextBox";
            this.ksTextBox.Size = new System.Drawing.Size(201, 32);
            this.ksTextBox.TabIndex = 18;
            // 
            // kpdeTextBox
            // 
            this.kpdeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.coefficientBindingSource, "kpde", true));
            this.kpdeTextBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.kpdeTextBox.Location = new System.Drawing.Point(777, 554);
            this.kpdeTextBox.Name = "kpdeTextBox";
            this.kpdeTextBox.Size = new System.Drawing.Size(201, 32);
            this.kpdeTextBox.TabIndex = 20;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(217)))), ((int)(((byte)(187)))));
            this.button1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.button1.Location = new System.Drawing.Point(579, 667);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(180, 51);
            this.button1.TabIndex = 22;
            this.button1.Text = "Редактировать";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(217)))), ((int)(((byte)(187)))));
            this.button2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.button2.Location = new System.Drawing.Point(786, 667);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(180, 51);
            this.button2.TabIndex = 23;
            this.button2.Text = "Назад";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Oplata.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(0, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(205, 123);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // Formcoeficient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1241, 749);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(id_coefficientLabel);
            this.Controls.Add(this.id_coefficientTextBox);
            this.Controls.Add(juniorLabel);
            this.Controls.Add(this.juniorTextBox);
            this.Controls.Add(middleLabel);
            this.Controls.Add(this.middleTextBox);
            this.Controls.Add(seniorLabel);
            this.Controls.Add(this.seniorTextBox);
            this.Controls.Add(kapLabel);
            this.Controls.Add(this.kapTextBox);
            this.Controls.Add(kuoLabel);
            this.Controls.Add(this.kuoTextBox);
            this.Controls.Add(ktosLabel);
            this.Controls.Add(this.ktosTextBox);
            this.Controls.Add(kvLabel);
            this.Controls.Add(this.kvTextBox);
            this.Controls.Add(ksLabel);
            this.Controls.Add(this.ksTextBox);
            this.Controls.Add(kpdeLabel);
            this.Controls.Add(this.kpdeTextBox);
            this.Controls.Add(this.coefficientBindingNavigator);
            this.Name = "Formcoeficient";
            this.Text = "Formcoeficient";
            this.Load += new System.EventHandler(this.Formcoeficient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.zarplataDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coefficientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coefficientBindingNavigator)).EndInit();
            this.coefficientBindingNavigator.ResumeLayout(false);
            this.coefficientBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ZarplataDataSet zarplataDataSet;
        private System.Windows.Forms.BindingSource coefficientBindingSource;
        private ZarplataDataSetTableAdapters.coefficientTableAdapter coefficientTableAdapter;
        private ZarplataDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator coefficientBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton coefficientBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox id_coefficientTextBox;
        private System.Windows.Forms.TextBox juniorTextBox;
        private System.Windows.Forms.TextBox middleTextBox;
        private System.Windows.Forms.TextBox seniorTextBox;
        private System.Windows.Forms.TextBox kapTextBox;
        private System.Windows.Forms.TextBox kuoTextBox;
        private System.Windows.Forms.TextBox ktosTextBox;
        private System.Windows.Forms.TextBox kvTextBox;
        private System.Windows.Forms.TextBox ksTextBox;
        private System.Windows.Forms.TextBox kpdeTextBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}