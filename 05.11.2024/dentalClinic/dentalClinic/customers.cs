namespace dentalClinic
{
    public class customers
    {
        private int id {  get; set; }
        private  string _name {  get; set; }
        private string _age { get; set; }
        private string _gender {  get; set; }
        private string _country {  get; set; }
        private string _phone { get; set; }
        public customers(string name,string age,string gender,string country,string phone)
        {
            _name = name;
            _age = age;
            _gender = gender;
            _country = country;
            _phone = phone;
        }
    }
}
