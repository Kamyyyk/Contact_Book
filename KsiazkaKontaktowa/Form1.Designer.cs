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
            this.telSearchBox = new System.Windows.Forms.TextBox();
            this.emailSearchBox = new System.Windows.Forms.TextBox();
            this.lastnameSearchBox = new System.Windows.Forms.TextBox();
            this.nameSearchBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.RefreshButton = new System.Windows.Forms.Button();
            this.Szukaj = new System.Windows.Forms.Label();
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
            this.dateBox.Value = new System.DateTime(2022, 3, 26, 18, 34, 15, 0);
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
            // telSearchBox
            // 
            this.telSearchBox.Location = new System.Drawing.Point(485, 352);
            this.telSearchBox.Name = "telSearchBox";
            this.telSearchBox.Size = new System.Drawing.Size(100, 20);
            this.telSearchBox.TabIndex = 22;
            this.telSearchBox.TextChanged += new System.EventHandler(this.telSearchBox_TextChanged);
            // 
            // emailSearchBox
            // 
            this.emailSearchBox.Location = new System.Drawing.Point(386, 352);
            this.emailSearchBox.Name = "emailSearchBox";
            this.emailSearchBox.Size = new System.Drawing.Size(93, 20);
            this.emailSearchBox.TabIndex = 21;
            this.emailSearchBox.TextChanged += new System.EventHandler(this.emailSearchBox_TextChanged);
            // 
            // lastnameSearchBox
            // 
            this.lastnameSearchBox.Location = new System.Drawing.Point(287, 352);
            this.lastnameSearchBox.Name = "lastnameSearchBox";
            this.lastnameSearchBox.Size = new System.Drawing.Size(93, 20);
            this.lastnameSearchBox.TabIndex = 20;
            this.lastnameSearchBox.TextChanged += new System.EventHandler(this.lastnameSearchBox_TextChanged);
            // 
            // nameSearchBox
            // 
            this.nameSearchBox.Location = new System.Drawing.Point(188, 352);
            this.nameSearchBox.Name = "nameSearchBox";
            this.nameSearchBox.Size = new System.Drawing.Size(93, 20);
            this.nameSearchBox.TabIndex = 19;
            this.nameSearchBox.TextChanged += new System.EventHandler(this.nameSearchBox_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(494, 336);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Numer telefonu";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(415, 336);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Email";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(306, 336);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Nazwisko";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(219, 336);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(26, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Imię";
            // 
            // RefreshButton
            // 
            this.RefreshButton.Location = new System.Drawing.Point(74, 312);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(93, 61);
            this.RefreshButton.TabIndex = 23;
            this.RefreshButton.Text = "Odśwież";
            this.RefreshButton.UseVisualStyleBackColor = true;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // Szukaj
            // 
            this.Szukaj.AutoSize = true;
            this.Szukaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Szukaj.Location = new System.Drawing.Point(343, 301);
            this.Szukaj.Name = "Szukaj";
            this.Szukaj.Size = new System.Drawing.Size(72, 25);
            this.Szukaj.TabIndex = 24;
            this.Szukaj.Text = "Szukaj";
            this.Szukaj.Click += new System.EventHandler(this.label10_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 383);
            this.Controls.Add(this.Szukaj);
            this.Controls.Add(this.RefreshButton);
            this.Controls.Add(this.telSearchBox);
            this.Controls.Add(this.emailSearchBox);
            this.Controls.Add(this.lastnameSearchBox);
            this.Controls.Add(this.nameSearchBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
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
        private System.Windows.Forms.TextBox telSearchBox;
        private System.Windows.Forms.TextBox emailSearchBox;
        private System.Windows.Forms.TextBox lastnameSearchBox;
        private System.Windows.Forms.TextBox nameSearchBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button RefreshButton;
        private System.Windows.Forms.Label Szukaj;
    }
}

