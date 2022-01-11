using BlogPostDataNotation;
using BlogPostDataNotation.Models;

using (var ctx = new Context())
{
    //tramite la variabile ctx richiamo il metodo ens.. che crea un db se non esiste
    ctx.Database.EnsureCreated();


    Blog blog1 = new Blog()
    {
        Name = "myBlog",
        Author = "Giada",
       BlogUrl="www.giada.it"
    };
    var blog2 = new Blog()
    {
        Name = "myBlog2",
        Author = "Chiara Ferragni",
        BlogUrl="www.chiaraferragni.it"
    };

    //questi sono oggetti e li devo aggiungere

    ctx.Blogs.Add(blog1);
    ctx.Blogs.Add(blog2);
    ctx.SaveChanges();

    Console.WriteLine("Tutti i blog:");
    foreach (var item in ctx.Blogs)
    {
        Console.WriteLine(item);
    }
}
