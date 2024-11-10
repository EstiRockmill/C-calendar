using Microsoft.VisualBasic;

namespace dentalClinic
{
    public class turn
    {
        public int id {  get; set; }
        public string name {  get; set; }
        public string description {  get; set; }
        private DateAndTime DateAndTime {  get; set; }
        public turn(string name,string description,DateAndTime DateAndTime)
        {
            id = 0;
            this.name=name;
            this.description=description;
            this.DateAndTime = DateAndTime;
        }
    }
}
