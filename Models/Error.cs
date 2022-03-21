namespace ErrataManager.Models;

public class Error {
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? ErrorType { get; set; }

    public string? Location { get; set; }

    public string? Description { get; set; }

    public int? BookId { get; set; }

    public string? Decision { get; set; }
}