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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace quiz1111
{
    public partial class OrderHistoryForm : Form
    {

        public OrderHistoryForm()
        {
            InitializeComponent();
            getMenu();
        }

        public void getMenu()
        {
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

        private void viewID_Click(object sender, EventArgs e)
        {
            String searchTime = dateTimePicker1.Value.ToString("yyyy-MM-dd") + " " + timeBox.Text;

            getOrdersID(searchTime);
        }

        private void cancelID_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = View1.SelectedRows[0];
            string ID = row.Cells[0].Value.ToString();

            String query = "INSERT INTO AlterLog(idUser, state, AlterLog.before, AlterLog.after, alterDate) VALUES('" + UserSession.GetInstance().getId() + "', 'OrderCancel', '" + ID + "', '-', '" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "');";
            using (MySqlConnection connection = new MySqlConnection(QueryBuilder.GetInstance().getConn()))
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader rdr = cmd.ExecuteReader();
                rdr.Close();
                connection.Close();
            }

            query = "UPDATE OrderLog SET isCanceled = '1' WHERE OrderNum = " + ID + ";";
            using (MySqlConnection connection = new MySqlConnection(QueryBuilder.GetInstance().getConn()))
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader rdr = cmd.ExecuteReader();
                rdr.Close();
                connection.Close();
            }
            viewID_Click(sender, e);
            View2.Rows.Clear();
        }

        private void deleteDrink_Click(object sender, EventArgs e)
        {
            DataGridViewRow row1 = View1.SelectedRows[0];
            string orderID = row1.Cells[0].Value.ToString();

            DataGridViewRow row = View2.SelectedRows[0];
            string ID = row.Cells[0].Value.ToString();
            string menu = row.Cells[1].Value.ToString();

            string before = alterLog(orderID);

            String query = "DELETE FROM Orderlist WHERE idPos = " + ID + ";";
            using (MySqlConnection connection = new MySqlConnection(QueryBuilder.GetInstance().getConn()))
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader rdr = cmd.ExecuteReader();
                rdr.Close();
                connection.Close();
            }
            viewOrders_Click(sender, e);

            string after = alterLog(orderID);
            query = "INSERT INTO AlterLog(idUser, state, AlterLog.before, AlterLog.after, alterDate) VALUES('" + UserSession.GetInstance().getId() + "', 'UpdateOrder', '" + before + "', '" + after + "', '" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "');";
            using (MySqlConnection connection = new MySqlConnection(QueryBuilder.GetInstance().getConn()))
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader rdr = cmd.ExecuteReader();
                rdr.Close();
                connection.Close();
            }
        }

        private void addDrink_Click(object sender, EventArgs e)
        {
            DataGridViewRow row1 = View1.SelectedRows[0];
            string orderID = row1.Cells[0].Value.ToString();

            DataGridViewRow row = View1.SelectedRows[0];
            string ID = row.Cells[0].Value.ToString();

            string before = alterLog(orderID);

            setOrder(menuBox.Text, Int32.Parse(ID));
            viewOrders_Click(sender, e);

            string after = alterLog(orderID);

            String query = "INSERT INTO AlterLog(idUser, state, AlterLog.before, AlterLog.after, alterDate) VALUES('" + UserSession.GetInstance().getId() + "', 'UpdateOrder', '" + before + "', '" + after + "', '" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "');";
            using (MySqlConnection connection = new MySqlConnection(QueryBuilder.GetInstance().getConn()))
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader rdr = cmd.ExecuteReader();
                rdr.Close();
                connection.Close();
            }
        }

        private String alterLog(String ID)
        {
            String query = "SELECT menu, count(*) FROM Orderlist, Drink WHERE OrderNum = '" + ID + "' and Orderlist.idDrink = Drink.idDrink Group by menu;";
            String before = "";
            using (MySqlConnection connection = new MySqlConnection(QueryBuilder.GetInstance().getConn()))
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    before = before + rdr[0].ToString() + rdr[1].ToString() + "잔 ";
                }
                rdr.Close();
                connection.Close();
            }
            return before;
        }

        public String getPrice(String menu)
        {
            String query = "SELECT price FROM Drink WHERE menu = '" + menu + "';";
            String price = "";
            using (MySqlConnection connection = new MySqlConnection(QueryBuilder.GetInstance().getConn()))
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    price = rdr[0].ToString();
                }
                rdr.Close();
                connection.Close();
            }
            return price;
        }

        public String getMenuId(String menu)
        {
            String query = "SELECT idDrink FROM Drink WHERE menu = '" + menu + "';";
            String id = "";
            using (MySqlConnection connection = new MySqlConnection(QueryBuilder.GetInstance().getConn()))
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    id = rdr[0].ToString();
                }
                rdr.Close();
                connection.Close();
            }
            return id;
        }
        private void setOrder(String menu, int num)
        {
            String price = getPrice(menu);
            String menuId = getMenuId(menu);
            if (price == "") return;
            DBmanager.GetInstance().insert("Orderlist(idUser, idDrink, saleprice, posDate, posTime, OrderNum)", "('" + UserSession.GetInstance().getId() + "'," + menuId + ", " + price + ", '" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "', '" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + " " + timeBox.Text + ":00:00', '" + num + "')");
        }

        private void getOrdersID(String time)
        {
            View1.Rows.Clear();

            String query = "SELECT OrderNum, time FROM OrderLog WHERE isCanceled = 0 and time LIKE '" + time + "%';";
            View1.ColumnCount = 2;
            View1.Columns[0].Name = "주문 ID";
            View1.Columns[1].Name = "시간";

            using (MySqlConnection connection = new MySqlConnection(QueryBuilder.GetInstance().getConn()))
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader rdr = cmd.ExecuteReader();
                QueryBuilder.GetInstance().clearQ();
                String[] value = new String[View1.ColumnCount];
                while (rdr.Read())
                {
                    for (int i = 0; i < View1.ColumnCount; i++)
                    {
                        value[i] = rdr[i].ToString();
                    }
                    View1.Rows.Add(value);
                }
                rdr.Close();
            }
        }

        private void getOrders()
        {
            DataGridViewRow row = View1.SelectedRows[0];
            string ID = row.Cells[0].Value.ToString();

            View2.Rows.Clear();

            String query = "SELECT idPos, menu, saleprice FROM Orderlist, Drink WHERE OrderNum = " + ID + " and Orderlist.idDrink = Drink.idDrink;";
            View2.ColumnCount = 3;
            View2.Columns[0].Name = "POS ID";
            View2.Columns[1].Name = "메뉴";
            View2.Columns[2].Name = "가격";

            using (MySqlConnection connection = new MySqlConnection(QueryBuilder.GetInstance().getConn()))
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader rdr = cmd.ExecuteReader();
                QueryBuilder.GetInstance().clearQ();
                String[] value = new String[View2.ColumnCount];
                while (rdr.Read())
                {
                    for (int i = 0; i < View2.ColumnCount; i++)
                    {
                        value[i] = rdr[i].ToString();
                    }
                    View2.Rows.Add(value);
                }
                rdr.Close();
            }
        }

        private void viewOrders_Click(object sender, EventArgs e)
        {
            getOrders();
        }
    }
}
