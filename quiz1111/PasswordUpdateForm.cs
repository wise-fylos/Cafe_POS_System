using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace quiz1111
{
    public partial class PasswordUpdateForm : Form
    {
        public PasswordUpdateForm()
        {
            InitializeComponent();
        }

        private void pwUpdate_Click(object sender, EventArgs e)
        {
            Regex regex = new Regex(@"^(?=.*?[A-Z])(?=.*?[0-9])(?=.*?[`~!@#$%^&*()-_=+\[\]\\{};:'"",.<>/|]).{8,}$");
            if (regex.IsMatch(pwBox.Text))
            {
                updatePW();
                MessageBox.Show("비밀번호 변경 완료.");
            }
            else
            {
                MessageBox.Show("유효하지 않은 비밀번호입니다. 다시 입력해주세요.");
            }
        }

        private void updatePW()
        {
            String query = "UPDATE User SET pw = '" + pwBox.Text + "' WHERE (idUser = '" + UserSession.GetInstance().getId() + "')";
            using (MySqlConnection connection = new MySqlConnection(QueryBuilder.GetInstance().getConn()))
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader rdr = cmd.ExecuteReader();
                rdr.Close();
                connection.Close();
            }
        }
    }
}
