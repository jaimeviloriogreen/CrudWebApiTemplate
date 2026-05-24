namespace CrudWebApi.Dtos;

public record CreateBookDto {
  public required string Title { get; set; }
  public required string Author { get; set; }
}