namespace Job_Manager.Models
{
    public class Job
    {
        public string id { get; set; }

        public string text { get; set; }

        public string date { get; set; }

        public bool reminder { get; set; }

        public Job()
        {
            
        }
    }
}
