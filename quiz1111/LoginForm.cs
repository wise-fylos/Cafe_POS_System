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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void login_Click(object sender, EventArgs e)
        {
            String query = QueryBuilder.GetInstance().select("idUser, admin").from("s5645120.User").where("id = '" + idBox.Text + "'and pw = '" + pwBox.Text + "'; ").getQ();

            using (MySqlConnection connection = new MySqlConnection(QueryBuilder.GetInstance().getConn()))
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader rdr = cmd.ExecuteReader();
                QueryBuilder.GetInstance().clearQ();
                if (!rdr.Read())
                {
                    return;
                }
                rdr.Read();
                UserSession.GetInstance().setId(rdr[0].ToString());
                UserSession.GetInstance().setIdString(idBox.Text);
                if (rdr[1].ToString() == "1")
                {
                    UserSession.GetInstance().setAdmin();
                }
                rdr.Close();
            }
            loginLog();
            DashboardForm main = new DashboardForm();
            main.Show();
            this.Hide();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
 
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
        }

        public void loginLog()
        {
            DBmanager.GetInstance().insert("Userlog(loginID, time, state)", "('" + UserSession.GetInstance().getIdString() + "', '" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "', 'login')");
        }
    }
}
