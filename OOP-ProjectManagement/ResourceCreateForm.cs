using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using ProjectManagementLibrary;

namespace PMAppGUI
{
    public partial class ResourceCreateForm : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        Resource newResource = new Resource();

        public ResourceCreateForm()
        {
            InitializeComponent();
        }

        private void BtnSetResImg_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                string file = openFileDialog1.FileName;
                newResource.Avatar = file;
            }
        }

        private void ButtonCreateRes_Click(object sender, EventArgs e)
        {
            //fill all fields
            newResource.Name = textBoxSetResName.Text;
            string age = textBoxSetResAge.Text;
            newResource.Age = Convert.ToByte(age);
            newResource.Specialization = comboBoxSetResSpec.Text;
            //newResource.Avatar = "";    
            newResource.PhoneNumber = textBoxSetResPhone.Text;
            newResource.Email = textBoxSetResEmail.Text;

            //generate SQL string
            string name = newResource.Name;
            // string age is already exist
            string specialization = newResource.Specialization;
            string avatar = newResource.Avatar;
            string phoneNumber = newResource.PhoneNumber;
            string email = newResource.Email;

            string SqlText = "INSERT INTO [Resources] ([Name],[Age],[Specialization],[Avatar],[PhoneNumber],[Email]) VALUES ('" + name + "','" + age + "','" + specialization + "','" + avatar + "','" + phoneNumber + "','" + email + "')";
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
