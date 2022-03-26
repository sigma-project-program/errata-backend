namespace ErrataManager.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Book {
    [Key]
    public int Id { get; set; }

    public string? Name { get; set; }

    public List<Error>? Errors { get; set; }
}