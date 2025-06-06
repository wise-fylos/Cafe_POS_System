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
    public partial class DashboardForm : Form
    {
        public String currentDate = "";
        public String menu = "";

        public DashboardForm()
        {
            InitializeComponent();
            currentDate = dateTimePicker2.Value.ToString("yyyy-MM-dd");
            getMenu();
        }

        private void 로그아웃ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DBmanager.GetInstance().insert("Userlog(loginID, time, state)", "('" + UserSession.GetInstance().getIdString() + "', '" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "', 'logout')");
            LoginForm login = new LoginForm();
            login.Show();
            this.Hide();
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            DBmanager.GetInstance().insert("Userlog(loginID, time, state)", "('" + UserSession.GetInstance().getIdString() + "', '" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "', 'logout')");
            System.Diagnostics.Process.GetCurrentProcess().Kill();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            currentDate = dateTimePicker2.Value.ToString("yyyy-MM-dd");
        }

        private void 사용자별일일판매액ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!UserSession.GetInstance().adminCheck()) return;
            adminView.Rows.Clear();

            String query = QueryBuilder.GetInstance().select("User.id as '사용자', count(*) as '일일 판매량', sum(price) as '일일 판매액'").from("s5645120.Orderlist, s5645120.User, s5645120.Drink, OrderLog").where("Orderlist.idUser = User.idUser and Orderlist.idDrink=Drink.idDrink and Orderlist.OrderNum = OrderLog.OrderNum AND isCanceled = 0 and posDate = '" + currentDate + "'").group("Orderlist.idUser").getQ();
            adminView.ColumnCount = 3;
            adminView.Columns[0].Name = "사용자";
            adminView.Columns[1].Name = "일일 판매량";
            adminView.Columns[2].Name = "일일 판매액";

            using (MySqlConnection connection = new MySqlConnection(QueryBuilder.GetInstance().getConn()))
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader rdr = cmd.ExecuteReader();
                QueryBuilder.GetInstance().clearQ();
                String[] value = new String[adminView.ColumnCount];
                while (rdr.Read())
                {
                    for (int i = 0; i < adminView.ColumnCount; i++)
                    {
                        value[i] = rdr[i].ToString();
                    }
                    adminView.Rows.Add(value);
                }
                rdr.Close();
            }
        }

        private void 사용자별일일판매량ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!UserSession.GetInstance().adminCheck()) return;
            adminView.Rows.Clear();

            String query = QueryBuilder.GetInstance().select("menu as '메뉴', count(*) as '일일 판매량', sum(price) as '일일 판매액'").from("s5645120.Orderlist, s5645120.Drink, OrderLog").where("Orderlist.idDrink=Drink.idDrink and Orderlist.OrderNum = OrderLog.OrderNum AND isCanceled = 0 and posDate='" + currentDate + "'").group("Orderlist.idDrink").getQ();
            adminView.ColumnCount = 3;
            adminView.Columns[0].Name = "메뉴";
            adminView.Columns[1].Name = "일일 판매량";
            adminView.Columns[2].Name = "일일 판매액";

            using (MySqlConnection connection = new MySqlConnection(QueryBuilder.GetInstance().getConn()))
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader rdr = cmd.ExecuteReader();
                QueryBuilder.GetInstance().clearQ();
                String[] value = new String[adminView.ColumnCount];
                while (rdr.Read())
                {
                    for (int i = 0; i < adminView.ColumnCount; i++)
                    {
                        value[i] = rdr[i].ToString();
                    }
                    adminView.Rows.Add(value);
                }
                rdr.Close();
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (!UserSession.GetInstance().adminCheck()) return;
            adminView.Rows.Clear();

            String query = QueryBuilder.GetInstance().select("menu, count(case when posDate LIKE '%-01-%' then 1 end) as 1월,\r\ncount(case when posDate LIKE '%-02-%' then 1 end) as 2월,\r\ncount(case when posDate LIKE '%-03-%' then 1 end) as 3월,\r\ncount(case when posDate LIKE '%-04-%' then 1 end) as 4월,\r\ncount(case when posDate LIKE '%-05-%' then 1 end) as 5월,\r\ncount(case when posDate LIKE '%-06-%' then 1 end) as 6월,\r\ncount(case when posDate LIKE '%-07-%' then 1 end) as 7월,\r\ncount(case when posDate LIKE '%-08-%' then 1 end) as 8월,\r\ncount(case when posDate LIKE '%-09-%' then 1 end) as 9월,\r\ncount(case when posDate LIKE '%-10-%' then 1 end) as 10월,\r\ncount(case when posDate LIKE '%-11-%' then 1 end) as 11월,\r\ncount(case when posDate LIKE '%-12-%' then 1 end) as 12월").from("s5645120.Orderlist, s5645120.Drink, OrderLog").where("Orderlist.idDrink = Drink.idDrink and Orderlist.OrderNum = OrderLog.OrderNum AND isCanceled = 0").group("Orderlist.idDrink").getQ();
            adminView.ColumnCount = 13;
            adminView.Columns[0].Name = "메뉴";
            for (int i = 1; i < adminView.ColumnCount; i++)
            {
                adminView.Columns[i].Name = i + "월";
            }

            using (MySqlConnection connection = new MySqlConnection(QueryBuilder.GetInstance().getConn()))
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader rdr = cmd.ExecuteReader();
                QueryBuilder.GetInstance().clearQ();
                String[] value = new String[adminView.ColumnCount];
                while (rdr.Read())
                {
                    for (int i = 0; i < adminView.ColumnCount; i++)
                    {
                        value[i] = rdr[i].ToString();
                    }
                    adminView.Rows.Add(value);
                }
                rdr.Close();
            }
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

        private void pos_Click(object sender, EventArgs e)
        {

            Random randomObj = new Random();
            int key = randomObj.Next();

            int index = 0;
            while (index < orders.Items.Count)
            {
                int orderCounts = Int32.Parse(ordersCount.Items[index].ToString());
                for (int i = 0; i < orderCounts; i++)
                {
                    setOrder(orders.Items[index].ToString().ToString(), key);
                }
                index++;
            }

            DBmanager.GetInstance().insert("OrderLog(OrderNum, time, isCanceled)", "('" + key + "', '" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "', " + 0 + ")");
            ordersCount.Items.Clear();
            orders.Items.Clear();

        }

        private void setOrder(String menu, int num)
        {
            String price = getPrice(menu);
            String menuId = getMenuId(menu);
            if (price == "") return;
            DBmanager.GetInstance().insert("Orderlist(idUser, idDrink, saleprice, posDate, posTime, OrderNum)", "('" + UserSession.GetInstance().getId() + "'," + menuId + ", " + price + ", '" + currentDate + "', '" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "', '" + num + "')");
        }

        private void menuBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            menu = menuBox.SelectedText;
        }

        private void 유저로그확인ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!UserSession.GetInstance().adminCheck()) return;
            adminView.Rows.Clear();

            String query = "SELECT loginID, time, state FROM s5645120.Userlog;";
            adminView.ColumnCount = 3;
            adminView.Columns[0].Name = "사용자";
            adminView.Columns[1].Name = "시간";
            adminView.Columns[2].Name = "상태";

            using (MySqlConnection connection = new MySqlConnection(QueryBuilder.GetInstance().getConn()))
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader rdr = cmd.ExecuteReader();
                QueryBuilder.GetInstance().clearQ();
                String[] value = new String[adminView.ColumnCount];
                while (rdr.Read())
                {
                    for (int i = 0; i < adminView.ColumnCount; i++)
                    {
                        value[i] = rdr[i].ToString();
                    }
                    adminView.Rows.Add(value);
                }
                rdr.Close();
            }
        }

        private void 커피판매품목관리ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!UserSession.GetInstance().adminCheck()) return;
            MenuManageForm setting = new MenuManageForm();
            setting.Show();
        }

        private void add_Click(object sender, EventArgs e)
        {
            if (menuBox.Text == "" || count.Text == "") return;
            orders.Items.Add(menuBox.Text);
            ordersCount.Items.Add(count.Text);
        }

        private void delete_Click(object sender, EventArgs e)
        {
            orders.Items.RemoveAt(orders.SelectedIndex);
            ordersCount.Items.RemoveAt(ordersCount.SelectedIndex);
        }

        private void orders_Click(object sender, EventArgs e)
        {
            ordersCount.SelectedIndex = orders.SelectedIndex;
        }

        private void ordersCount_Click(object sender, EventArgs e)
        {
            orders.SelectedIndex = ordersCount.SelectedIndex;
        }

        private void 주문검ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OrderHistoryForm history = new OrderHistoryForm();
            history.Show();
        }

        private void 수정내역조회ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!UserSession.GetInstance().adminCheck()) return;
            adminView.Rows.Clear();

            String query = "SELECT id, state, AlterLog.before, after, alterDate FROM User, AlterLog WHERE AlterLog.idUser = User.idUser;";
            adminView.ColumnCount = 5;
            adminView.Columns[0].Name = "사용자";
            adminView.Columns[1].Name = "수정분류";
            adminView.Columns[2].Name = "수정 전";
            adminView.Columns[3].Name = "수정 후";
            adminView.Columns[4].Name = "수정 시간";

            using (MySqlConnection connection = new MySqlConnection(QueryBuilder.GetInstance().getConn()))
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader rdr = cmd.ExecuteReader();
                QueryBuilder.GetInstance().clearQ();
                String[] value = new String[adminView.ColumnCount];
                while (rdr.Read())
                {
                    for (int i = 0; i < adminView.ColumnCount; i++)
                    {
                        value[i] = rdr[i].ToString();
                    }
                    adminView.Rows.Add(value);
                }
                rdr.Close();
            }
        }

        private void 패스워드변경ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PasswordUpdateForm pwManager = new PasswordUpdateForm();
            pwManager.Show();
        }
    }
}
