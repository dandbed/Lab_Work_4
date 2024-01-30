namespace Lab_Work_4
{
    partial class DataUploadForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.действияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ЗагрузитьДанныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ВыгрузитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьВыбранныеДанныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьВсеДанныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.перейтиКПросмотруДанныхToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Choose = new System.Windows.Forms.Button();
            this.Create = new System.Windows.Forms.Button();
            this.numericUpDown_forSelected = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_forAddData = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.обПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_forSelected)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_forAddData)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.действияToolStripMenuItem,
            this.обПрограммеToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(871, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // действияToolStripMenuItem
            // 
            this.действияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ЗагрузитьДанныеToolStripMenuItem,
            this.ВыгрузитьToolStripMenuItem,
            this.удалитьToolStripMenuItem,
            this.перейтиКПросмотруДанныхToolStripMenuItem});
            this.действияToolStripMenuItem.Name = "действияToolStripMenuItem";
            this.действияToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.действияToolStripMenuItem.Text = "Действия";
            // 
            // ЗагрузитьДанныеToolStripMenuItem
            // 
            this.ЗагрузитьДанныеToolStripMenuItem.Name = "ЗагрузитьДанныеToolStripMenuItem";
            this.ЗагрузитьДанныеToolStripMenuItem.Size = new System.Drawing.Size(238, 22);
            this.ЗагрузитьДанныеToolStripMenuItem.Text = "Загрузить";
            this.ЗагрузитьДанныеToolStripMenuItem.Click += new System.EventHandler(this.ЗагрузитьToolStripMenuItem_Click);
            // 
            // ВыгрузитьToolStripMenuItem
            // 
            this.ВыгрузитьToolStripMenuItem.Name = "ВыгрузитьToolStripMenuItem";
            this.ВыгрузитьToolStripMenuItem.Size = new System.Drawing.Size(238, 22);
            this.ВыгрузитьToolStripMenuItem.Text = "Выгрузить";
            this.ВыгрузитьToolStripMenuItem.Click += new System.EventHandler(this.ВыгрузитьToolStripMenuItem_Click);
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.удалитьВыбранныеДанныеToolStripMenuItem,
            this.удалитьВсеДанныеToolStripMenuItem});
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(238, 22);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            // 
            // удалитьВыбранныеДанныеToolStripMenuItem
            // 
            this.удалитьВыбранныеДанныеToolStripMenuItem.Name = "удалитьВыбранныеДанныеToolStripMenuItem";
            this.удалитьВыбранныеДанныеToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.удалитьВыбранныеДанныеToolStripMenuItem.Text = "Удалить выбранные данные";
            this.удалитьВыбранныеДанныеToolStripMenuItem.Click += new System.EventHandler(this.удалитьВыбранныеДанныеToolStripMenuItem_Click);
            // 
            // удалитьВсеДанныеToolStripMenuItem
            // 
            this.удалитьВсеДанныеToolStripMenuItem.Name = "удалитьВсеДанныеToolStripMenuItem";
            this.удалитьВсеДанныеToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.удалитьВсеДанныеToolStripMenuItem.Text = "Удалить все данные";
            this.удалитьВсеДанныеToolStripMenuItem.Click += new System.EventHandler(this.удалитьВсеДанныеToolStripMenuItem_Click);
            // 
            // перейтиКПросмотруДанныхToolStripMenuItem
            // 
            this.перейтиКПросмотруДанныхToolStripMenuItem.Name = "перейтиКПросмотруДанныхToolStripMenuItem";
            this.перейтиКПросмотруДанныхToolStripMenuItem.Size = new System.Drawing.Size(238, 22);
            this.перейтиКПросмотруДанныхToolStripMenuItem.Text = "Перейти к просмотру данных";
            this.перейтиКПросмотруДанныхToolStripMenuItem.Click += new System.EventHandler(this.перейтиКПросмотруДанныхToolStripMenuItem_Click);
            // 
            // dataGrid
            // 
            this.dataGrid.BackgroundColor = System.Drawing.Color.Silver;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Location = new System.Drawing.Point(18, 207);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.Size = new System.Drawing.Size(841, 414);
            this.dataGrid.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "Данные:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Silver;
            this.groupBox1.Controls.Add(this.Choose);
            this.groupBox1.Controls.Add(this.Create);
            this.groupBox1.Controls.Add(this.numericUpDown_forSelected);
            this.groupBox1.Controls.Add(this.numericUpDown_forAddData);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 114);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Настройки";
            // 
            // Choose
            // 
            this.Choose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Choose.Location = new System.Drawing.Point(519, 73);
            this.Choose.Name = "Choose";
            this.Choose.Size = new System.Drawing.Size(90, 30);
            this.Choose.TabIndex = 10;
            this.Choose.Text = "Выбрать";
            this.Choose.UseVisualStyleBackColor = true;
            this.Choose.Click += new System.EventHandler(this.Choose_Click);
            // 
            // Create
            // 
            this.Create.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Create.Location = new System.Drawing.Point(519, 34);
            this.Create.Name = "Create";
            this.Create.Size = new System.Drawing.Size(90, 30);
            this.Create.TabIndex = 9;
            this.Create.Text = "Создать";
            this.Create.UseVisualStyleBackColor = true;
            this.Create.Click += new System.EventHandler(this.Create_Click);
            // 
            // numericUpDown_forSelected
            // 
            this.numericUpDown_forSelected.Location = new System.Drawing.Point(419, 81);
            this.numericUpDown_forSelected.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_forSelected.Name = "numericUpDown_forSelected";
            this.numericUpDown_forSelected.Size = new System.Drawing.Size(60, 20);
            this.numericUpDown_forSelected.TabIndex = 8;
            this.numericUpDown_forSelected.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDown_forAddData
            // 
            this.numericUpDown_forAddData.Location = new System.Drawing.Point(419, 39);
            this.numericUpDown_forAddData.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_forAddData.Name = "numericUpDown_forAddData";
            this.numericUpDown_forAddData.Size = new System.Drawing.Size(60, 20);
            this.numericUpDown_forAddData.TabIndex = 7;
            this.numericUpDown_forAddData.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(221, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Выбор данных:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(28, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(356, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Количество добавляемых данных:";
            // 
            // обПрограммеToolStripMenuItem
            // 
            this.обПрограммеToolStripMenuItem.Name = "обПрограммеToolStripMenuItem";
            this.обПрограммеToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.обПрограммеToolStripMenuItem.Text = "Об программе";
            this.обПрограммеToolStripMenuItem.Click += new System.EventHandler(this.обПрограммеToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(846, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(25, 24);
            this.button1.TabIndex = 7;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DataUploadForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(58)))), ((int)(((byte)(77)))));
            this.ClientSize = new System.Drawing.Size(871, 633);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DataUploadForm";
            this.Text = "Учет транспортных средств и их владельцев";
            this.Shown += new System.EventHandler(this.DataUploadForm_Shown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_forSelected)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_forAddData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem действияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ЗагрузитьДанныеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ВыгрузитьToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown_forSelected;
        private System.Windows.Forms.NumericUpDown numericUpDown_forAddData;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem перейтиКПросмотруДанныхToolStripMenuItem;
        private System.Windows.Forms.Button Choose;
        private System.Windows.Forms.Button Create;
        private System.Windows.Forms.ToolStripMenuItem удалитьВыбранныеДанныеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьВсеДанныеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem обПрограммеToolStripMenuItem;
        private System.Windows.Forms.Button button1;
    }
}