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
    public IEnumerable<Book> GetAll(){
        return _context.Books
            .ToList();
    }

    // Get book by ID
    public Book? GetById(int id){
        return _context.Books
            // .Include(p => p.Name)
            // .AsNoTracking()
            // .Include(p => p.Errors)
            .SingleOrDefault(p => p.Id == id);
    }

    // POST book
    public Book? Create(Book newBook){
        _context.Books.Add(newBook);
        var errors = newBook.Errors;
        if(errors is not null){
            _context.Errors.AddRange(errors);
        }
       
        _context.SaveChanges();
        return newBook;
        
    }


    // Delete a Book
    public void Deletebook(int BookId){
        var bookToDelete = _context.Books.Find(BookId);

        if(bookToDelete is null){
            throw new NullReferenceException("Book not found!");
        }

        // var ErrorList = from st in _context.Errors
        //                 where st.BookId == BookId
        //                 select st;

        _context.Books.Remove(bookToDelete);
        // if(ErrorList is not null){
        //     _context.Errors.RemoveRange(ErrorList);
        // }
        _context.SaveChanges();
    }

}