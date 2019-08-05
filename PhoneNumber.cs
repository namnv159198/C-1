namespace T1809E_CSharp
{
    public class PhoneNumber
    {
        private string phone;
        private string name;

        public PhoneNumber()
        {
            
        }
        public PhoneNumber(string name, string phone)
        {
            this.phone = phone;
            this.name = name;
        }

        

        public string Phone
        {
            get => phone;
            set => phone = value;
        }

        public string Name
        {
            get => name;
            set => name = value;
        }
    }
}