using System.Security.AccessControl;

namespace DevPortfolio.Models.Entety
{
    public class AboutMe
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Name { get; set; }
       
        

        public AboutMe(int id, string title, string name)
        {
            Id = id;
            Title = title;
            Name = name;
        }
    }
}