
namespace LibraryIS
{
    partial class AddEditGenre
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
            this.title = new System.Windows.Forms.TextBox();
            this.titlabel = new System.Windows.Forms.Label();
            this.editemployer = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.searchfio = new System.Windows.Forms.TextBox();
            this.clear = new System.Windows.Forms.Button();
            this.search = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // addemployer
            // 
            this.addemployer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addemployer.AutoSize = true;
            this.addemployer.Location = new System.Drawing.Point(426, 38);
            this.addemployer.Name = "addemployer";
            this.addemployer.Size = new System.Drawing.Size(87, 23);
            this.addemployer.TabIndex = 0;
            this.addemployer.Text = "Добавить";
            this.addemployer.UseVisualStyleBackColor = true;
            this.addemployer.Click += new System.EventHandler(this.addemployer_Click);
            // 
            // title
            // 
            this.title.Location = new System.Drawing.Point(78, 39);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(116, 20);
            this.title.TabIndex = 1;
            // 
            // titlabel
            // 
            this.titlabel.AutoSize = true;
            this.titlabel.Location = new System.Drawing.Point(12, 43);
            this.titlabel.Name = "titlabel";
            this.titlabel.Size = new System.Drawing.Size(60, 13);
            this.titlabel.TabIndex = 2;
            this.titlabel.Text = "Название:";
            // 
            // editemployer
            // 
            this.editemployer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.editemployer.AutoSize = true;
            this.editemployer.Location = new System.Drawing.Point(519, 38);
            this.editemployer.Name = "editemployer";
            this.editemployer.Size = new System.Drawing.Size(87, 23);
            this.editemployer.TabIndex = 22;
            this.editemployer.Text = "Изменить";
            this.editemployer.UseVisualStyleBackColor = true;
            this.editemployer.Click += new System.EventHandler(this.editemployer_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column11,
            this.Column1});
            this.dataGridView1.Location = new System.Drawing.Point(15, 131);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(612, 332);
            this.dataGridView1.TabIndex = 23;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column11
            // 
            this.Column11.HeaderText = "ИД";
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            this.Column11.Width = 49;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Название";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 82;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 97);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "Список жанров:";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(123, 97);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(112, 13);
            this.label11.TabIndex = 25;
            this.label11.Text = "Поиск по Названию:";
            // 
            // searchfio
            // 
            this.searchfio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchfio.Location = new System.Drawing.Point(241, 94);
            this.searchfio.Name = "searchfio";
            this.searchfio.Size = new System.Drawing.Size(172, 20);
            this.searchfio.TabIndex = 26;
            // 
            // clear
            // 
            this.clear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.clear.AutoSize = true;
            this.clear.Location = new System.Drawing.Point(519, 92);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(87, 23);
            this.clear.TabIndex = 28;
            this.clear.Text = "Сброс поиска";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // search
            // 
            this.search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.search.AutoSize = true;
            this.search.Location = new System.Drawing.Point(426, 92);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(87, 23);
            this.search.TabIndex = 27;
            this.search.Text = "Искать";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // AddEditGenre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 475);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.search);
            this.Controls.Add(this.searchfio);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.editemployer);
            this.Controls.Add(this.titlabel);
            this.Controls.Add(this.title);
            this.Controls.Add(this.addemployer);
            this.MaximizeBox = false;
            this.Name = "AddEditGenre";
            this.Text = "Добавить/Изменить жанр";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addemployer;
        private System.Windows.Forms.TextBox title;
        private System.Windows.Forms.Label titlabel;
        private System.Windows.Forms.Button editemployer;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox searchfio;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    }
}