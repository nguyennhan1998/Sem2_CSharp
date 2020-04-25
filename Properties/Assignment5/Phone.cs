namespace AP.Properties.Assignment5
{
    public abstract class Phone
    {
        public abstract void InsertPhone(string name, string phone);
        public abstract void RemovePhone(string name);
        public abstract void UpdatePhone(string name, string newPhone);
        public abstract PhoneNumber searchPhone(string name);
        
    }
}