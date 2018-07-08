namespace ProjectManagementLibrary
{
    public class Status
    {
        private string name;
        private decimal order;
        private int color;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public decimal Order
        {
            get { return order; }
            set { order = value; }
        }

        public int Color
        {
            get { return color; }
            set { color = value; }
        }

        public Status() { }
    }
}