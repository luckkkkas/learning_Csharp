using Posts.Entities;

namespace Posts.Entities {
    internal class Post {

        public DateTime Moment { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int Likes { get; set; }
        public List<Comments> Comentarios { get; set; } = new List<Comments>();

        public Post(DateTime moment, string title, string content, int likes) {
            Moment = moment;
            Title = title;
            Content = content;
            Likes = likes;
            this.Comentarios = Comentarios;
        }  

        public void AddComment(string comment) {
           
            Comentarios.Add(new Comments(comment));
        }
    }
}
