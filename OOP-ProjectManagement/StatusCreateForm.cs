using System;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;
using ProjectManagementLibrary;

namespace PMAppGUI
{
    public partial class StatusCreateForm : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        Status newStatus = new Status();

        public StatusCreateForm()
        {
            InitializeComponent();
        }

        private void ButtonSetColor_Click(object sender, EventArgs e)
        {
            ColorDialog TaskColor = new ColorDialog();
            if (TaskColor.ShowDialog() == DialogResult.OK)
            {
                buttonSetColor.BackColor = TaskColor.Color;
            }
        }

        private void ButtonCreateStatus_Click(object sender, EventArgs e)
        {
            //fill all fields
            newStatus.Name = textBoxSetStatusName.Text;
            newStatus.Order = numericOrder.Value;
            newStatus.Color = buttonSetColor.BackColor.ToArgb();

            //generate SQL string
            string name = newStatus.Name;
            string order = newStatus.Order.ToString();
            string color = newStatus.Color.ToString();

            string SqlText = "INSERT INTO [Statuses] ([StatusName],[StyleColor],[Order]) VALUES ('" + name + "','" + color + "','" + order + "')";
            SqlConnection connection; // экземпляр класса типа SqlConnection
            SqlCommand command;

            // выделение памяти с инициализацией строкой соединения с базой данных
            connection = new SqlConnection(connectionString);
            connection.Open(); // открыть источник данных

            // задать SQL-команду
            command = connection.CreateCommand();
            command.CommandText = SqlText; // задать командную строку
            command.ExecuteNonQuery();
            connection.Close();

            //close the window
            this.Close();
        }
    }
}
