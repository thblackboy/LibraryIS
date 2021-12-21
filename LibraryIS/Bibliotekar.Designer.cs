
namespace LibraryIS
{
    partial class Bibliotekar
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
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.delclient = new System.Windows.Forms.Button();
            this.addclient = new System.Windows.Forms.Button();
            this.delbook = new System.Windows.Forms.Button();
            this.addbook = new System.Windows.Forms.Button();
            this.deledition = new System.Windows.Forms.Button();
            this.addedition = new System.Windows.Forms.Button();
            this.delgenre = new System.Windows.Forms.Button();
            this.addgenre = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.Location = new System.Drawing.Point(242, 351);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(179, 23);
            this.button2.TabIndex = 23;
            this.button2.Text = "Принять книгу у читателя";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.Location = new System.Drawing.Point(12, 351);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(179, 23);
            this.button1.TabIndex = 22;
            this.button1.Text = "Выдать книгу читателю";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // delclient
            // 
            this.delclient.AutoSize = true;
            this.delclient.Location = new System.Drawing.Point(242, 305);
            this.delclient.Name = "delclient";
            this.delclient.Size = new System.Drawing.Size(179, 23);
            this.delclient.TabIndex = 21;
            this.delclient.Text = "Удалить читателя из системы";
            this.delclient.UseVisualStyleBackColor = true;
            this.delclient.Click += new System.EventHandler(this.delclient_Click);
            // 
            // addclient
            // 
            this.addclient.AutoSize = true;
            this.addclient.Location = new System.Drawing.Point(12, 305);
            this.addclient.Name = "addclient";
            this.addclient.Size = new System.Drawing.Size(179, 23);
            this.addclient.TabIndex = 20;
            this.addclient.Text = "Добавить/изменить читателя";
            this.addclient.UseVisualStyleBackColor = true;
            this.addclient.Click += new System.EventHandler(this.addclient_Click);
            // 
            // delbook
            // 
            this.delbook.AutoSize = true;
            this.delbook.Location = new System.Drawing.Point(242, 259);
            this.delbook.Name = "delbook";
            this.delbook.Size = new System.Drawing.Size(179, 23);
            this.delbook.TabIndex = 19;
            this.delbook.Text = "Удалить книгу из каталога";
            this.delbook.UseVisualStyleBackColor = true;
            this.delbook.Click += new System.EventHandler(this.delbook_Click);
            // 
            // addbook
            // 
            this.addbook.AutoSize = true;
            this.addbook.Location = new System.Drawing.Point(12, 259);
            this.addbook.Name = "addbook";
            this.addbook.Size = new System.Drawing.Size(179, 23);
            this.addbook.TabIndex = 18;
            this.addbook.Text = "Добавить/изменить книгу";
            this.addbook.UseVisualStyleBackColor = true;
            this.addbook.Click += new System.EventHandler(this.addbook_Click);
            // 
            // deledition
            // 
            this.deledition.AutoSize = true;
            this.deledition.Location = new System.Drawing.Point(242, 213);
            this.deledition.Name = "deledition";
            this.deledition.Size = new System.Drawing.Size(179, 23);
            this.deledition.TabIndex = 17;
            this.deledition.Text = "Удалить издание из системы";
            this.deledition.UseVisualStyleBackColor = true;
            this.deledition.Click += new System.EventHandler(this.deledition_Click);
            // 
            // addedition
            // 
            this.addedition.AutoSize = true;
            this.addedition.Location = new System.Drawing.Point(12, 213);
            this.addedition.Name = "addedition";
            this.addedition.Size = new System.Drawing.Size(179, 23);
            this.addedition.TabIndex = 16;
            this.addedition.Text = "Добавить/изменить издание";
            this.addedition.UseVisualStyleBackColor = true;
            this.addedition.Click += new System.EventHandler(this.addedition_Click);
            // 
            // delgenre
            // 
            this.delgenre.AutoSize = true;
            this.delgenre.Location = new System.Drawing.Point(242, 167);
            this.delgenre.Name = "delgenre";
            this.delgenre.Size = new System.Drawing.Size(179, 23);
            this.delgenre.TabIndex = 15;
            this.delgenre.Text = "Удалить жанр из системы";
            this.delgenre.UseVisualStyleBackColor = true;
            this.delgenre.Click += new System.EventHandler(this.delgenre_Click);
            // 
            // addgenre
            // 
            this.addgenre.AutoSize = true;
            this.addgenre.Location = new System.Drawing.Point(12, 167);
            this.addgenre.Name = "addgenre";
            this.addgenre.Size = new System.Drawing.Size(179, 23);
            this.addgenre.TabIndex = 14;
            this.addgenre.Text = "Добавить/изменить жанр";
            this.addgenre.UseVisualStyleBackColor = true;
            this.addgenre.Click += new System.EventHandler(this.addgenre_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(128, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Панель управления библиотекаря";
            // 
            // Bibliotekar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 433);
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
            this.MaximizeBox = false;
            this.Name = "Bibliotekar";
            this.Text = "Панель управления библиотекаря";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button delclient;
        private System.Windows.Forms.Button addclient;
        private System.Windows.Forms.Button delbook;
        private System.Windows.Forms.Button addbook;
        private System.Windows.Forms.Button deledition;
        private System.Windows.Forms.Button addedition;
        private System.Windows.Forms.Button delgenre;
        private System.Windows.Forms.Button addgenre;
        private System.Windows.Forms.Label label1;
    }
}