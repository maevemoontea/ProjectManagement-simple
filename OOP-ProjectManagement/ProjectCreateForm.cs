using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using ProjectManagementLibrary;

namespace PMAppGUI
{
    public partial class ProjectCreateForm : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

        public ProjectCreateForm()
        {
            InitializeComponent();
        }

        private void ProjectCreateForm_Load(object sender, EventArgs e)
        {

        }

        private void ButtonCreateProj_Click(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            Project newProject = new Project(true, now);
            //fill all fields
            newProject.ProjectName = TextBoxProjName.Text;
            newProject.Description = TextBoxProjDescr.Text;
            newProject.FinishDate = dateTimePickerFinishProject.Value;

            //generate SQL string
            string name = newProject.ProjectName;
            string description = newProject.Description;
            string activity = newProject.IsActive.ToString();
            string start = newProject.StartDate.ToString();
            string finish = newProject.FinishDate.ToString();

            string SqlText = "INSERT INTO [Projects] ([ProjectName],[Description],[IsActive],[StartDate],[FinishDate]) VALUES ('" + name + "','" + description + "','" + activity + "','" + start + "','" + finish + "') ";

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