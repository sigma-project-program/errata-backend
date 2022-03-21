using Microsoft.EntityFrameworkCore;
using ErrataManager.Models;

namespace ErrataManager.Data;

public class BookContext : DbContext
{
    public BookContext (DbContextOptions<BookContext> options): base(options){
        
    }

    public DbSet<Book> Books => Set<Book> ();
    public DbSet<Error> Errors => Set<Error> ();
}