
namespace LibraryIS
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.searchid = new System.Windows.Forms.Button();
            this.findid = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.search = new System.Windows.Forms.Button();
            this.searchfio = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.clear = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.sumsalary = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridView1.Location = new System.Drawing.Point(12, 65);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(776, 276);
            this.dataGridView1.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Ид сотрудника";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "ФИО";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Должность";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Зарплата";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Данные о зарплатах сотрудников:";
            // 
            // searchid
            // 
            this.searchid.AutoSize = true;
            this.searchid.Location = new System.Drawing.Point(224, 24);
            this.searchid.Name = "searchid";
            this.searchid.Size = new System.Drawing.Size(87, 23);
            this.searchid.TabIndex = 40;
            this.searchid.Text = "Искать";
            this.searchid.UseVisualStyleBackColor = true;
            this.searchid.Click += new System.EventHandler(this.searchid_Click);
            // 
            // findid
            // 
            this.findid.Location = new System.Drawing.Point(128, 26);
            this.findid.Name = "findid";
            this.findid.Size = new System.Drawing.Size(90, 20);
            this.findid.TabIndex = 39;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(45, 29);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(77, 13);
            this.label12.TabIndex = 38;
            this.label12.Text = "Поиск по ИД:";
            // 
            // search
            // 
            this.search.AutoSize = true;
            this.search.Location = new System.Drawing.Point(595, 24);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(87, 23);
            this.search.TabIndex = 37;
            this.search.Text = "Искать";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // searchfio
            // 
            this.searchfio.Location = new System.Drawing.Point(410, 26);
            this.searchfio.Name = "searchfio";
            this.searchfio.Size = new System.Drawing.Size(172, 20);
            this.searchfio.TabIndex = 36;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(317, 29);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(87, 13);
            this.label11.TabIndex = 35;
            this.label11.Text = "Поиск по ФИО:";
            // 
            // clear
            // 
            this.clear.AutoSize = true;
            this.clear.Location = new System.Drawing.Point(701, 24);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(87, 23);
            this.clear.TabIndex = 41;
            this.clear.Text = "Сброс поиска";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 375);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(261, 13);
            this.label2.TabIndex = 42;
            this.label2.Text = "Месячные расходы на зарплаты сотрудников (Р) :";
            // 
            // sumsalary
            // 
            this.sumsalary.AutoSize = true;
            this.sumsalary.Location = new System.Drawing.Point(282, 375);
            this.sumsalary.Name = "sumsalary";
            this.sumsalary.Size = new System.Drawing.Size(13, 13);
            this.sumsalary.TabIndex = 43;
            this.sumsalary.Text = "0";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sumsalary);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.searchid);
            this.Controls.Add(this.findid);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.search);
            this.Controls.Add(this.searchfio);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form2";
            this.Text = "Данные по зарплате";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button searchid;
        private System.Windows.Forms.TextBox findid;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.TextBox searchfio;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label sumsalary;
    }
}