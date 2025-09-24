namespace LastDAmnTime
{
    partial class партнеры3
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
            System.Windows.Forms.Label iD_измененияLabel;
            System.Windows.Forms.Label iD_партнераLabel;
            System.Windows.Forms.Label старый_рейтингLabel;
            System.Windows.Forms.Label новый_рейтингLabel;
            System.Windows.Forms.Label дата_записиLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(партнеры3));
            this.button2 = new System.Windows.Forms.Button();
            this.proninaLastLastDataSet = new LastDAmnTime.ProninaLastLastDataSet();
            this.история_рейтингаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.история_рейтингаTableAdapter = new LastDAmnTime.ProninaLastLastDataSetTableAdapters.История_рейтингаTableAdapter();
            this.tableAdapterManager = new LastDAmnTime.ProninaLastLastDataSetTableAdapters.TableAdapterManager();
            this.история_рейтингаBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.история_рейтингаBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.история_рейтингаDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iD_измененияTextBox = new System.Windows.Forms.TextBox();
            this.iD_партнераTextBox = new System.Windows.Forms.TextBox();
            this.старый_рейтингTextBox = new System.Windows.Forms.TextBox();
            this.новый_рейтингTextBox = new System.Windows.Forms.TextBox();
            this.дата_записиDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            iD_измененияLabel = new System.Windows.Forms.Label();
            iD_партнераLabel = new System.Windows.Forms.Label();
            старый_рейтингLabel = new System.Windows.Forms.Label();
            новый_рейтингLabel = new System.Windows.Forms.Label();
            дата_записиLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.proninaLastLastDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.история_рейтингаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.история_рейтингаBindingNavigator)).BeginInit();
            this.история_рейтингаBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.история_рейтингаDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // iD_измененияLabel
            // 
            iD_измененияLabel.AutoSize = true;
            iD_измененияLabel.Location = new System.Drawing.Point(28, 291);
            iD_измененияLabel.Name = "iD_измененияLabel";
            iD_измененияLabel.Size = new System.Drawing.Size(80, 13);
            iD_измененияLabel.TabIndex = 34;
            iD_измененияLabel.Text = "ID изменения:";
            // 
            // iD_партнераLabel
            // 
            iD_партнераLabel.AutoSize = true;
            iD_партнераLabel.Location = new System.Drawing.Point(28, 317);
            iD_партнераLabel.Name = "iD_партнераLabel";
            iD_партнераLabel.Size = new System.Drawing.Size(71, 13);
            iD_партнераLabel.TabIndex = 36;
            iD_партнераLabel.Text = "ID партнера:";
            // 
            // старый_рейтингLabel
            // 
            старый_рейтингLabel.AutoSize = true;
            старый_рейтингLabel.Location = new System.Drawing.Point(28, 343);
            старый_рейтингLabel.Name = "старый_рейтингLabel";
            старый_рейтингLabel.Size = new System.Drawing.Size(91, 13);
            старый_рейтингLabel.TabIndex = 38;
            старый_рейтингLabel.Text = "Старый рейтинг:";
            // 
            // новый_рейтингLabel
            // 
            новый_рейтингLabel.AutoSize = true;
            новый_рейтингLabel.Location = new System.Drawing.Point(28, 369);
            новый_рейтингLabel.Name = "новый_рейтингLabel";
            новый_рейтингLabel.Size = new System.Drawing.Size(87, 13);
            новый_рейтингLabel.TabIndex = 40;
            новый_рейтингLabel.Text = "Новый рейтинг:";
            // 
            // дата_записиLabel
            // 
            дата_записиLabel.AutoSize = true;
            дата_записиLabel.Location = new System.Drawing.Point(28, 396);
            дата_записиLabel.Name = "дата_записиLabel";
            дата_записиLabel.Size = new System.Drawing.Size(75, 13);
            дата_записиLabel.TabIndex = 42;
            дата_записиLabel.Text = "Дата записи:";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(111)))), ((int)(((byte)(148)))));
            this.button2.Location = new System.Drawing.Point(624, 415);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 33;
            this.button2.Text = "Назад";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // proninaLastLastDataSet
            // 
            this.proninaLastLastDataSet.DataSetName = "ProninaLastLastDataSet";
            this.proninaLastLastDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // история_рейтингаBindingSource
            // 
            this.история_рейтингаBindingSource.DataMember = "История_рейтинга";
            this.история_рейтингаBindingSource.DataSource = this.proninaLastLastDataSet;
            // 
            // история_рейтингаTableAdapter
            // 
            this.история_рейтингаTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ID_типа_партнераTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = LastDAmnTime.ProninaLastLastDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ДолжностиTableAdapter = null;
            this.tableAdapterManager.История_изменения_колва_материаTableAdapter = null;
            this.tableAdapterManager.История_партнераTableAdapter = null;
            this.tableAdapterManager.История_рейтингаTableAdapter = this.история_рейтингаTableAdapter;
            this.tableAdapterManager.КадрыTableAdapter = null;
            this.tableAdapterManager.Колво_на_складеTableAdapter = null;
            this.tableAdapterManager.МатериалыTableAdapter = null;
            this.tableAdapterManager.Необход_материалыTableAdapter = null;
            this.tableAdapterManager.ПартнерыTableAdapter = null;
            this.tableAdapterManager.ПоставкиTableAdapter = null;
            this.tableAdapterManager.ПоставщикиTableAdapter = null;
            this.tableAdapterManager.ПродукцияTableAdapter = null;
            this.tableAdapterManager.Система_турникетовTableAdapter = null;
            this.tableAdapterManager.СкладTableAdapter = null;
            this.tableAdapterManager.Состав_поставкиTableAdapter = null;
            this.tableAdapterManager.Состав_сделкиTableAdapter = null;
            this.tableAdapterManager.СотрудникиTableAdapter = null;
            this.tableAdapterManager.Тип_материалаTableAdapter = null;
            this.tableAdapterManager.Торговые_точкиTableAdapter = null;
            // 
            // история_рейтингаBindingNavigator
            // 
            this.история_рейтингаBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.история_рейтингаBindingNavigator.BindingSource = this.история_рейтингаBindingSource;
            this.история_рейтингаBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.история_рейтингаBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.история_рейтингаBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.история_рейтингаBindingNavigatorSaveItem});
            this.история_рейтингаBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.история_рейтингаBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.история_рейтингаBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.история_рейтингаBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.история_рейтингаBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.история_рейтингаBindingNavigator.Name = "история_рейтингаBindingNavigator";
            this.история_рейтингаBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.история_рейтингаBindingNavigator.Size = new System.Drawing.Size(740, 25);
            this.история_рейтингаBindingNavigator.TabIndex = 34;
            this.история_рейтингаBindingNavigator.Text = "bindingNavigator1";
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
            // история_рейтингаBindingNavigatorSaveItem
            // 
            this.история_рейтингаBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.история_рейтингаBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("история_рейтингаBindingNavigatorSaveItem.Image")));
            this.история_рейтингаBindingNavigatorSaveItem.Name = "история_рейтингаBindingNavigatorSaveItem";
            this.история_рейтингаBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.история_рейтингаBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.история_рейтингаBindingNavigatorSaveItem.Click += new System.EventHandler(this.история_рейтингаBindingNavigatorSaveItem_Click);
            // 
            // история_рейтингаDataGridView
            // 
            this.история_рейтингаDataGridView.AutoGenerateColumns = false;
            this.история_рейтингаDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(207)))), ((int)(((byte)(206)))));
            this.история_рейтингаDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.история_рейтингаDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.история_рейтингаDataGridView.DataSource = this.история_рейтингаBindingSource;
            this.история_рейтингаDataGridView.Location = new System.Drawing.Point(14, 42);
            this.история_рейтингаDataGridView.Name = "история_рейтингаDataGridView";
            this.история_рейтингаDataGridView.Size = new System.Drawing.Size(543, 220);
            this.история_рейтингаDataGridView.TabIndex = 34;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID_изменения";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID_изменения";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ID_партнера";
            this.dataGridViewTextBoxColumn2.HeaderText = "ID_партнера";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Старый_рейтинг";
            this.dataGridViewTextBoxColumn3.HeaderText = "Старый_рейтинг";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Новый_рейтинг";
            this.dataGridViewTextBoxColumn4.HeaderText = "Новый_рейтинг";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Дата_записи";
            this.dataGridViewTextBoxColumn5.HeaderText = "Дата_записи";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // iD_измененияTextBox
            // 
            this.iD_измененияTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.история_рейтингаBindingSource, "ID_изменения", true));
            this.iD_измененияTextBox.Location = new System.Drawing.Point(125, 288);
            this.iD_измененияTextBox.Name = "iD_измененияTextBox";
            this.iD_измененияTextBox.Size = new System.Drawing.Size(200, 20);
            this.iD_измененияTextBox.TabIndex = 35;
            // 
            // iD_партнераTextBox
            // 
            this.iD_партнераTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.история_рейтингаBindingSource, "ID_партнера", true));
            this.iD_партнераTextBox.Location = new System.Drawing.Point(125, 314);
            this.iD_партнераTextBox.Name = "iD_партнераTextBox";
            this.iD_партнераTextBox.Size = new System.Drawing.Size(200, 20);
            this.iD_партнераTextBox.TabIndex = 37;
            // 
            // старый_рейтингTextBox
            // 
            this.старый_рейтингTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.история_рейтингаBindingSource, "Старый_рейтинг", true));
            this.старый_рейтингTextBox.Location = new System.Drawing.Point(125, 340);
            this.старый_рейтингTextBox.Name = "старый_рейтингTextBox";
            this.старый_рейтингTextBox.Size = new System.Drawing.Size(200, 20);
            this.старый_рейтингTextBox.TabIndex = 39;
            // 
            // новый_рейтингTextBox
            // 
            this.новый_рейтингTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.история_рейтингаBindingSource, "Новый_рейтинг", true));
            this.новый_рейтингTextBox.Location = new System.Drawing.Point(125, 366);
            this.новый_рейтингTextBox.Name = "новый_рейтингTextBox";
            this.новый_рейтингTextBox.Size = new System.Drawing.Size(200, 20);
            this.новый_рейтингTextBox.TabIndex = 41;
            // 
            // дата_записиDateTimePicker
            // 
            this.дата_записиDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.история_рейтингаBindingSource, "Дата_записи", true));
            this.дата_записиDateTimePicker.Location = new System.Drawing.Point(125, 392);
            this.дата_записиDateTimePicker.Name = "дата_записиDateTimePicker";
            this.дата_записиDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.дата_записиDateTimePicker.TabIndex = 43;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(314, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 53;
            this.label1.Text = "Рейтинг";
            // 
            // партнеры3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(iD_измененияLabel);
            this.Controls.Add(this.iD_измененияTextBox);
            this.Controls.Add(iD_партнераLabel);
            this.Controls.Add(this.iD_партнераTextBox);
            this.Controls.Add(старый_рейтингLabel);
            this.Controls.Add(this.старый_рейтингTextBox);
            this.Controls.Add(новый_рейтингLabel);
            this.Controls.Add(this.новый_рейтингTextBox);
            this.Controls.Add(дата_записиLabel);
            this.Controls.Add(this.дата_записиDateTimePicker);
            this.Controls.Add(this.история_рейтингаDataGridView);
            this.Controls.Add(this.история_рейтингаBindingNavigator);
            this.Controls.Add(this.button2);
            this.Name = "партнеры3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "партнеры3";
            this.Load += new System.EventHandler(this.партнеры3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.proninaLastLastDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.история_рейтингаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.история_рейтингаBindingNavigator)).EndInit();
            this.история_рейтингаBindingNavigator.ResumeLayout(false);
            this.история_рейтингаBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.история_рейтингаDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private ProninaLastLastDataSet proninaLastLastDataSet;
        private System.Windows.Forms.BindingSource история_рейтингаBindingSource;
        private ProninaLastLastDataSetTableAdapters.История_рейтингаTableAdapter история_рейтингаTableAdapter;
        private ProninaLastLastDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator история_рейтингаBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton история_рейтингаBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView история_рейтингаDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.TextBox iD_измененияTextBox;
        private System.Windows.Forms.TextBox iD_партнераTextBox;
        private System.Windows.Forms.TextBox старый_рейтингTextBox;
        private System.Windows.Forms.TextBox новый_рейтингTextBox;
        private System.Windows.Forms.DateTimePicker дата_записиDateTimePicker;
        private System.Windows.Forms.Label label1;
    }
}