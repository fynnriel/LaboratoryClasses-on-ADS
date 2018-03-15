namespace lab2
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
            this.menuFileLoad = new System.Windows.Forms.ToolStripMenuItem();
            this.lblInputValues = new System.Windows.Forms.Label();
            this.rtbInputValues = new System.Windows.Forms.RichTextBox();
            this.lblOutputValues = new System.Windows.Forms.Label();
            this.rtbOutputValues = new System.Windows.Forms.RichTextBox();
            this.grpInfo = new System.Windows.Forms.GroupBox();
            this.rtbInfo = new System.Windows.Forms.RichTextBox();
            this.btnSort = new System.Windows.Forms.Button();
            this.grpGenerateTest = new System.Windows.Forms.GroupBox();
            this.radGenerate100 = new System.Windows.Forms.RadioButton();
            this.radGenerate1000 = new System.Windows.Forms.RadioButton();
            this.radGenerate10000 = new System.Windows.Forms.RadioButton();
            this.radGenerate100000 = new System.Windows.Forms.RadioButton();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btn = new System.Windows.Forms.Button();
            this.grpSorting = new System.Windows.Forms.GroupBox();
            this.radSimpleMerge = new System.Windows.Forms.RadioButton();
            this.radNaturalMerge = new System.Windows.Forms.RadioButton();
            this.radDoubleMerge = new System.Windows.Forms.RadioButton();
            this.menuStrip1.SuspendLayout();
            this.grpInfo.SuspendLayout();
            this.grpGenerateTest.SuspendLayout();
            this.grpSorting.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFile});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(739, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuFile
            // 
            this.menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFileLoad});
            this.menuFile.Name = "menuFile";
            this.menuFile.Size = new System.Drawing.Size(48, 20);
            this.menuFile.Text = "Файл";
            // 
            // menuFileLoad
            // 
            this.menuFileLoad.Name = "menuFileLoad";
            this.menuFileLoad.Size = new System.Drawing.Size(152, 22);
            this.menuFileLoad.Text = "Загрузить";
            this.menuFileLoad.Click += new System.EventHandler(this.menuFileLoad_Click);
            // 
            // lblInputValues
            // 
            this.lblInputValues.AutoSize = true;
            this.lblInputValues.Location = new System.Drawing.Point(13, 28);
            this.lblInputValues.Name = "lblInputValues";
            this.lblInputValues.Size = new System.Drawing.Size(102, 13);
            this.lblInputValues.TabIndex = 1;
            this.lblInputValues.Text = "Исходные данные:";
            // 
            // rtbInputValues
            // 
            this.rtbInputValues.Location = new System.Drawing.Point(13, 48);
            this.rtbInputValues.Name = "rtbInputValues";
            this.rtbInputValues.ReadOnly = true;
            this.rtbInputValues.Size = new System.Drawing.Size(484, 220);
            this.rtbInputValues.TabIndex = 2;
            this.rtbInputValues.Text = "";
            // 
            // lblOutputValues
            // 
            this.lblOutputValues.AutoSize = true;
            this.lblOutputValues.Location = new System.Drawing.Point(13, 268);
            this.lblOutputValues.Name = "lblOutputValues";
            this.lblOutputValues.Size = new System.Drawing.Size(143, 13);
            this.lblOutputValues.TabIndex = 3;
            this.lblOutputValues.Text = "Отсортированные данные:";
            // 
            // rtbOutputValues
            // 
            this.rtbOutputValues.Location = new System.Drawing.Point(13, 285);
            this.rtbOutputValues.Name = "rtbOutputValues";
            this.rtbOutputValues.ReadOnly = true;
            this.rtbOutputValues.Size = new System.Drawing.Size(484, 220);
            this.rtbOutputValues.TabIndex = 4;
            this.rtbOutputValues.Text = "";
            // 
            // grpInfo
            // 
            this.grpInfo.Controls.Add(this.rtbInfo);
            this.grpInfo.Location = new System.Drawing.Point(503, 28);
            this.grpInfo.Name = "grpInfo";
            this.grpInfo.Size = new System.Drawing.Size(224, 191);
            this.grpInfo.TabIndex = 5;
            this.grpInfo.TabStop = false;
            this.grpInfo.Text = "Информация";
            // 
            // rtbInfo
            // 
            this.rtbInfo.Location = new System.Drawing.Point(7, 20);
            this.rtbInfo.Name = "rtbInfo";
            this.rtbInfo.ReadOnly = true;
            this.rtbInfo.Size = new System.Drawing.Size(211, 165);
            this.rtbInfo.TabIndex = 0;
            this.rtbInfo.Text = "";
            // 
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(503, 453);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(116, 52);
            this.btnSort.TabIndex = 6;
            this.btnSort.Text = "сортировать";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // grpGenerateTest
            // 
            this.grpGenerateTest.Controls.Add(this.radGenerate100000);
            this.grpGenerateTest.Controls.Add(this.radGenerate10000);
            this.grpGenerateTest.Controls.Add(this.radGenerate1000);
            this.grpGenerateTest.Controls.Add(this.radGenerate100);
            this.grpGenerateTest.Location = new System.Drawing.Point(503, 331);
            this.grpGenerateTest.Name = "grpGenerateTest";
            this.grpGenerateTest.Size = new System.Drawing.Size(224, 116);
            this.grpGenerateTest.TabIndex = 7;
            this.grpGenerateTest.TabStop = false;
            this.grpGenerateTest.Text = "Количество значений";
            // 
            // radGenerate100
            // 
            this.radGenerate100.AutoSize = true;
            this.radGenerate100.Checked = true;
            this.radGenerate100.Location = new System.Drawing.Point(7, 20);
            this.radGenerate100.Name = "radGenerate100";
            this.radGenerate100.Size = new System.Drawing.Size(43, 17);
            this.radGenerate100.TabIndex = 0;
            this.radGenerate100.TabStop = true;
            this.radGenerate100.Text = "100";
            this.radGenerate100.UseVisualStyleBackColor = true;
            // 
            // radGenerate1000
            // 
            this.radGenerate1000.AutoSize = true;
            this.radGenerate1000.Location = new System.Drawing.Point(7, 44);
            this.radGenerate1000.Name = "radGenerate1000";
            this.radGenerate1000.Size = new System.Drawing.Size(49, 17);
            this.radGenerate1000.TabIndex = 1;
            this.radGenerate1000.Text = "1000";
            this.radGenerate1000.UseVisualStyleBackColor = true;
            // 
            // radGenerate10000
            // 
            this.radGenerate10000.AutoSize = true;
            this.radGenerate10000.Location = new System.Drawing.Point(7, 68);
            this.radGenerate10000.Name = "radGenerate10000";
            this.radGenerate10000.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.radGenerate10000.Size = new System.Drawing.Size(58, 17);
            this.radGenerate10000.TabIndex = 2;
            this.radGenerate10000.Text = "10 000";
            this.radGenerate10000.UseVisualStyleBackColor = true;
            // 
            // radGenerate100000
            // 
            this.radGenerate100000.AutoSize = true;
            this.radGenerate100000.Location = new System.Drawing.Point(7, 92);
            this.radGenerate100000.Name = "radGenerate100000";
            this.radGenerate100000.Size = new System.Drawing.Size(64, 17);
            this.radGenerate100000.TabIndex = 3;
            this.radGenerate100000.Text = "100 000";
            this.radGenerate100000.UseVisualStyleBackColor = true;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(625, 453);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(96, 23);
            this.btnGenerate.TabIndex = 8;
            this.btnGenerate.Text = "генерировать";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(625, 482);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(96, 23);
            this.btn.TabIndex = 9;
            this.btn.Text = "тест";
            this.btn.UseVisualStyleBackColor = true;
            // 
            // grpSorting
            // 
            this.grpSorting.Controls.Add(this.radDoubleMerge);
            this.grpSorting.Controls.Add(this.radNaturalMerge);
            this.grpSorting.Controls.Add(this.radSimpleMerge);
            this.grpSorting.Location = new System.Drawing.Point(503, 225);
            this.grpSorting.Name = "grpSorting";
            this.grpSorting.Size = new System.Drawing.Size(226, 101);
            this.grpSorting.TabIndex = 10;
            this.grpSorting.TabStop = false;
            this.grpSorting.Text = "Сортировки";
            // 
            // radSimpleMerge
            // 
            this.radSimpleMerge.AutoSize = true;
            this.radSimpleMerge.Checked = true;
            this.radSimpleMerge.Location = new System.Drawing.Point(7, 20);
            this.radSimpleMerge.Name = "radSimpleMerge";
            this.radSimpleMerge.Size = new System.Drawing.Size(113, 17);
            this.radSimpleMerge.TabIndex = 0;
            this.radSimpleMerge.TabStop = true;
            this.radSimpleMerge.Text = "Простое слияние";
            this.radSimpleMerge.UseVisualStyleBackColor = true;
            // 
            // radNaturalMerge
            // 
            this.radNaturalMerge.AutoSize = true;
            this.radNaturalMerge.Location = new System.Drawing.Point(7, 44);
            this.radNaturalMerge.Name = "radNaturalMerge";
            this.radNaturalMerge.Size = new System.Drawing.Size(141, 17);
            this.radNaturalMerge.TabIndex = 1;
            this.radNaturalMerge.Text = "Естественное слияние";
            this.radNaturalMerge.UseVisualStyleBackColor = true;
            // 
            // radDoubleMerge
            // 
            this.radDoubleMerge.AutoSize = true;
            this.radDoubleMerge.Location = new System.Drawing.Point(7, 68);
            this.radDoubleMerge.Name = "radDoubleMerge";
            this.radDoubleMerge.Size = new System.Drawing.Size(141, 17);
            this.radDoubleMerge.TabIndex = 2;
            this.radDoubleMerge.Text = "Двухпоточное слияние";
            this.radDoubleMerge.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 521);
            this.Controls.Add(this.grpSorting);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.grpGenerateTest);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.grpInfo);
            this.Controls.Add(this.rtbOutputValues);
            this.Controls.Add(this.lblOutputValues);
            this.Controls.Add(this.rtbInputValues);
            this.Controls.Add(this.lblInputValues);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(720, 560);
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grpInfo.ResumeLayout(false);
            this.grpGenerateTest.ResumeLayout(false);
            this.grpGenerateTest.PerformLayout();
            this.grpSorting.ResumeLayout(false);
            this.grpSorting.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuFile;
        private System.Windows.Forms.ToolStripMenuItem menuFileLoad;
        private System.Windows.Forms.Label lblInputValues;
        private System.Windows.Forms.RichTextBox rtbInputValues;
        private System.Windows.Forms.Label lblOutputValues;
        private System.Windows.Forms.RichTextBox rtbOutputValues;
        private System.Windows.Forms.GroupBox grpInfo;
        private System.Windows.Forms.RichTextBox rtbInfo;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.GroupBox grpGenerateTest;
        private System.Windows.Forms.RadioButton radGenerate100000;
        private System.Windows.Forms.RadioButton radGenerate10000;
        private System.Windows.Forms.RadioButton radGenerate1000;
        private System.Windows.Forms.RadioButton radGenerate100;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.GroupBox grpSorting;
        private System.Windows.Forms.RadioButton radDoubleMerge;
        private System.Windows.Forms.RadioButton radNaturalMerge;
        private System.Windows.Forms.RadioButton radSimpleMerge;
    }
}

