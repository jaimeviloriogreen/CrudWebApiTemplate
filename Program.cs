using CrudWebApi.dto;

var builder = WebApplication.CreateBuilder(args);

// Services
builder.Services.AddOpenApi();

var app = builder.Build();

if (app.Environment.IsDevelopment()) {
  app.MapOpenApi();
}
app.UseHttpsRedirection();

// Data
List<BookDto> books = [
  new(){
    Id = 1,
    Title = "El mundo de sofía",
    Author = "Jostein Gaarder"
  },
  new(){
    Id = 2,
    Title = "Un mundo feliz",
    Author = "Aldous Huxley"
  },
  new(){
    Id = 3,
    Title = "1984",
    Author = "George Orwell"
  },
];

// ===  Web api Crud === 

// Read all books
app.MapGet("/libros", () => { });

// Read one book by Id
app.MapGet("/libro/{id}", (int id) => { });

// Read one book by Title or Author
app.MapGet("/libro", (string? title, string? author) => { });

// Delete one book by Id
app.MapDelete("/libro/{id}", (int id) => { });

//Update all fields of a book
app.MapPut("/libro/{id}", (int id, BookDto book) => { });

//Update some fields of a book
app.MapPatch("/libro/{id}", (int id, BookDto book) => { });

app.Run();

