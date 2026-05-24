namespace CrudWebApi.Dtos;

public record CreateBookDto {
  public string Title { get; set; } = "";
  public string Author { get; set; } = "";
}