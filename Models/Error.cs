namespace ErrataManager.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Error {
    [Key]
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? ErrorType { get; set; }

    public string? Location { get; set; }

    public string? Description { get; set; }

    
    public int BookId { get; set; }

    [ForeignKey("BookId")]
    public Book? Book { get; set; }

    public string? Decision { get; set; }
}