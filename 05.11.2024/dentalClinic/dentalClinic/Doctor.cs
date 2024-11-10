namespace dentalClinic
{
    public class Doctor
    {
        private  string _name{  get; set; }
        private string _description{  get; set; }
        private int _id{  get; set; }
        public Doctor(string name, string description, int id)
        {
            _name = name;
            _description = description;
            _id = id;
        }

    }
}
