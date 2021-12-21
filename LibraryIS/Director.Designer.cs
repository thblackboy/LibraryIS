
namespace LibraryIS
{
    partial class Director
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
            this.delemployer = new System.Windows.Forms.Button();
            this.addemployer = new System.Windows.Forms.Button();
            this.delpost = new System.Windows.Forms.Button();
            this.addpost = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // delemployer
            // 
            this.delemployer.AutoSize = true;
            this.delemployer.Location = new System.Drawing.Point(231, 153);
            this.delemployer.Name = "delemployer";
            this.delemployer.Size = new System.Drawing.Size(184, 23);
            this.delemployer.TabIndex = 3;
            this.delemployer.Text = "Удалить сотрудника из системы";
            this.delemployer.UseVisualStyleBackColor = true;
            this.delemployer.Click += new System.EventHandler(this.delemployer_Click);
            // 
            // addemployer
            // 
            this.addemployer.AutoSize = true;
            this.addemployer.Location = new System.Drawing.Point(12, 153);
            this.addemployer.Name = "addemployer";
            this.addemployer.Size = new System.Drawing.Size(182, 23);
            this.addemployer.TabIndex = 2;
            this.addemployer.Text = "Добавить/изменить сотрудника";
            this.addemployer.UseVisualStyleBackColor = true;
            this.addemployer.Click += new System.EventHandler(this.addemployer_Click);
            // 
            // delpost
            // 
            this.delpost.AutoSize = true;
            this.delpost.Location = new System.Drawing.Point(234, 191);
            this.delpost.Name = "delpost";
            this.delpost.Size = new System.Drawing.Size(181, 23);
            this.delpost.TabIndex = 5;
            this.delpost.Text = "Удалить должность из системы";
            this.delpost.UseVisualStyleBackColor = true;
            this.delpost.Click += new System.EventHandler(this.delpost_Click);
            // 
            // addpost
            // 
            this.addpost.AutoSize = true;
            this.addpost.Location = new System.Drawing.Point(12, 191);
            this.addpost.Name = "addpost";
            this.addpost.Size = new System.Drawing.Size(179, 23);
            this.addpost.TabIndex = 4;
            this.addpost.Text = "Добавить/изменить должность";
            this.addpost.UseVisualStyleBackColor = true;
            this.addpost.Click += new System.EventHandler(this.addpost_Click);
            // 
            // button3
            // 
            this.button3.AutoSize = true;
            this.button3.Location = new System.Drawing.Point(112, 287);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(203, 23);
            this.button3.TabIndex = 16;
            this.button3.Text = "История действий всех сотрудников";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(138, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Панель управления Директора";
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.Location = new System.Drawing.Point(15, 231);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(179, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "Отчет по книгам";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.Location = new System.Drawing.Point(234, 231);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(179, 23);
            this.button2.TabIndex = 19;
            this.button2.Text = "Отчет по сотрудникам";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Director
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 433);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.delpost);
            this.Controls.Add(this.addpost);
            this.Controls.Add(this.delemployer);
            this.Controls.Add(this.addemployer);
            this.Name = "Director";
            this.Text = "Панель управления Директора";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button delemployer;
        private System.Windows.Forms.Button addemployer;
        private System.Windows.Forms.Button delpost;
        private System.Windows.Forms.Button addpost;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}