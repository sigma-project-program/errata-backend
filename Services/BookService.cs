using ErrataManager.Models;
using ErrataManager.Data;
using Microsoft.EntityFrameworkCore;

namespace ErrataManager.Services;

public class BookService{

    private readonly BookContext _context;
    public BookService(BookContext context){
        _context = context;
    }

    // CRUD operations

    // Get all books
    public async Task<IEnumerable<Book>> GetAll(){
        return await Task.FromResult(_context.Books
            .AsNoTracking()
            .ToList());
    }

    // Get book by ID
    public async Task<Book?> GetById(int id){
        return await Task.FromResult(_context.Books
            .Include(p => p.Name)
            .AsNoTracking()
            .SingleOrDefault(p => p.Id == id));
    }

    // POST book
    public async Task<Book?> Create(Book newBook){
        await Task.FromResult(_context.Books.Add(newBook));
        _context.SaveChanges();

        return newBook;
    }


    // Delete a Book
    public async void Deletebook(int BookId){
        var bookToDelete = await Task.FromResult(_context.Books.Find(BookId));

        if(bookToDelete is null){
            throw new NullReferenceException("Book not found!");
        }

        var ErrorList = bookToDelete.Errors;

        await Task.FromResult(_context.Books.Remove(bookToDelete));
        if(ErrorList is not null){
            _context.Errors.RemoveRange(ErrorList);
        }
        _context.SaveChanges();
    }

}