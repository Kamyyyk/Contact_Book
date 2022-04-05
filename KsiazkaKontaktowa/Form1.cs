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

namespace KsiazkaKontaktowa
{
    public partial class Form1 : Form
    {
        DataTable dt = new DataTable();
        Connection connection = new Connection();
        int ID;
        public Form1()
        {
            InitializeComponent();
        }

        public void display()
        {
            dt = new DataTable();
            connection.Open();
            string query = "SELECT id, name AS Imie, lastname AS Nazwisko, telnumber AS 'Numer Telefonu', email AS Email, birth AS 'Data urodzenia', ROUND(365-MOD(julianday(date('now')) - julianday(date(birth)),365.25)) AS Dnidourodzin FROM Contacts ORDER BY Dnidourodzin ";
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(query, connection.myConnection);
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            connection.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            display();
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
                display();
                MessageBox.Show("Dodano nowy element do bazy");
            }
        }



        private void lastnameSearchBox_TextChanged(object sender, EventArgs e)
        {
            dt = new DataTable();
            connection.Open();
            String query = "SELECT id, name AS Imie, lastname AS Nazwisko, telnumber AS 'Numer Telefonu', email AS Email, birth AS 'Data urodzenia' FROM Contacts WHERE lastname like '%" + lastnameSearchBox.Text.ToLower() + "%'";
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(query, connection.myConnection);
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            connection.Close();
        }

        private void nameSearchBox_TextChanged(object sender, EventArgs e)
        {
            dt = new DataTable();
            connection.Open();
            String query = "SELECT id, name AS Imie, lastname AS Nazwisko, telnumber AS 'Numer Telefonu', email AS Email, birth AS 'Data urodzenia' FROM Contacts WHERE name like '%" + nameSearchBox.Text.ToLower() + "%'";
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(query, connection.myConnection);
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            connection.Close();
        }

        private void telSearchBox_TextChanged(object sender, EventArgs e)
        {
            dt = new DataTable();
            connection.Open();
            String query = "SELECT id, name AS Imie, lastname AS Nazwisko, telnumber AS 'Numer Telefonu', email AS Email, birth AS 'Data urodzenia' FROM Contacts WHERE telnumber like '%" + telSearchBox.Text + "%'";
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(query, connection.myConnection);
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            connection.Close();
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            dt = new DataTable();
            connection.Open();
            string query = "SELECT id, name AS Imie, lastname AS Nazwisko, telnumber AS 'Numer Telefonu', email, birth AS 'Data urodzenia' FROM Contacts";
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(query, connection.myConnection);
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            connection.Close();
        }

        private void emailSearchBox_TextChanged(object sender, EventArgs e)
        {
            dt = new DataTable();
            connection.Open();
            String query = "SELECT id, name AS Imie, lastname AS Nazwisko, telnumber AS 'Numer Telefonu', email AS Email, birth AS 'Data urodzenia' FROM Contacts WHERE email like '%" + emailSearchBox.Text.ToLower() + "%'";
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(query, connection.myConnection);
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            connection.Close();
        }

        private void deleteBox_Click(object sender, EventArgs e)
        {
            connection.Open();
            String query = "DELETE from Contacts WHERE id = '" + ID + "'";
            SQLiteCommand cmd = new SQLiteCommand(query, connection.myConnection);
            cmd.ExecuteNonQuery();
            connection.Close();
            display();
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
                display();
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
    }
}
