using System;
using System.Windows.Forms;
using ProjectManagementLibrary;

namespace PMAppGUI
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {

        }

        private void ButtonCreateProject_Click(object sender, EventArgs e)
        {
            ProjectCreateForm newProjectForm = new ProjectCreateForm();
            newProjectForm.Show();
        }

        private void ButtonAddTask_Click(object sender, EventArgs e)
        {
            TaskCreateForm newTask = new TaskCreateForm();
            newTask.Show();
        }

        private void ButtonAddResource_Click(object sender, EventArgs e)
        {
            ResourceCreateForm newResource = new ResourceCreateForm();
            newResource.Show();
        }

        private void ButtonManageStatuses_Click(object sender, EventArgs e)
        {
            StatusCreateForm newStatus = new StatusCreateForm();
            newStatus.Show();
        }
    }
}