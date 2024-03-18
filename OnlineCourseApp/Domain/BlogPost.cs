namespace Domain
{
    public class BlogPost
    {
        public Guid id { get; set; }
        public string title { get; set; }
        public string description { get; set; }


        public BlogPost(Guid _id, string _title, string _description)
        {

            id = _id;
            title = _title;
            description = _description;

        }
    }
}
