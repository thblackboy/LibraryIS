
namespace LibraryIS
{
    partial class Buhgalter
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
            this.label1 = new System.Windows.Forms.Label();
            this.salarydata = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(132, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Панель управления Бухгалтера";
            // 
            // salarydata
            // 
            this.salarydata.AutoSize = true;
            this.salarydata.Location = new System.Drawing.Point(124, 160);
            this.salarydata.Name = "salarydata";
            this.salarydata.Size = new System.Drawing.Size(182, 23);
            this.salarydata.TabIndex = 19;
            this.salarydata.Text = "Данные по зарплате";
            this.salarydata.UseVisualStyleBackColor = true;
            this.salarydata.Click += new System.EventHandler(this.salarydata_Click);
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.Location = new System.Drawing.Point(124, 204);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(183, 23);
            this.button1.TabIndex = 20;
            this.button1.Text = "Изменить зарплату у должности";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Buhgalter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 433);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.salarydata);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Buhgalter";
            this.Text = "Панель управления бухгалтера";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button salarydata;
        private System.Windows.Forms.Button button1;
    }
}