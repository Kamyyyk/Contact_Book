using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Threading;

namespace KsiazkaKontaktowa
{
    public partial class Form1 : Form
    {
        DataTable dt = new DataTable();
        Connection connection = new Connection();
        int ID;
        string displayQuery = "SELECT id, name AS Imie, lastname AS Nazwisko, telnumber AS 'Numer Telefonu', email AS Email, birth AS 'Data urodzenia', ROUND(365-MOD(julianday(date('now')) - julianday(date(birth)),365.25)) AS Dnidourodzin FROM Contacts ORDER BY Dnidourodzin ";
        public Form1()
        {
            InitializeComponent();
            display(displayQuery);
            SetTimer();
        }

        public void display(String Query)
        {
            dt = new DataTable();
            connection.Open();          
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(Query, connection.myConnection);
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            connection.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                displayBirthdays();
                display(displayQuery);

            }
            else
            {
                displayQuery = "SELECT id, name AS Imie, lastname AS Nazwisko, telnumber AS 'Numer Telefonu', email AS Email, birth AS 'Data urodzenia', ROUND(365-MOD(julianday(date('now')) - julianday(date(birth)),365.25)) AS Dnidourodzin FROM Contacts ORDER BY Dnidourodzin ";
                display(displayQuery);
            }         

        }

        public void displayBirthdays()
        {
            displayQuery = "SELECT id, name AS Imie, lastname AS Nazwisko, telnumber AS 'Numer Telefonu', email AS Email, birth AS 'Data urodzenia', ROUND(365-MOD(julianday(date('now')) - julianday(date(birth)),365.25)) AS Dnidourodzin FROM Contacts WHERE Dnidourodzin < 8 ORDER BY Dnidourodzin  ";
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        public void clear()
        {
            nameBox.Text = "";
            lastnameBox.Text = "";
            emailBox.Text = "";
            telBox.Text = "";
        }

        private void clearBox_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void addBox_Click(object sender, EventArgs e)
        {
            if (nameBox.Text == "" || lastnameBox.Text == "" || emailBox.Text == "" || dateBox.Text == "")
            {
                MessageBox.Show("Nie wypełniono wszystkich luk...");
            }
            else
            {
                connection.Open();
                String query = "INSERT INTO Contacts (name, lastname, email, telnumber, birth) VALUES ('" + nameBox.Text + "', '" + lastnameBox.Text + "', '" + emailBox.Text + "', '" + telBox.Text + "', '" + dateBox.Text + "')";
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(query, connection.myConnection);
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
                connection.Close();
                display(displayQuery);
                MessageBox.Show("Dodano nowy element do bazy");
            }
        }

        private void nameSearchBox_TextChanged(object sender, EventArgs e)
        {
            if (nameSearchBox.Text == String.Empty)
            {
                display(displayQuery);
            }
            else
            {
                displayQuery = string.Format("SELECT id, name AS Imie, lastname AS Nazwisko, telnumber AS 'Numer Telefonu', email AS Email, birth AS 'Data urodzenia' FROM Contacts WHERE name like '%{0}%' OR lastname like '%{0}%' OR telnumber like '%{0}%' OR email like '%{0}%' OR birth like '%{0}%' ", nameSearchBox.Text);
                display(displayQuery);
            }
        }


        private void deleteBox_Click(object sender, EventArgs e)
        {
            connection.Open();
            String query = "DELETE from Contacts WHERE id = '" + ID + "'";
            SQLiteCommand cmd = new SQLiteCommand(query, connection.myConnection);
            cmd.ExecuteNonQuery();
            connection.Close();
            display(displayQuery);
        }

        private void updateBox_Click(object sender, EventArgs e)
        {
            if (nameBox.Text == "" || lastnameBox.Text == "" || emailBox.Text == "" || dateBox.Text == "" || telBox.Text == "")
            {
                MessageBox.Show("Musisz wypełnić wszystkie pola aby zaktualizować wiersz");
            }
            else
            {
                connection.Open();
                String query = "UPDATE Contacts SET name= '" + nameBox.Text + "', lastname = '" + lastnameBox.Text + "', telnumber = '" + telBox.Text + "', email = '" + emailBox.Text + "', birth = '" + dateBox.Text + "' WHERE id='" + ID + "' ";
                SQLiteCommand cmd = new SQLiteCommand(query, connection.myConnection);
                cmd.ExecuteNonQuery();
                connection.Close();
                display(displayQuery);
                MessageBox.Show("Baza kontaktów została zaktualizowana");

            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

                ID = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                nameBox.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                lastnameBox.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                telBox.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                emailBox.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                dateBox.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        public void Timer_Tick(object sender, EventArgs e)
        {
            display(displayQuery);
            
        }
        public void SetTimer()
        {
            DispatcherTimer Timer = new DispatcherTimer();
            Timer.Tick += new EventHandler(Timer_Tick);
            Timer.Interval = new TimeSpan(0, 0, 10);
            Timer.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }


    }
}
