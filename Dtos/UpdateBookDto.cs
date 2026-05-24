namespace CrudWebApi.Dtos;

public record UpdateBookDto {
  public required string Title { get; set; }
  public required string Author { get; set; }
}