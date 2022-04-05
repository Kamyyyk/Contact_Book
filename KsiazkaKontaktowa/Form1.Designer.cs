namespace KsiazkaKontaktowa
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.lastnameBox = new System.Windows.Forms.TextBox();
            this.emailBox = new System.Windows.Forms.TextBox();
            this.telBox = new System.Windows.Forms.TextBox();
            this.dateBox = new System.Windows.Forms.DateTimePicker();
            this.addBox = new System.Windows.Forms.Button();
            this.clearBox = new System.Windows.Forms.Button();
            this.deleteBox = new System.Windows.Forms.Button();
            this.updateBox = new System.Windows.Forms.Button();
            this.nameSearchBox = new System.Windows.Forms.TextBox();
            this.Szukaj = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 97);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(752, 201);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Imię";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(130, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nazwisko";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(239, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(309, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Numer telefonu";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(462, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Data urodzenia";
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(12, 25);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(93, 20);
            this.nameBox.TabIndex = 6;
            // 
            // lastnameBox
            // 
            this.lastnameBox.Location = new System.Drawing.Point(111, 25);
            this.lastnameBox.Name = "lastnameBox";
            this.lastnameBox.Size = new System.Drawing.Size(93, 20);
            this.lastnameBox.TabIndex = 7;
            // 
            // emailBox
            // 
            this.emailBox.Location = new System.Drawing.Point(210, 25);
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(93, 20);
            this.emailBox.TabIndex = 8;
            // 
            // telBox
            // 
            this.telBox.Location = new System.Drawing.Point(309, 25);
            this.telBox.Name = "telBox";
            this.telBox.Size = new System.Drawing.Size(93, 20);
            this.telBox.TabIndex = 9;
            // 
            // dateBox
            // 
            this.dateBox.CustomFormat = "yyyy-MM-dd";
            this.dateBox.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateBox.Location = new System.Drawing.Point(408, 25);
            this.dateBox.Name = "dateBox";
            this.dateBox.Size = new System.Drawing.Size(200, 20);
            this.dateBox.TabIndex = 10;
            this.dateBox.Value = new System.DateTime(2022, 4, 5, 0, 0, 0, 0);
            // 
            // addBox
            // 
            this.addBox.Location = new System.Drawing.Point(12, 51);
            this.addBox.Name = "addBox";
            this.addBox.Size = new System.Drawing.Size(66, 40);
            this.addBox.TabIndex = 11;
            this.addBox.Text = "Dodaj";
            this.addBox.UseVisualStyleBackColor = true;
            this.addBox.Click += new System.EventHandler(this.addBox_Click);
            // 
            // clearBox
            // 
            this.clearBox.Location = new System.Drawing.Point(84, 51);
            this.clearBox.Name = "clearBox";
            this.clearBox.Size = new System.Drawing.Size(66, 40);
            this.clearBox.TabIndex = 12;
            this.clearBox.Text = "Wyczyść";
            this.clearBox.UseVisualStyleBackColor = true;
            this.clearBox.Click += new System.EventHandler(this.clearBox_Click);
            // 
            // deleteBox
            // 
            this.deleteBox.Location = new System.Drawing.Point(156, 51);
            this.deleteBox.Name = "deleteBox";
            this.deleteBox.Size = new System.Drawing.Size(66, 40);
            this.deleteBox.TabIndex = 13;
            this.deleteBox.Text = "Usuń";
            this.deleteBox.UseVisualStyleBackColor = true;
            this.deleteBox.Click += new System.EventHandler(this.deleteBox_Click);
            // 
            // updateBox
            // 
            this.updateBox.Location = new System.Drawing.Point(228, 51);
            this.updateBox.Name = "updateBox";
            this.updateBox.Size = new System.Drawing.Size(66, 40);
            this.updateBox.TabIndex = 14;
            this.updateBox.Text = "Aktualizuj";
            this.updateBox.UseVisualStyleBackColor = true;
            this.updateBox.Click += new System.EventHandler(this.updateBox_Click);
            // 
            // nameSearchBox
            // 
            this.nameSearchBox.Location = new System.Drawing.Point(17, 352);
            this.nameSearchBox.Name = "nameSearchBox";
            this.nameSearchBox.Size = new System.Drawing.Size(591, 20);
            this.nameSearchBox.TabIndex = 19;
            this.nameSearchBox.TextChanged += new System.EventHandler(this.nameSearchBox_TextChanged);
            // 
            // Szukaj
            // 
            this.Szukaj.AutoSize = true;
            this.Szukaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Szukaj.Location = new System.Drawing.Point(277, 314);
            this.Szukaj.Name = "Szukaj";
            this.Szukaj.Size = new System.Drawing.Size(72, 25);
            this.Szukaj.TabIndex = 24;
            this.Szukaj.Text = "Szukaj";
            this.Szukaj.Click += new System.EventHandler(this.label10_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(630, 355);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(134, 17);
            this.checkBox1.TabIndex = 25;
            this.checkBox1.Text = "Wyświetl Solenizantów";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 383);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.Szukaj);
            this.Controls.Add(this.nameSearchBox);
            this.Controls.Add(this.updateBox);
            this.Controls.Add(this.deleteBox);
            this.Controls.Add(this.clearBox);
            this.Controls.Add(this.addBox);
            this.Controls.Add(this.dateBox);
            this.Controls.Add(this.telBox);
            this.Controls.Add(this.emailBox);
            this.Controls.Add(this.lastnameBox);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox lastnameBox;
        private System.Windows.Forms.TextBox emailBox;
        private System.Windows.Forms.TextBox telBox;
        private System.Windows.Forms.DateTimePicker dateBox;
        private System.Windows.Forms.Button addBox;
        private System.Windows.Forms.Button clearBox;
        private System.Windows.Forms.Button deleteBox;
        private System.Windows.Forms.Button updateBox;
        private System.Windows.Forms.TextBox nameSearchBox;
        private System.Windows.Forms.Label Szukaj;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

