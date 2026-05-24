namespace CrudWebApi.Dtos;

public record PatchBookDto {
  public string? Title { get; set; }
  public string? Author { get; set; }
}