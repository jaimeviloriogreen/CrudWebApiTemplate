namespace CrudWebApi.dto;

public record BookDto {
  public int Id { get; set; }
  public string? Title { get; set; }
  public string? Author { get; set; }
}