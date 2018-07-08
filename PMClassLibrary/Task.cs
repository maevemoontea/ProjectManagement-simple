namespace ProjectManagementLibrary
{
    public class Task
    {
        private string name;
        private int relativeProject;
        private int responsible;
        private int accountable;
        private int consulted;
        private string description;
        private byte estimatedTime;
        private byte spendTime;
        private bool isActive;
        private int status;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int RelativeProject
        {
            get { return relativeProject; }
            set { relativeProject = value; }
        }
        public int Responsible
        {
            get { return responsible; }
            set { responsible = value; }
        }
        public int Accountable
        {
            get { return accountable; }
            set { accountable = value; }
        }
        public int Consulted
        {
            get { return consulted; }
            set { consulted = value; }
        }
        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        public byte EstimatedTime
        {
            get { return estimatedTime; }
            set { estimatedTime = value; }
        }
        public byte SpendTime
        {
            get { return spendTime; }
            set { spendTime = value; }
        }
        public bool IsActive
        {
            get { return isActive; }
        }
        public int Status
        {
            get { return status; }
            set { status = value; }
        }

        public Task() { }
    }
}