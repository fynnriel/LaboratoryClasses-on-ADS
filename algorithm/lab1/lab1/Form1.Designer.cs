namespace lab1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileLoadData = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileTestData = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileTest10 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileTest100 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileTest1000 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileTest10000 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileTest100000 = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnClearInfo = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblColumn = new System.Windows.Forms.Label();
            this.cmbColumnNumber = new System.Windows.Forms.ComboBox();
            this.lblSortedValues = new System.Windows.Forms.Label();
            this.lblSortedValuesCount = new System.Windows.Forms.Label();
            this.lblInputValues = new System.Windows.Forms.Label();
            this.tbxOutputValues = new System.Windows.Forms.RichTextBox();
            this.tbxInputValues = new System.Windows.Forms.RichTextBox();
            this.tbxSortStat = new System.Windows.Forms.RichTextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSort = new System.Windows.Forms.Button();
            this.gbxSortValuesType = new System.Windows.Forms.GroupBox();
            this.radRecordsArray = new System.Windows.Forms.RadioButton();
            this.radNumbersArray = new System.Windows.Forms.RadioButton();
            this.gbxHowToSort = new System.Windows.Forms.GroupBox();
            this.radDescendingSort = new System.Windows.Forms.RadioButton();
            this.radAscendingSort = new System.Windows.Forms.RadioButton();
            this.grpSortTypes = new System.Windows.Forms.GroupBox();
            this.radBogoSort = new System.Windows.Forms.RadioButton();
            this.radBitByBitDescendSort = new System.Windows.Forms.RadioButton();
            this.radBitByBitAscendSort = new System.Windows.Forms.RadioButton();
            this.radMergeSort = new System.Windows.Forms.RadioButton();
            this.radGnomeSort = new System.Windows.Forms.RadioButton();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.menuStrip1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.gbxSortValuesType.SuspendLayout();
            this.gbxHowToSort.SuspendLayout();
            this.grpSortTypes.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFile});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(741, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuFile
            // 
            this.menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFileLoadData,
            this.menuFileTestData});
            this.menuFile.Name = "menuFile";
            this.menuFile.Size = new System.Drawing.Size(48, 20);
            this.menuFile.Text = "Файл";
            // 
            // menuFileLoadData
            // 
            this.menuFileLoadData.Name = "menuFileLoadData";
            this.menuFileLoadData.Size = new System.Drawing.Size(172, 22);
            this.menuFileLoadData.Text = "Загрузить данные";
            this.menuFileLoadData.Click += new System.EventHandler(this.menuFileLoadData_Click);
            // 
            // menuFileTestData
            // 
            this.menuFileTestData.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFileTest10,
            this.menuFileTest100,
            this.menuFileTest1000,
            this.menuFileTest10000,
            this.menuFileTest100000});
            this.menuFileTestData.Name = "menuFileTestData";
            this.menuFileTestData.Size = new System.Drawing.Size(172, 22);
            this.menuFileTestData.Text = "Тестовые данные";
            // 
            // menuFileTest10
            // 
            this.menuFileTest10.Name = "menuFileTest10";
            this.menuFileTest10.Size = new System.Drawing.Size(175, 22);
            this.menuFileTest10.Text = "10 элементов";
            this.menuFileTest10.Click += new System.EventHandler(this.menuFileTest10_Click);
            // 
            // menuFileTest100
            // 
            this.menuFileTest100.Name = "menuFileTest100";
            this.menuFileTest100.Size = new System.Drawing.Size(175, 22);
            this.menuFileTest100.Text = "100 элементов";
            this.menuFileTest100.Click += new System.EventHandler(this.menuFileTest100_Click);
            // 
            // menuFileTest1000
            // 
            this.menuFileTest1000.Name = "menuFileTest1000";
            this.menuFileTest1000.Size = new System.Drawing.Size(175, 22);
            this.menuFileTest1000.Text = "1000 элементов";
            this.menuFileTest1000.Click += new System.EventHandler(this.menuFileTest1000_Click);
            // 
            // menuFileTest10000
            // 
            this.menuFileTest10000.Name = "menuFileTest10000";
            this.menuFileTest10000.Size = new System.Drawing.Size(175, 22);
            this.menuFileTest10000.Text = "10 000 элементов";
            this.menuFileTest10000.Click += new System.EventHandler(this.menuFileTest10000_Click);
            // 
            // menuFileTest100000
            // 
            this.menuFileTest100000.Name = "menuFileTest100000";
            this.menuFileTest100000.Size = new System.Drawing.Size(175, 22);
            this.menuFileTest100000.Text = "100 000 элементов";
            this.menuFileTest100000.Click += new System.EventHandler(this.menuFileTest100000_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnClearInfo);
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(733, 462);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Характеристики сортировок";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnClearInfo
            // 
            this.btnClearInfo.Location = new System.Drawing.Point(8, 451);
            this.btnClearInfo.Name = "btnClearInfo";
            this.btnClearInfo.Size = new System.Drawing.Size(75, 23);
            this.btnClearInfo.TabIndex = 1;
            this.btnClearInfo.Text = "Очистить";
            this.btnClearInfo.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(8, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(717, 439);
            this.dataGridView1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lblColumn);
            this.tabPage1.Controls.Add(this.cmbColumnNumber);
            this.tabPage1.Controls.Add(this.lblSortedValues);
            this.tabPage1.Controls.Add(this.lblSortedValuesCount);
            this.tabPage1.Controls.Add(this.lblInputValues);
            this.tabPage1.Controls.Add(this.tbxOutputValues);
            this.tabPage1.Controls.Add(this.tbxInputValues);
            this.tabPage1.Controls.Add(this.tbxSortStat);
            this.tabPage1.Controls.Add(this.btnClear);
            this.tabPage1.Controls.Add(this.btnSort);
            this.tabPage1.Controls.Add(this.gbxSortValuesType);
            this.tabPage1.Controls.Add(this.gbxHowToSort);
            this.tabPage1.Controls.Add(this.grpSortTypes);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(733, 462);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Сортировка";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lblColumn
            // 
            this.lblColumn.AutoSize = true;
            this.lblColumn.Location = new System.Drawing.Point(321, 10);
            this.lblColumn.Name = "lblColumn";
            this.lblColumn.Size = new System.Drawing.Size(52, 13);
            this.lblColumn.TabIndex = 12;
            this.lblColumn.Text = "Столбец:";
            // 
            // cmbColumnNumber
            // 
            this.cmbColumnNumber.Enabled = false;
            this.cmbColumnNumber.FormattingEnabled = true;
            this.cmbColumnNumber.Items.AddRange(new object[] {
            "1"});
            this.cmbColumnNumber.Location = new System.Drawing.Point(379, 7);
            this.cmbColumnNumber.Name = "cmbColumnNumber";
            this.cmbColumnNumber.Size = new System.Drawing.Size(121, 21);
            this.cmbColumnNumber.TabIndex = 11;
            // 
            // lblSortedValues
            // 
            this.lblSortedValues.AutoSize = true;
            this.lblSortedValues.Location = new System.Drawing.Point(214, 239);
            this.lblSortedValues.Name = "lblSortedValues";
            this.lblSortedValues.Size = new System.Drawing.Size(134, 13);
            this.lblSortedValues.TabIndex = 10;
            this.lblSortedValues.Text = "Отсортированные даные";
            // 
            // lblSortedValuesCount
            // 
            this.lblSortedValuesCount.AutoSize = true;
            this.lblSortedValuesCount.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblSortedValuesCount.Location = new System.Drawing.Point(582, 3);
            this.lblSortedValuesCount.Name = "lblSortedValuesCount";
            this.lblSortedValuesCount.Padding = new System.Windows.Forms.Padding(0, 4, 20, 0);
            this.lblSortedValuesCount.Size = new System.Drawing.Size(148, 17);
            this.lblSortedValuesCount.TabIndex = 9;
            this.lblSortedValuesCount.Text = "Количество значений: 0";
            // 
            // lblInputValues
            // 
            this.lblInputValues.AutoSize = true;
            this.lblInputValues.Location = new System.Drawing.Point(214, 7);
            this.lblInputValues.Name = "lblInputValues";
            this.lblInputValues.Size = new System.Drawing.Size(92, 13);
            this.lblInputValues.TabIndex = 8;
            this.lblInputValues.Text = "Входные данные";
            // 
            // tbxOutputValues
            // 
            this.tbxOutputValues.Location = new System.Drawing.Point(214, 255);
            this.tbxOutputValues.Name = "tbxOutputValues";
            this.tbxOutputValues.ReadOnly = true;
            this.tbxOutputValues.Size = new System.Drawing.Size(497, 190);
            this.tbxOutputValues.TabIndex = 7;
            this.tbxOutputValues.Text = "";
            // 
            // tbxInputValues
            // 
            this.tbxInputValues.Location = new System.Drawing.Point(214, 34);
            this.tbxInputValues.Name = "tbxInputValues";
            this.tbxInputValues.ReadOnly = true;
            this.tbxInputValues.Size = new System.Drawing.Size(497, 198);
            this.tbxInputValues.TabIndex = 6;
            this.tbxInputValues.Text = "";
            // 
            // tbxSortStat
            // 
            this.tbxSortStat.Location = new System.Drawing.Point(6, 307);
            this.tbxSortStat.Name = "tbxSortStat";
            this.tbxSortStat.ReadOnly = true;
            this.tbxSortStat.Size = new System.Drawing.Size(172, 106);
            this.tbxSortStat.TabIndex = 5;
            this.tbxSortStat.Text = "";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(111, 422);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(72, 23);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Очистить";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(3, 422);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(91, 23);
            this.btnSort.TabIndex = 3;
            this.btnSort.Text = "Сортировать";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // gbxSortValuesType
            // 
            this.gbxSortValuesType.Controls.Add(this.radRecordsArray);
            this.gbxSortValuesType.Controls.Add(this.radNumbersArray);
            this.gbxSortValuesType.Location = new System.Drawing.Point(9, 231);
            this.gbxSortValuesType.Name = "gbxSortValuesType";
            this.gbxSortValuesType.Size = new System.Drawing.Size(172, 70);
            this.gbxSortValuesType.TabIndex = 2;
            this.gbxSortValuesType.TabStop = false;
            this.gbxSortValuesType.Text = "Тип сортируемых значений";
            // 
            // radRecordsArray
            // 
            this.radRecordsArray.AutoSize = true;
            this.radRecordsArray.Location = new System.Drawing.Point(7, 44);
            this.radRecordsArray.Name = "radRecordsArray";
            this.radRecordsArray.Size = new System.Drawing.Size(109, 17);
            this.radRecordsArray.TabIndex = 1;
            this.radRecordsArray.TabStop = true;
            this.radRecordsArray.Text = "Массив записей";
            this.radRecordsArray.UseVisualStyleBackColor = true;
            this.radRecordsArray.CheckedChanged += new System.EventHandler(this.radRecordsArray_CheckedChanged);
            // 
            // radNumbersArray
            // 
            this.radNumbersArray.AutoSize = true;
            this.radNumbersArray.Checked = true;
            this.radNumbersArray.Location = new System.Drawing.Point(7, 20);
            this.radNumbersArray.Name = "radNumbersArray";
            this.radNumbersArray.Size = new System.Drawing.Size(96, 17);
            this.radNumbersArray.TabIndex = 0;
            this.radNumbersArray.TabStop = true;
            this.radNumbersArray.Text = "Массив чисел";
            this.radNumbersArray.UseVisualStyleBackColor = true;
            this.radNumbersArray.CheckedChanged += new System.EventHandler(this.radNumbersArray_CheckedChanged);
            // 
            // gbxHowToSort
            // 
            this.gbxHowToSort.Controls.Add(this.radDescendingSort);
            this.gbxHowToSort.Controls.Add(this.radAscendingSort);
            this.gbxHowToSort.Location = new System.Drawing.Point(9, 156);
            this.gbxHowToSort.Name = "gbxHowToSort";
            this.gbxHowToSort.Size = new System.Drawing.Size(174, 69);
            this.gbxHowToSort.TabIndex = 1;
            this.gbxHowToSort.TabStop = false;
            this.gbxHowToSort.Text = "Как сортировать";
            // 
            // radDescendingSort
            // 
            this.radDescendingSort.AutoSize = true;
            this.radDescendingSort.Location = new System.Drawing.Point(6, 43);
            this.radDescendingSort.Name = "radDescendingSort";
            this.radDescendingSort.Size = new System.Drawing.Size(93, 17);
            this.radDescendingSort.TabIndex = 1;
            this.radDescendingSort.TabStop = true;
            this.radDescendingSort.Text = "По убыванию";
            this.radDescendingSort.UseVisualStyleBackColor = true;
            // 
            // radAscendingSort
            // 
            this.radAscendingSort.AutoSize = true;
            this.radAscendingSort.Checked = true;
            this.radAscendingSort.Location = new System.Drawing.Point(6, 20);
            this.radAscendingSort.Name = "radAscendingSort";
            this.radAscendingSort.Size = new System.Drawing.Size(109, 17);
            this.radAscendingSort.TabIndex = 0;
            this.radAscendingSort.TabStop = true;
            this.radAscendingSort.Text = "По возрастанию";
            this.radAscendingSort.UseVisualStyleBackColor = true;
            // 
            // grpSortTypes
            // 
            this.grpSortTypes.Controls.Add(this.radBogoSort);
            this.grpSortTypes.Controls.Add(this.radBitByBitDescendSort);
            this.grpSortTypes.Controls.Add(this.radBitByBitAscendSort);
            this.grpSortTypes.Controls.Add(this.radMergeSort);
            this.grpSortTypes.Controls.Add(this.radGnomeSort);
            this.grpSortTypes.Location = new System.Drawing.Point(9, 7);
            this.grpSortTypes.Name = "grpSortTypes";
            this.grpSortTypes.Size = new System.Drawing.Size(172, 143);
            this.grpSortTypes.TabIndex = 0;
            this.grpSortTypes.TabStop = false;
            this.grpSortTypes.Text = "Тип сортировки";
            // 
            // radBogoSort
            // 
            this.radBogoSort.AutoSize = true;
            this.radBogoSort.Location = new System.Drawing.Point(7, 116);
            this.radBogoSort.Name = "radBogoSort";
            this.radBogoSort.Size = new System.Drawing.Size(78, 17);
            this.radBogoSort.TabIndex = 4;
            this.radBogoSort.Text = "Случайная";
            this.radBogoSort.UseVisualStyleBackColor = true;
            // 
            // radBitByBitDescendSort
            // 
            this.radBitByBitDescendSort.AutoSize = true;
            this.radBitByBitDescendSort.Location = new System.Drawing.Point(7, 92);
            this.radBitByBitDescendSort.Name = "radBitByBitDescendSort";
            this.radBitByBitDescendSort.Size = new System.Drawing.Size(158, 17);
            this.radBitByBitDescendSort.TabIndex = 3;
            this.radBitByBitDescendSort.Text = "Поразрядная нисходящая";
            this.radBitByBitDescendSort.UseVisualStyleBackColor = true;
            // 
            // radBitByBitAscendSort
            // 
            this.radBitByBitAscendSort.AutoSize = true;
            this.radBitByBitAscendSort.Location = new System.Drawing.Point(7, 68);
            this.radBitByBitAscendSort.Name = "radBitByBitAscendSort";
            this.radBitByBitAscendSort.Size = new System.Drawing.Size(158, 17);
            this.radBitByBitAscendSort.TabIndex = 2;
            this.radBitByBitAscendSort.Text = "Поразрядная восходящая";
            this.radBitByBitAscendSort.UseVisualStyleBackColor = true;
            // 
            // radMergeSort
            // 
            this.radMergeSort.AutoSize = true;
            this.radMergeSort.Location = new System.Drawing.Point(7, 44);
            this.radMergeSort.Name = "radMergeSort";
            this.radMergeSort.Size = new System.Drawing.Size(76, 17);
            this.radMergeSort.TabIndex = 1;
            this.radMergeSort.Text = "Слиянием";
            this.radMergeSort.UseVisualStyleBackColor = true;
            // 
            // radGnomeSort
            // 
            this.radGnomeSort.AutoSize = true;
            this.radGnomeSort.Checked = true;
            this.radGnomeSort.Location = new System.Drawing.Point(7, 20);
            this.radGnomeSort.Name = "radGnomeSort";
            this.radGnomeSort.Size = new System.Drawing.Size(63, 17);
            this.radGnomeSort.TabIndex = 0;
            this.radGnomeSort.TabStop = true;
            this.radGnomeSort.Text = "Гномья";
            this.radGnomeSort.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(3, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(741, 488);
            this.tabControl1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 508);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MinimumSize = new System.Drawing.Size(757, 547);
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.gbxSortValuesType.ResumeLayout(false);
            this.gbxSortValuesType.PerformLayout();
            this.gbxHowToSort.ResumeLayout(false);
            this.gbxHowToSort.PerformLayout();
            this.grpSortTypes.ResumeLayout(false);
            this.grpSortTypes.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuFile;
        private System.Windows.Forms.ToolStripMenuItem menuFileLoadData;
        private System.Windows.Forms.ToolStripMenuItem menuFileTestData;
        private System.Windows.Forms.ToolStripMenuItem menuFileTest10;
        private System.Windows.Forms.ToolStripMenuItem menuFileTest100;
        private System.Windows.Forms.ToolStripMenuItem menuFileTest1000;
        private System.Windows.Forms.ToolStripMenuItem menuFileTest10000;
        private System.Windows.Forms.ToolStripMenuItem menuFileTest100000;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnClearInfo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label lblSortedValues;
        private System.Windows.Forms.Label lblSortedValuesCount;
        private System.Windows.Forms.Label lblInputValues;
        private System.Windows.Forms.RichTextBox tbxOutputValues;
        private System.Windows.Forms.RichTextBox tbxInputValues;
        private System.Windows.Forms.RichTextBox tbxSortStat;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.GroupBox gbxSortValuesType;
        private System.Windows.Forms.RadioButton radRecordsArray;
        private System.Windows.Forms.RadioButton radNumbersArray;
        private System.Windows.Forms.GroupBox gbxHowToSort;
        private System.Windows.Forms.RadioButton radDescendingSort;
        private System.Windows.Forms.RadioButton radAscendingSort;
        private System.Windows.Forms.GroupBox grpSortTypes;
        private System.Windows.Forms.RadioButton radBogoSort;
        private System.Windows.Forms.RadioButton radBitByBitDescendSort;
        private System.Windows.Forms.RadioButton radBitByBitAscendSort;
        private System.Windows.Forms.RadioButton radMergeSort;
        private System.Windows.Forms.RadioButton radGnomeSort;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.ComboBox cmbColumnNumber;
        private System.Windows.Forms.Label lblColumn;
    }
}

