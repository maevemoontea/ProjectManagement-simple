using System;
using System.Windows.Forms;
using ProjectManagementLibrary;
using System.Configuration;
using System.Data.SqlClient;

namespace PMAppGUI
{
    public partial class TaskCreateForm : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        Task newTask = new Task();

        public TaskCreateForm()
        {
            InitializeComponent();
        }

        private void ButtonCreateTask_Click(object sender, EventArgs e)
        {
            //fill all fields
            newTask.Name = textBoxSetTaskName.Text;
            string relativeProject = comboBoxProject.SelectedValue.ToString();
            newTask.RelativeProject = Convert.ToInt16(relativeProject);
            string responsibleId = comboBoxResponsible.SelectedValue.ToString();
            newTask.Responsible = Convert.ToInt16(responsibleId);
            string accountableId = comboBoxAccountable.SelectedValue.ToString();
            newTask.Accountable = Convert.ToInt16(accountableId);
            string consultedId = comboBoxConsulted.SelectedValue.ToString();
            newTask.Consulted = Convert.ToInt16(consultedId);
            newTask.Description = textBoxDescription.Text;
            string timeValue = textBoxEstimated.Text;
            newTask.EstimatedTime = Convert.ToByte(timeValue);
            newTask.Status = 1;

            //generate SQL string
            string name = newTask.Name;
            string accountable = accountableId;
            string responsible = responsibleId;
            string consulted = consultedId;
            string description = newTask.Description;
            string estimatedTime = timeValue;
            string spendTime = "0";
            string status = newTask.Status.ToString();
            string isActive = "1";

            string SqlText = "INSERT INTO [Tasks] ([TaskName],[Accountable],[Responsible],[Consulted],[TaskDescription],[EstimatedTime],[SpendTime],[Status],[IsActive]) VALUES ('" + name + "','" + accountable + "','" + responsible + "','" + consulted + "','" + description + "','" + estimatedTime + "','" + spendTime + "','" + status + "','" + isActive + "')";
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

        private void TaskCreateForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pMDatabaseConsultedDataSet.Resources' table. You can move, or remove it, as needed.
            this.resourcesTableAdapter2.Fill(this.pMDatabaseConsultedDataSet.Resources);
            // TODO: This line of code loads data into the 'pMDatabaseResponsibleDataSet.Resources' table. You can move, or remove it, as needed.
            this.resourcesTableAdapter1.Fill(this.pMDatabaseResponsibleDataSet.Resources);
            // TODO: This line of code loads data into the 'pMDatabaseAccountableDataSet.Resources' table. You can move, or remove it, as needed.
            this.resourcesTableAdapter.Fill(this.pMDatabaseAccountableDataSet.Resources);
            // TODO: This line of code loads data into the 'pMDatabaseProjectsDataSet.Projects' table. You can move, or remove it, as needed.
            this.projectsTableAdapter.Fill(this.pMDatabaseProjectsDataSet.Projects);

        }
    }
}