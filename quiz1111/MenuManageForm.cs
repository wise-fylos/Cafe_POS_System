using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quiz1111
{
    public partial class MenuManageForm : Form
    {
        public MenuManageForm()
        {
            InitializeComponent();
            getMenu();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
        public void getMenu()
        {
            menuBox.Items.Clear();
            List<String> values = new List<String>();
            String query = "SELECT menu FROM Drink";
            using (MySqlConnection connection = new MySqlConnection(QueryBuilder.GetInstance().getConn()))
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    String obj = rdr[0].ToString();
                    values.Add(obj);
                }
                rdr.Close();
                connection.Close();
            }
            foreach (string item in values) menuBox.Items.Add(item);
        }

        private void insert_Click(object sender, EventArgs e)
        {
            String query = "INSERT INTO AlterLog(idUser, state, AlterLog.before, AlterLog.after, alterDate) VALUES('" + UserSession.GetInstance().getId() + "', 'Insert', '-', '" + name_i.Text + " " + price_i.Text + "원', '" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "');";
            using (MySqlConnection connection = new MySqlConnection(QueryBuilder.GetInstance().getConn()))
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader rdr = cmd.ExecuteReader();
                rdr.Close();
                connection.Close();
            }

            query = "INSERT INTO s5645120.Drink (menu, price) VALUES ('" + name_i.Text + "', '" + price_i.Text + "');";
            using (MySqlConnection connection = new MySqlConnection(QueryBuilder.GetInstance().getConn()))
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader rdr = cmd.ExecuteReader();
                rdr.Close();
                connection.Close();
            }
            getMenu();
        }

        private void update_Click(object sender, EventArgs e)
        {
            String price = getDrinkInfo(menuBox.Text);
            String query = "INSERT INTO AlterLog(idUser, state, AlterLog.before, AlterLog.after, alterDate) VALUES('" + UserSession.GetInstance().getId() + "', 'Update', '" + menuBox.Text + " " + price + "원', '" + name_u.Text + " " + price_u.Text + "원', '" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "');";
            using (MySqlConnection connection = new MySqlConnection(QueryBuilder.GetInstance().getConn()))
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader rdr = cmd.ExecuteReader();
                rdr.Close();
                connection.Close();
            }

            query = "UPDATE s5645120.Drink SET menu = '" + name_u.Text + "', price = " + price_u.Text + " WHERE (idDrink = " + (menuBox.SelectedIndex + 1) + ");";
            using (MySqlConnection connection = new MySqlConnection(QueryBuilder.GetInstance().getConn()))
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader rdr = cmd.ExecuteReader();
                rdr.Close();
                connection.Close();
            }
            getMenu();
        }

        private String getDrinkInfo(String name)
        {
            String result = "";
            String query = "SELECT price FROM Drink where menu = '" + name + "';";
            using (MySqlConnection connection = new MySqlConnection(QueryBuilder.GetInstance().getConn()))
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader rdr = cmd.ExecuteReader();
                rdr.Read();
                result = rdr[0].ToString();
                rdr.Close();
                connection.Close();
            }
            return result;
        }
    }
}
