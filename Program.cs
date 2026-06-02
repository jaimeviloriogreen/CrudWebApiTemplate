using CrudWebApi.Models;
using CrudWebApi.Dtos;

var builder = WebApplication.CreateBuilder(args);

// Services
builder.Services.AddOpenApi();

var app = builder.Build();

if (app.Environment.IsDevelopment()) {
  app.MapOpenApi();
}
app.UseHttpsRedirection();

var api = app.MapGroup("/api/v1");

// Data
List<Book> books = [
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

// Create one book
api.MapPost("/libro", (CreateBookDto book) => {
  return books;
});

// Read all books
api.MapGet("/libros", () => {
  return books;
});

// Read one book by Id
api.MapGet("/libro/{id}", (int id) => { });

// Read one book by Title or Author
api.MapGet("/libro", (string? title, string? author) => { });

// Delete one book by Id
api.MapDelete("/libro/{id}", (int id) => { });

//Update some fields of a book
api.MapPatch("/libro/{id}", (int id, UpdateBookDto book) => { });

//Update all fields of a book
api.MapPut("/libro/{id}", (int id, PatchBookDto book) => { });

app.Run("http://localhost:3000");

