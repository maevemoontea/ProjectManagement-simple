namespace PMAppGUI
{
    partial class TaskCreateForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.headingCreateTask = new System.Windows.Forms.Label();
            this.buttonCreateTask = new System.Windows.Forms.Button();
            this.labelSetTaskName = new System.Windows.Forms.Label();
            this.textBoxSetTaskName = new System.Windows.Forms.TextBox();
            this.lableProjectName = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.textBoxDescription = new System.Windows.Forms.RichTextBox();
            this.Responsible = new System.Windows.Forms.Label();
            this.Accountable = new System.Windows.Forms.Label();
            this.Consalted = new System.Windows.Forms.Label();
            this.comboBoxAccountable = new System.Windows.Forms.ComboBox();
            this.comboBoxResponsible = new System.Windows.Forms.ComboBox();
            this.comboBoxConsulted = new System.Windows.Forms.ComboBox();
            this.estimatedTime = new System.Windows.Forms.Label();
            this.textBoxEstimated = new System.Windows.Forms.TextBox();
            this.comboBoxProject = new System.Windows.Forms.ComboBox();
            this.pMDatabaseProjectsDataSet = new OOP_ProjectManagement.PMDatabaseProjectsDataSet();
            this.projectsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projectsTableAdapter = new OOP_ProjectManagement.PMDatabaseProjectsDataSetTableAdapters.ProjectsTableAdapter();
            this.pMDatabaseAccountableDataSet = new OOP_ProjectManagement.PMDatabaseAccountableDataSet();
            this.resourcesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.resourcesTableAdapter = new OOP_ProjectManagement.PMDatabaseAccountableDataSetTableAdapters.ResourcesTableAdapter();
            this.pMDatabaseResponsibleDataSet = new OOP_ProjectManagement.PMDatabaseResponsibleDataSet();
            this.resourcesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.resourcesTableAdapter1 = new OOP_ProjectManagement.PMDatabaseResponsibleDataSetTableAdapters.ResourcesTableAdapter();
            this.pMDatabaseConsultedDataSet = new OOP_ProjectManagement.PMDatabaseConsultedDataSet();
            this.resourcesBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.resourcesTableAdapter2 = new OOP_ProjectManagement.PMDatabaseConsultedDataSetTableAdapters.ResourcesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pMDatabaseProjectsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pMDatabaseAccountableDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resourcesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pMDatabaseResponsibleDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resourcesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pMDatabaseConsultedDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resourcesBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // headingCreateTask
            // 
            this.headingCreateTask.AutoSize = true;
            this.headingCreateTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headingCreateTask.Location = new System.Drawing.Point(17, 18);
            this.headingCreateTask.Name = "headingCreateTask";
            this.headingCreateTask.Size = new System.Drawing.Size(94, 24);
            this.headingCreateTask.TabIndex = 4;
            this.headingCreateTask.Text = "New task";
            // 
            // buttonCreateTask
            // 
            this.buttonCreateTask.Location = new System.Drawing.Point(100, 428);
            this.buttonCreateTask.Name = "buttonCreateTask";
            this.buttonCreateTask.Size = new System.Drawing.Size(175, 37);
            this.buttonCreateTask.TabIndex = 7;
            this.buttonCreateTask.Text = "Create";
            this.buttonCreateTask.UseVisualStyleBackColor = true;
            this.buttonCreateTask.Click += new System.EventHandler(this.ButtonCreateTask_Click);
            // 
            // labelSetTaskName
            // 
            this.labelSetTaskName.AutoSize = true;
            this.labelSetTaskName.Location = new System.Drawing.Point(18, 85);
            this.labelSetTaskName.Name = "labelSetTaskName";
            this.labelSetTaskName.Size = new System.Drawing.Size(63, 13);
            this.labelSetTaskName.TabIndex = 6;
            this.labelSetTaskName.Text = "What to do:";
            // 
            // textBoxSetTaskName
            // 
            this.textBoxSetTaskName.Location = new System.Drawing.Point(115, 82);
            this.textBoxSetTaskName.Name = "textBoxSetTaskName";
            this.textBoxSetTaskName.Size = new System.Drawing.Size(227, 20);
            this.textBoxSetTaskName.TabIndex = 5;
            // 
            // lableProjectName
            // 
            this.lableProjectName.AutoSize = true;
            this.lableProjectName.Location = new System.Drawing.Point(18, 57);
            this.lableProjectName.Name = "lableProjectName";
            this.lableProjectName.Size = new System.Drawing.Size(43, 13);
            this.lableProjectName.TabIndex = 8;
            this.lableProjectName.Text = "Project:";
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Location = new System.Drawing.Point(18, 116);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(63, 13);
            this.labelDescription.TabIndex = 9;
            this.labelDescription.Text = "Description:";
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(115, 116);
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(227, 87);
            this.textBoxDescription.TabIndex = 10;
            this.textBoxDescription.Text = "";
            // 
            // Responsible
            // 
            this.Responsible.AutoSize = true;
            this.Responsible.Location = new System.Drawing.Point(18, 261);
            this.Responsible.Name = "Responsible";
            this.Responsible.Size = new System.Drawing.Size(68, 13);
            this.Responsible.TabIndex = 11;
            this.Responsible.Text = "Responsible:";
            // 
            // Accountable
            // 
            this.Accountable.AutoSize = true;
            this.Accountable.Location = new System.Drawing.Point(18, 237);
            this.Accountable.Name = "Accountable";
            this.Accountable.Size = new System.Drawing.Size(70, 13);
            this.Accountable.TabIndex = 12;
            this.Accountable.Text = "Accountable:";
            // 
            // Consalted
            // 
            this.Consalted.AutoSize = true;
            this.Consalted.Location = new System.Drawing.Point(18, 287);
            this.Consalted.Name = "Consalted";
            this.Consalted.Size = new System.Drawing.Size(57, 13);
            this.Consalted.TabIndex = 13;
            this.Consalted.Text = "Consulted:";
            // 
            // comboBoxAccountable
            // 
            this.comboBoxAccountable.DataSource = this.resourcesBindingSource;
            this.comboBoxAccountable.DisplayMember = "Name";
            this.comboBoxAccountable.FormattingEnabled = true;
            this.comboBoxAccountable.Location = new System.Drawing.Point(115, 234);
            this.comboBoxAccountable.Name = "comboBoxAccountable";
            this.comboBoxAccountable.Size = new System.Drawing.Size(227, 21);
            this.comboBoxAccountable.TabIndex = 14;
            this.comboBoxAccountable.ValueMember = "Id";
            // 
            // comboBoxResponsible
            // 
            this.comboBoxResponsible.DataSource = this.resourcesBindingSource1;
            this.comboBoxResponsible.DisplayMember = "Name";
            this.comboBoxResponsible.FormattingEnabled = true;
            this.comboBoxResponsible.Location = new System.Drawing.Point(115, 261);
            this.comboBoxResponsible.Name = "comboBoxResponsible";
            this.comboBoxResponsible.Size = new System.Drawing.Size(227, 21);
            this.comboBoxResponsible.TabIndex = 15;
            this.comboBoxResponsible.ValueMember = "Id";
            // 
            // comboBoxConsulted
            // 
            this.comboBoxConsulted.DataSource = this.resourcesBindingSource2;
            this.comboBoxConsulted.DisplayMember = "Name";
            this.comboBoxConsulted.FormattingEnabled = true;
            this.comboBoxConsulted.Location = new System.Drawing.Point(115, 287);
            this.comboBoxConsulted.Name = "comboBoxConsulted";
            this.comboBoxConsulted.Size = new System.Drawing.Size(227, 21);
            this.comboBoxConsulted.TabIndex = 16;
            this.comboBoxConsulted.ValueMember = "Id";
            // 
            // estimatedTime
            // 
            this.estimatedTime.AutoSize = true;
            this.estimatedTime.Location = new System.Drawing.Point(18, 330);
            this.estimatedTime.Name = "estimatedTime";
            this.estimatedTime.Size = new System.Drawing.Size(106, 13);
            this.estimatedTime.TabIndex = 17;
            this.estimatedTime.Text = "Time for task (hours):";
            // 
            // textBoxEstimated
            // 
            this.textBoxEstimated.Location = new System.Drawing.Point(134, 330);
            this.textBoxEstimated.Name = "textBoxEstimated";
            this.textBoxEstimated.Size = new System.Drawing.Size(208, 20);
            this.textBoxEstimated.TabIndex = 18;
            // 
            // comboBoxProject
            // 
            this.comboBoxProject.DataSource = this.projectsBindingSource;
            this.comboBoxProject.DisplayMember = "ProjectName";
            this.comboBoxProject.FormattingEnabled = true;
            this.comboBoxProject.Location = new System.Drawing.Point(115, 57);
            this.comboBoxProject.Name = "comboBoxProject";
            this.comboBoxProject.Size = new System.Drawing.Size(227, 21);
            this.comboBoxProject.TabIndex = 19;
            this.comboBoxProject.ValueMember = "Id";
            // 
            // pMDatabaseProjectsDataSet
            // 
            this.pMDatabaseProjectsDataSet.DataSetName = "PMDatabaseProjectsDataSet";
            this.pMDatabaseProjectsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // projectsBindingSource
            // 
            this.projectsBindingSource.DataMember = "Projects";
            this.projectsBindingSource.DataSource = this.pMDatabaseProjectsDataSet;
            // 
            // projectsTableAdapter
            // 
            this.projectsTableAdapter.ClearBeforeFill = true;
            // 
            // pMDatabaseAccountableDataSet
            // 
            this.pMDatabaseAccountableDataSet.DataSetName = "PMDatabaseAccountableDataSet";
            this.pMDatabaseAccountableDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // resourcesBindingSource
            // 
            this.resourcesBindingSource.DataMember = "Resources";
            this.resourcesBindingSource.DataSource = this.pMDatabaseAccountableDataSet;
            // 
            // resourcesTableAdapter
            // 
            this.resourcesTableAdapter.ClearBeforeFill = true;
            // 
            // pMDatabaseResponsibleDataSet
            // 
            this.pMDatabaseResponsibleDataSet.DataSetName = "PMDatabaseResponsibleDataSet";
            this.pMDatabaseResponsibleDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // resourcesBindingSource1
            // 
            this.resourcesBindingSource1.DataMember = "Resources";
            this.resourcesBindingSource1.DataSource = this.pMDatabaseResponsibleDataSet;
            // 
            // resourcesTableAdapter1
            // 
            this.resourcesTableAdapter1.ClearBeforeFill = true;
            // 
            // pMDatabaseConsultedDataSet
            // 
            this.pMDatabaseConsultedDataSet.DataSetName = "PMDatabaseConsultedDataSet";
            this.pMDatabaseConsultedDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // resourcesBindingSource2
            // 
            this.resourcesBindingSource2.DataMember = "Resources";
            this.resourcesBindingSource2.DataSource = this.pMDatabaseConsultedDataSet;
            // 
            // resourcesTableAdapter2
            // 
            this.resourcesTableAdapter2.ClearBeforeFill = true;
            // 
            // TaskCreateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 482);
            this.Controls.Add(this.comboBoxProject);
            this.Controls.Add(this.textBoxEstimated);
            this.Controls.Add(this.estimatedTime);
            this.Controls.Add(this.comboBoxConsulted);
            this.Controls.Add(this.comboBoxResponsible);
            this.Controls.Add(this.comboBoxAccountable);
            this.Controls.Add(this.Consalted);
            this.Controls.Add(this.Accountable);
            this.Controls.Add(this.Responsible);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.lableProjectName);
            this.Controls.Add(this.buttonCreateTask);
            this.Controls.Add(this.labelSetTaskName);
            this.Controls.Add(this.textBoxSetTaskName);
            this.Controls.Add(this.headingCreateTask);
            this.Name = "TaskCreateForm";
            this.Text = "New task";
            this.Load += new System.EventHandler(this.TaskCreateForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pMDatabaseProjectsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pMDatabaseAccountableDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resourcesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pMDatabaseResponsibleDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resourcesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pMDatabaseConsultedDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resourcesBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCreateTask;
        private System.Windows.Forms.Label labelSetTaskName;
        private System.Windows.Forms.TextBox textBoxSetTaskName;
        private System.Windows.Forms.Label lableProjectName;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.RichTextBox textBoxDescription;
        private System.Windows.Forms.Label Responsible;
        private System.Windows.Forms.Label Accountable;
        private System.Windows.Forms.Label Consalted;
        private System.Windows.Forms.ComboBox comboBoxAccountable;
        private System.Windows.Forms.ComboBox comboBoxResponsible;
        private System.Windows.Forms.ComboBox comboBoxConsulted;
        private System.Windows.Forms.Label estimatedTime;
        private System.Windows.Forms.TextBox textBoxEstimated;
        private System.Windows.Forms.ComboBox comboBoxProject;
        private System.Windows.Forms.Label headingCreateTask;
        private OOP_ProjectManagement.PMDatabaseProjectsDataSet pMDatabaseProjectsDataSet;
        private System.Windows.Forms.BindingSource projectsBindingSource;
        private OOP_ProjectManagement.PMDatabaseProjectsDataSetTableAdapters.ProjectsTableAdapter projectsTableAdapter;
        private OOP_ProjectManagement.PMDatabaseAccountableDataSet pMDatabaseAccountableDataSet;
        private System.Windows.Forms.BindingSource resourcesBindingSource;
        private OOP_ProjectManagement.PMDatabaseAccountableDataSetTableAdapters.ResourcesTableAdapter resourcesTableAdapter;
        private OOP_ProjectManagement.PMDatabaseResponsibleDataSet pMDatabaseResponsibleDataSet;
        private System.Windows.Forms.BindingSource resourcesBindingSource1;
        private OOP_ProjectManagement.PMDatabaseResponsibleDataSetTableAdapters.ResourcesTableAdapter resourcesTableAdapter1;
        private OOP_ProjectManagement.PMDatabaseConsultedDataSet pMDatabaseConsultedDataSet;
        private System.Windows.Forms.BindingSource resourcesBindingSource2;
        private OOP_ProjectManagement.PMDatabaseConsultedDataSetTableAdapters.ResourcesTableAdapter resourcesTableAdapter2;
    }
}