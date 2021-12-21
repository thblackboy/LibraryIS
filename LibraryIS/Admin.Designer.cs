
namespace LibraryIS
{
    partial class Admin
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
            this.addemployer = new System.Windows.Forms.Button();
            this.delemployer = new System.Windows.Forms.Button();
            this.addpost = new System.Windows.Forms.Button();
            this.delpost = new System.Windows.Forms.Button();
            this.addgenre = new System.Windows.Forms.Button();
            this.delgenre = new System.Windows.Forms.Button();
            this.deledition = new System.Windows.Forms.Button();
            this.addedition = new System.Windows.Forms.Button();
            this.delbook = new System.Windows.Forms.Button();
            this.addbook = new System.Windows.Forms.Button();
            this.delclient = new System.Windows.Forms.Button();
            this.addclient = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addemployer
            // 
            this.addemployer.AutoSize = true;
            this.addemployer.Location = new System.Drawing.Point(12, 58);
            this.addemployer.Name = "addemployer";
            this.addemployer.Size = new System.Drawing.Size(182, 23);
            this.addemployer.TabIndex = 0;
            this.addemployer.Text = "Добавить/изменить сотрудника";
            this.addemployer.UseVisualStyleBackColor = true;
            this.addemployer.Click += new System.EventHandler(this.addemployer_Click);
            // 
            // delemployer
            // 
            this.delemployer.AutoSize = true;
            this.delemployer.Location = new System.Drawing.Point(233, 58);
            this.delemployer.Name = "delemployer";
            this.delemployer.Size = new System.Drawing.Size(184, 23);
            this.delemployer.TabIndex = 1;
            this.delemployer.Text = "Удалить сотрудника из системы";
            this.delemployer.UseVisualStyleBackColor = true;
            this.delemployer.Click += new System.EventHandler(this.delemployer_Click);
            // 
            // addpost
            // 
            this.addpost.AutoSize = true;
            this.addpost.Location = new System.Drawing.Point(12, 106);
            this.addpost.Name = "addpost";
            this.addpost.Size = new System.Drawing.Size(179, 23);
            this.addpost.TabIndex = 2;
            this.addpost.Text = "Добавить/изменить должность";
            this.addpost.UseVisualStyleBackColor = true;
            this.addpost.Click += new System.EventHandler(this.addpost_Click);
            // 
            // delpost
            // 
            this.delpost.AutoSize = true;
            this.delpost.Location = new System.Drawing.Point(233, 106);
            this.delpost.Name = "delpost";
            this.delpost.Size = new System.Drawing.Size(181, 23);
            this.delpost.TabIndex = 3;
            this.delpost.Text = "Удалить должность из системы";
            this.delpost.UseVisualStyleBackColor = true;
            this.delpost.Click += new System.EventHandler(this.delpost_Click);
            // 
            // addgenre
            // 
            this.addgenre.AutoSize = true;
            this.addgenre.Location = new System.Drawing.Point(12, 154);
            this.addgenre.Name = "addgenre";
            this.addgenre.Size = new System.Drawing.Size(179, 23);
            this.addgenre.TabIndex = 4;
            this.addgenre.Text = "Добавить/изменить жанр";
            this.addgenre.UseVisualStyleBackColor = true;
            this.addgenre.Click += new System.EventHandler(this.addgenre_Click);
            // 
            // delgenre
            // 
            this.delgenre.AutoSize = true;
            this.delgenre.Location = new System.Drawing.Point(233, 154);
            this.delgenre.Name = "delgenre";
            this.delgenre.Size = new System.Drawing.Size(179, 23);
            this.delgenre.TabIndex = 5;
            this.delgenre.Text = "Удалить жанр из системы";
            this.delgenre.UseVisualStyleBackColor = true;
            this.delgenre.Click += new System.EventHandler(this.delgenre_Click);
            // 
            // deledition
            // 
            this.deledition.AutoSize = true;
            this.deledition.Location = new System.Drawing.Point(233, 202);
            this.deledition.Name = "deledition";
            this.deledition.Size = new System.Drawing.Size(179, 23);
            this.deledition.TabIndex = 7;
            this.deledition.Text = "Удалить издание из системы";
            this.deledition.UseVisualStyleBackColor = true;
            this.deledition.Click += new System.EventHandler(this.deledition_Click);
            // 
            // addedition
            // 
            this.addedition.AutoSize = true;
            this.addedition.Location = new System.Drawing.Point(12, 202);
            this.addedition.Name = "addedition";
            this.addedition.Size = new System.Drawing.Size(179, 23);
            this.addedition.TabIndex = 6;
            this.addedition.Text = "Добавить/изменить издание";
            this.addedition.UseVisualStyleBackColor = true;
            this.addedition.Click += new System.EventHandler(this.addedition_Click);
            // 
            // delbook
            // 
            this.delbook.AutoSize = true;
            this.delbook.Location = new System.Drawing.Point(233, 250);
            this.delbook.Name = "delbook";
            this.delbook.Size = new System.Drawing.Size(179, 23);
            this.delbook.TabIndex = 9;
            this.delbook.Text = "Удалить книгу из каталога";
            this.delbook.UseVisualStyleBackColor = true;
            this.delbook.Click += new System.EventHandler(this.delbook_Click);
            // 
            // addbook
            // 
            this.addbook.AutoSize = true;
            this.addbook.Location = new System.Drawing.Point(12, 250);
            this.addbook.Name = "addbook";
            this.addbook.Size = new System.Drawing.Size(179, 23);
            this.addbook.TabIndex = 8;
            this.addbook.Text = "Добавить/изменить книгу";
            this.addbook.UseVisualStyleBackColor = true;
            this.addbook.Click += new System.EventHandler(this.addbook_Click);
            // 
            // delclient
            // 
            this.delclient.AutoSize = true;
            this.delclient.Location = new System.Drawing.Point(233, 298);
            this.delclient.Name = "delclient";
            this.delclient.Size = new System.Drawing.Size(179, 23);
            this.delclient.TabIndex = 11;
            this.delclient.Text = "Удалить читателя из системы";
            this.delclient.UseVisualStyleBackColor = true;
            this.delclient.Click += new System.EventHandler(this.delclient_Click);
            // 
            // addclient
            // 
            this.addclient.AutoSize = true;
            this.addclient.Location = new System.Drawing.Point(12, 298);
            this.addclient.Name = "addclient";
            this.addclient.Size = new System.Drawing.Size(179, 23);
            this.addclient.TabIndex = 10;
            this.addclient.Text = "Добавить/изменить читателя";
            this.addclient.UseVisualStyleBackColor = true;
            this.addclient.Click += new System.EventHandler(this.addclient_Click);
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.Location = new System.Drawing.Point(12, 346);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(179, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Выдать книгу читателю";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.Location = new System.Drawing.Point(233, 346);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(179, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "Принять книгу у читателя";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(120, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Панель управления Администратора";
            // 
            // button3
            // 
            this.button3.AutoSize = true;
            this.button3.Location = new System.Drawing.Point(112, 398);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(203, 23);
            this.button3.TabIndex = 15;
            this.button3.Text = "История действий всех сотрудников";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 433);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.delclient);
            this.Controls.Add(this.addclient);
            this.Controls.Add(this.delbook);
            this.Controls.Add(this.addbook);
            this.Controls.Add(this.deledition);
            this.Controls.Add(this.addedition);
            this.Controls.Add(this.delgenre);
            this.Controls.Add(this.addgenre);
            this.Controls.Add(this.delpost);
            this.Controls.Add(this.addpost);
            this.Controls.Add(this.delemployer);
            this.Controls.Add(this.addemployer);
            this.Name = "Admin";
            this.Text = "Панель управления Администратора";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addemployer;
        private System.Windows.Forms.Button delemployer;
        private System.Windows.Forms.Button addpost;
        private System.Windows.Forms.Button delpost;
        private System.Windows.Forms.Button addgenre;
        private System.Windows.Forms.Button delgenre;
        private System.Windows.Forms.Button deledition;
        private System.Windows.Forms.Button addedition;
        private System.Windows.Forms.Button delbook;
        private System.Windows.Forms.Button addbook;
        private System.Windows.Forms.Button delclient;
        private System.Windows.Forms.Button addclient;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
    }
}