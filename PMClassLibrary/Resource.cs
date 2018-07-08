namespace ProjectManagementLibrary
{
    public class Resource
    {
        private string name;
        private byte age;
        private string specialization;
        private string avatar;
        private string phoneNumber;
        private string email;
        private int nowWorkingOn;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public byte Age
        {
            get { return age; }
            set { age = value; }
        }
        public string Specialization
        {
            get { return specialization; }
            set { specialization = value; }
        }
        public string Avatar
        {
            get { return avatar; }
            set
            {
                //добавить валидацию: проверка, существует ли файл, а по максимуму добавит конвертацию
                avatar = value;
            }
        }
        public string PhoneNumber
        {
            get { return phoneNumber; }
            set
            {
                //добавить валидацию
                phoneNumber = value;
            }
        }
        public string Email
        {
            get { return email; }
            set
            {
                //добавить валидацию
                email = value;
            }
        }
        public int NowWorkingOn
        {
            get { return nowWorkingOn; }
            set
            {
                //добавить проверку на то, занят ли кто на данном таске
                nowWorkingOn = value;
            }
        }
        public Resource() { }
    }
}