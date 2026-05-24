namespace CrudWebApi.Dtos;

public record UpdateBookDto {
  public string? Title { get; set; }
  public string? Author { get; set; }
}