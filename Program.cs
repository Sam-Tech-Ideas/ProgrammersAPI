using Microsoft.Win32;
using System.Runtime.Intrinsics.X86;
using Microsoft.EntityFrameworkCore;
using Microsoft.Data.Sqlite;
using System.ComponentModel.Design;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//setting cors headers
builder.Services.AddCors(options => {
    options.AddPolicy("AllowAll", a => a.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin());
});

var dbPath = Path.Join("./programmer.db");

var conn = new SqliteConnection($"Data Source=[dbPath]");

builder.Services.AddDbContext<ProgrammerDbContext>(opt => opt.UseSqlite(conn));



var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseCors("AllowAll");












//Retrieving list of programmers
app.MapGet("/programmer", async (ProgrammerDbContext db) =>
await db.Programmers.ToListAsync()

);

// Retrieving a single programmer
app.MapGet("/programmer/{id}" , async (ProgrammerDbContext db, int id) =>
await db.Programmers.FindAsync(id)

is Programmer programmer ?
Results.Ok(programmer) :
Results.NotFound()

);


// Updating Programmer Data

app.MapPut("/programmer/{id}", async (int id, Programmer programmer, ProgrammerDbContext db) =>
{
   var record = await db.Programmers.FindAsync(id);
   if (record is null) return Results.NotFound();
   record.FullName = programmer.FullName;
    record.CodeName = programmer.CodeName;
    record.ExperienceYrs = programmer.ExperienceYrs;
    record.MobileDev = programmer.MobileDev;
    record.PortfolioUrl = programmer.PortfolioUrl;
    await db.SaveChangesAsync();
    return Results.NoContent();
});



// Deleting a Programmer
app.MapDelete("/programmer/{id}", async (int id,ProgrammerDbContext db) =>
{
   var record = await db.Programmers.FindAsync(id);
   if (record is null) return Results.NotFound();
    await db.SaveChangesAsync();
    return Results.NoContent();
});


// Creating a Programmer

app.MapPost("/programmer", async (Programmer programmer, ProgrammerDbContext db) =>
{
    db.Add(programmer);
    await db.SaveChangesAsync();

    return Results.Created($"/programmer/{programmer.Id}", programmer);
});


app.Run();

