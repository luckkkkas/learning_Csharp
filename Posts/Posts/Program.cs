// See https://aka.ms/new-console-template for more informatio

using Posts.Entities;

DateTime date = DateTime.UtcNow;

Post post = new Post(date, "traveling to New Zeland", "I'm going to visit wonderful contry!", 12);

post.AddComment("Have a nice trip!");
post.AddComment("Wow that's awesome!");

Post post2 = new Post(date, "Good night guys", "See you tomorow", 5);

post2.AddComment("good night");
post2.AddComment("May the Force be with you");

Console.WriteLine(post.Title);
Console.WriteLine(post.Likes+ "- " +  post.Moment);
Console.WriteLine("Comments:");

foreach (Comments comment in post.Comentarios) {
    Console.WriteLine(comment.Text.ToString());
}
Console.WriteLine("-------------------------------");
Console.WriteLine(post2.Title);
Console.WriteLine(post2.Likes + "- " + post2.Moment);
Console.WriteLine("Comments:");

foreach (Comments element in post2.Comentarios) {
    Console.WriteLine(element.Text);
}