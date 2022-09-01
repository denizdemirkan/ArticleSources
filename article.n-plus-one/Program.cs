using article.n_plus_one.DbContexts;
using Microsoft.EntityFrameworkCore;

Problem();
//SolveWithEager();
//SolveWithJoin();

static void Problem()
{
    using (var context = new AppDbContext())
    {
        var authors = context.Authors.ToList();

        foreach (var author in authors)
        {
            context.Entry(author).Collection(a => a.Books).Load();

            var books = author.Books.ToList();

            foreach (var book in books)
            {
                Console.WriteLine(book.BookName);
            }
        }
    }
}

static void SolveWithEager()
{
    using (var context = new AppDbContext())
    {

        var authors = context.Authors.ToList();
        var books = context.Books.ToList();

        foreach (var author in authors)
        {
            foreach (var book in books)
            {
                Console.WriteLine(book.BookName);
            }
        }

    }
}

static void SolveWithJoin()
{
    using (var context = new AppDbContext())
    {

        var authors = context.Authors.Include(x => x.Books).ToList();

        foreach (var author in authors)
        {
            foreach (var book in author.Books)
            {
                Console.WriteLine(book.BookName);
            }
        }

    }
}