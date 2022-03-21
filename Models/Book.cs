namespace ErrataManager.Models;

public class Book {
    public int Id { get; set; }

    public string? Name { get; set; }

    public ICollection<Error>? Errors { get; set; }
}