using EFDemo;
using EFDemo.Models;

//creo un oggetto della classe context che chiamo ctx. 
using (var ctx = new Context())
{
    //tramite la variabile ctx richiamo il metodo ens.. che crea un db se non esiste
    ctx.Database.EnsureCreated();


    //Blog blog1 = new Blog()
    //{
    //    Name = "myBlog",
    //    Author = "Giada",
    //    //BlogId = 1
    //};
    //var blog2 = new Blog()
    //{
    //    Name = "myBlog2",
    //    Author = "Chiara Ferragni",
    //    //BlogId = 2
    //};

    ////questi sono oggetti e li devo aggiungere

    //ctx.Blogs.Add(blog1);
    //ctx.Blogs.Add(blog2);
    //ctx.SaveChanges();

    Console.WriteLine("Tutti i blog:");
    foreach(var item in ctx.Blogs)
    {
        Console.WriteLine(item);    
    }

    //RECUPERO DATI
    //collegati al db, prendi le tab blogs e prendimi quelli il cui autore contiene ferragni
    var blogFerragni = ctx.Blogs.Where(b => b.Author.Contains("Ferragni"));
    Console.WriteLine("I blogs della ferragni sono:");
    foreach(var item in blogFerragni)
    {
        Console.WriteLine(item);
    }


    var myBlog = ctx.Blogs.Find(1);
    var post = AddPost(myBlog);
    ctx.Posts.Add(post);
    ctx.SaveChanges();
    
}
 static Post AddPost(Blog selectBlog)
{
    Post post = new Post()
    {
        Text = "New post per il mio blog",
    Date = DateTime.Now,
    Blog= selectBlog

    };
return post;
}