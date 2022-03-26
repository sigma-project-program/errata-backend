// using ErrataManager.Models;

// namespace ErrataManager.Data
// {
//     public static class DbInitializer{
//         public static void Initialize(BookContext context){
//             if(context.Books.Any() && context.Errors.Any()){
//                 System.Diagnostics.Debug.WriteLine("Yoooooo");
//                 return; // DB has been seeded
//             }

//             var typoError = new Error{
//                 Name = "Prabhav",
//                 ErrorType = "Typo",
//                 Location = "Page 150",
//                 Description = "The spelling of description is wrong",
//                 Decision = "To be reviewed",
//                 BookId = 1
//             };

//             var calcError = new Error {
//                  Name = "Medhansh",
//                 ErrorType = "Calc error",
//                 Location = "Page 69",
//                 Description = "The calculation for force is wrong",
//                 Decision = "To be reviewed",
//                 BookId = 2
//             };

//             var phyBook = new Book {
//                 Name = "University Physics",
//                 Errors = new List<Error> {
//                     typoError
//                 }
//             };

//             var chemBook = new Book {
//                 Name = "Concept Chemistry",
//                 Errors = new List<Error> {
//                     calcError
//                 }
//             };

//             var books = new List<Book> {phyBook, chemBook};
//             var errors = new List<Error> {typoError, calcError};

//             context.Books.AddRange(books);
//             context.Errors.AddRange(errors);
//             context.SaveChanges();
//         }
//     }
// }