var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

var summaries = new[]
{
    "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
};



app.MapGet("/api/Movies", () =>
{
    List<Movie> listFilm = new List<Movie> {
        new Movie("The Shawshank Redemption", "Frank Darabont", new List<string>{"Tim Robbins", "Morgan Freeman"}, "Tied for the best movie I have ever seen"),
        new Movie("The Godfather", "Francis Ford Coppola", new List<string>{"Marlon Brando", "Al Pacino"}, "An offer so good, I couldn't refuse"),
        new Movie("The Dark Knight", "Christopher Nolan", new List<string>{"Christian Bale", "Heath Ledger"}, "The Batman of our dreams! So much more than a comic book movie")
    };
    /*Movie film1 = new Movie   (
           "Tintin",
           "Herge",
           new List<string>(),
           "FILM YANG MANTAP"
       );
    Movie film2 = new Movie(
           "Naruto",
           "Nasashi",
           new List<string>(),
           "EPIC BATTLE"
       );
    Movie film3 = new Movie(
           "Conan",
           "Aoyama",
           new List<string>(),
           "GAK GEDE GEDE"
       );
    listFilm.Add(film1);
    listFilm.Add(film2);
    listFilm.Add(film3);*/
    return listFilm;
})
.WithName("GetMovies");

app.MapPost("/api/Movies", () =>
{
    
})
.WithName("PostMovies");

app.MapGet("/api/Movies/{id}", () =>
{
    
})
.WithName("GetMoviesID");
app.MapDelete("/api/Movies/{id}", () =>
{

})
.WithName("DeleteMoviesID");

/*app.MapGet("/test", () => "HELLO WORLD")
.WithName("TestAja");*/

app.Run();



internal record Movie(string Title, string Director, List<string> Stars, string Description)
{

}