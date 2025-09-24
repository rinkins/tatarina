namespace LastDAmnTime
{
    partial class перс2
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
            System.Windows.Forms.Label iD_посещенияLabel;
            System.Windows.Forms.Label iD_сотрудникаLabel;
            System.Windows.Forms.Label входLabel;
            System.Windows.Forms.Label время_событияLabel;
            System.Windows.Forms.Label дата_событияLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(перс2));
            this.proninaLastLastDataSet = new LastDAmnTime.ProninaLastLastDataSet();
            this.система_турникетовBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.система_турникетовTableAdapter = new LastDAmnTime.ProninaLastLastDataSetTableAdapters.Система_турникетовTableAdapter();
            this.tableAdapterManager = new LastDAmnTime.ProninaLastLastDataSetTableAdapters.TableAdapterManager();
            this.система_турникетовBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.система_турникетовBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.система_турникетовDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iD_посещенияTextBox = new System.Windows.Forms.TextBox();
            this.iD_сотрудникаTextBox = new System.Windows.Forms.TextBox();
            this.входCheckBox = new System.Windows.Forms.CheckBox();
            this.время_событияTextBox = new System.Windows.Forms.TextBox();
            this.дата_событияDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            iD_посещенияLabel = new System.Windows.Forms.Label();
            iD_сотрудникаLabel = new System.Windows.Forms.Label();
            входLabel = new System.Windows.Forms.Label();
            время_событияLabel = new System.Windows.Forms.Label();
            дата_событияLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.proninaLastLastDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.система_турникетовBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.система_турникетовBindingNavigator)).BeginInit();
            this.система_турникетовBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.система_турникетовDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // iD_посещенияLabel
            // 
            iD_посещенияLabel.AutoSize = true;
            iD_посещенияLabel.Location = new System.Drawing.Point(28, 292);
            iD_посещенияLabel.Name = "iD_посещенияLabel";
            iD_посещенияLabel.Size = new System.Drawing.Size(81, 13);
            iD_посещенияLabel.TabIndex = 2;
            iD_посещенияLabel.Text = "ID посещения:";
            // 
            // iD_сотрудникаLabel
            // 
            iD_сотрудникаLabel.AutoSize = true;
            iD_сотрудникаLabel.Location = new System.Drawing.Point(28, 318);
            iD_сотрудникаLabel.Name = "iD_сотрудникаLabel";
            iD_сотрудникаLabel.Size = new System.Drawing.Size(82, 13);
            iD_сотрудникаLabel.TabIndex = 4;
            iD_сотрудникаLabel.Text = "ID сотрудника:";
            // 
            // входLabel
            // 
            входLabel.AutoSize = true;
            входLabel.Location = new System.Drawing.Point(28, 346);
            входLabel.Name = "входLabel";
            входLabel.Size = new System.Drawing.Size(34, 13);
            входLabel.TabIndex = 6;
            входLabel.Text = "Вход:";
            // 
            // время_событияLabel
            // 
            время_событияLabel.AutoSize = true;
            время_событияLabel.Location = new System.Drawing.Point(28, 374);
            время_событияLabel.Name = "время_событияLabel";
            время_событияLabel.Size = new System.Drawing.Size(89, 13);
            время_событияLabel.TabIndex = 8;
            время_событияLabel.Text = "Время события:";
            // 
            // дата_событияLabel
            // 
            дата_событияLabel.AutoSize = true;
            дата_событияLabel.Location = new System.Drawing.Point(28, 401);
            дата_событияLabel.Name = "дата_событияLabel";
            дата_событияLabel.Size = new System.Drawing.Size(82, 13);
            дата_событияLabel.TabIndex = 10;
            дата_событияLabel.Text = "Дата события:";
            // 
            // proninaLastLastDataSet
            // 
            this.proninaLastLastDataSet.DataSetName = "ProninaLastLastDataSet";
            this.proninaLastLastDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // система_турникетовBindingSource
            // 
            this.система_турникетовBindingSource.DataMember = "Система_турникетов";
            this.система_турникетовBindingSource.DataSource = this.proninaLastLastDataSet;
            // 
            // система_турникетовTableAdapter
            // 
            this.система_турникетовTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ID_типа_партнераTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = LastDAmnTime.ProninaLastLastDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ДолжностиTableAdapter = null;
            this.tableAdapterManager.История_изменения_колва_материаTableAdapter = null;
            this.tableAdapterManager.История_партнераTableAdapter = null;
            this.tableAdapterManager.История_рейтингаTableAdapter = null;
            this.tableAdapterManager.КадрыTableAdapter = null;
            this.tableAdapterManager.Колво_на_складеTableAdapter = null;
            this.tableAdapterManager.МатериалыTableAdapter = null;
            this.tableAdapterManager.Необход_материалыTableAdapter = null;
            this.tableAdapterManager.ПартнерыTableAdapter = null;
            this.tableAdapterManager.ПоставкиTableAdapter = null;
            this.tableAdapterManager.ПоставщикиTableAdapter = null;
            this.tableAdapterManager.ПродукцияTableAdapter = null;
            this.tableAdapterManager.Система_турникетовTableAdapter = this.система_турникетовTableAdapter;
            this.tableAdapterManager.СкладTableAdapter = null;
            this.tableAdapterManager.Состав_поставкиTableAdapter = null;
            this.tableAdapterManager.Состав_сделкиTableAdapter = null;
            this.tableAdapterManager.СотрудникиTableAdapter = null;
            this.tableAdapterManager.Тип_материалаTableAdapter = null;
            this.tableAdapterManager.Торговые_точкиTableAdapter = null;
            // 
            // система_турникетовBindingNavigator
            // 
            this.система_турникетовBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.система_турникетовBindingNavigator.BindingSource = this.система_турникетовBindingSource;
            this.система_турникетовBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.система_турникетовBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.система_турникетовBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.система_турникетовBindingNavigatorSaveItem});
            this.система_турникетовBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.система_турникетовBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.система_турникетовBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.система_турникетовBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.система_турникетовBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.система_турникетовBindingNavigator.Name = "система_турникетовBindingNavigator";
            this.система_турникетовBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.система_турникетовBindingNavigator.Size = new System.Drawing.Size(758, 25);
            this.система_турникетовBindingNavigator.TabIndex = 0;
            this.система_турникетовBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // система_турникетовBindingNavigatorSaveItem
            // 
            this.система_турникетовBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.система_турникетовBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("система_турникетовBindingNavigatorSaveItem.Image")));
            this.система_турникетовBindingNavigatorSaveItem.Name = "система_турникетовBindingNavigatorSaveItem";
            this.система_турникетовBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.система_турникетовBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.система_турникетовBindingNavigatorSaveItem.Click += new System.EventHandler(this.система_турникетовBindingNavigatorSaveItem_Click);
            // 
            // система_турникетовDataGridView
            // 
            this.система_турникетовDataGridView.AutoGenerateColumns = false;
            this.система_турникетовDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(207)))), ((int)(((byte)(206)))));
            this.система_турникетовDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.система_турникетовDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.система_турникетовDataGridView.DataSource = this.система_турникетовBindingSource;
            this.система_турникетовDataGridView.Location = new System.Drawing.Point(12, 47);
            this.система_турникетовDataGridView.Name = "система_турникетовDataGridView";
            this.система_турникетовDataGridView.Size = new System.Drawing.Size(545, 236);
            this.система_турникетовDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID_посещения";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID_посещения";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ID_сотрудника";
            this.dataGridViewTextBoxColumn2.HeaderText = "ID_сотрудника";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "Вход";
            this.dataGridViewCheckBoxColumn1.HeaderText = "Вход";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Время_события";
            this.dataGridViewTextBoxColumn3.HeaderText = "Время_события";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Дата_события";
            this.dataGridViewTextBoxColumn4.HeaderText = "Дата_события";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // iD_посещенияTextBox
            // 
            this.iD_посещенияTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.система_турникетовBindingSource, "ID_посещения", true));
            this.iD_посещенияTextBox.Location = new System.Drawing.Point(123, 289);
            this.iD_посещенияTextBox.Name = "iD_посещенияTextBox";
            this.iD_посещенияTextBox.Size = new System.Drawing.Size(200, 20);
            this.iD_посещенияTextBox.TabIndex = 3;
            // 
            // iD_сотрудникаTextBox
            // 
            this.iD_сотрудникаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.система_турникетовBindingSource, "ID_сотрудника", true));
            this.iD_сотрудникаTextBox.Location = new System.Drawing.Point(123, 315);
            this.iD_сотрудникаTextBox.Name = "iD_сотрудникаTextBox";
            this.iD_сотрудникаTextBox.Size = new System.Drawing.Size(200, 20);
            this.iD_сотрудникаTextBox.TabIndex = 5;
            // 
            // входCheckBox
            // 
            this.входCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.система_турникетовBindingSource, "Вход", true));
            this.входCheckBox.Location = new System.Drawing.Point(123, 341);
            this.входCheckBox.Name = "входCheckBox";
            this.входCheckBox.Size = new System.Drawing.Size(200, 24);
            this.входCheckBox.TabIndex = 7;
            this.входCheckBox.UseVisualStyleBackColor = true;
            // 
            // время_событияTextBox
            // 
            this.время_событияTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.система_турникетовBindingSource, "Время_события", true));
            this.время_событияTextBox.Location = new System.Drawing.Point(123, 371);
            this.время_событияTextBox.Name = "время_событияTextBox";
            this.время_событияTextBox.Size = new System.Drawing.Size(200, 20);
            this.время_событияTextBox.TabIndex = 9;
            // 
            // дата_событияDateTimePicker
            // 
            this.дата_событияDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.система_турникетовBindingSource, "Дата_события", true));
            this.дата_событияDateTimePicker.Location = new System.Drawing.Point(123, 397);
            this.дата_событияDateTimePicker.Name = "дата_событияDateTimePicker";
            this.дата_событияDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.дата_событияDateTimePicker.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(111)))), ((int)(((byte)(148)))));
            this.button1.Location = new System.Drawing.Point(659, 416);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 33;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(299, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 20);
            this.label1.TabIndex = 34;
            this.label1.Text = "Система турникетов";
            // 
            // перс2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 451);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(iD_посещенияLabel);
            this.Controls.Add(this.iD_посещенияTextBox);
            this.Controls.Add(iD_сотрудникаLabel);
            this.Controls.Add(this.iD_сотрудникаTextBox);
            this.Controls.Add(входLabel);
            this.Controls.Add(this.входCheckBox);
            this.Controls.Add(время_событияLabel);
            this.Controls.Add(this.время_событияTextBox);
            this.Controls.Add(дата_событияLabel);
            this.Controls.Add(this.дата_событияDateTimePicker);
            this.Controls.Add(this.система_турникетовDataGridView);
            this.Controls.Add(this.система_турникетовBindingNavigator);
            this.Name = "перс2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "перс2";
            this.Load += new System.EventHandler(this.перс2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.proninaLastLastDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.система_турникетовBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.система_турникетовBindingNavigator)).EndInit();
            this.система_турникетовBindingNavigator.ResumeLayout(false);
            this.система_турникетовBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.система_турникетовDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ProninaLastLastDataSet proninaLastLastDataSet;
        private System.Windows.Forms.BindingSource система_турникетовBindingSource;
        private ProninaLastLastDataSetTableAdapters.Система_турникетовTableAdapter система_турникетовTableAdapter;
        private ProninaLastLastDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator система_турникетовBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton система_турникетовBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView система_турникетовDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.TextBox iD_посещенияTextBox;
        private System.Windows.Forms.TextBox iD_сотрудникаTextBox;
        private System.Windows.Forms.CheckBox входCheckBox;
        private System.Windows.Forms.TextBox время_событияTextBox;
        private System.Windows.Forms.DateTimePicker дата_событияDateTimePicker;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}