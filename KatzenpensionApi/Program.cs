using KatzenpensionApi.Data;
using KatzenpensionApi.Dev;
using KatzenpensionApi.Repositories.Booking;
using KatzenpensionApi.Repositories.Comment;
using KatzenpensionApi.Repositories.RegularGuest;
using KatzenpensionApi.Repositories.Room;
using KatzenpensionApi.Services.BookingService;
using KatzenpensionApi.Services.CommentService;
using KatzenpensionApi.Services.RegularGuestService;
using KatzenpensionApi.Services.RoomService;
using KatzenpensionApi.Services.SaveDbService;
using Microsoft.EntityFrameworkCore;
using Scalar.AspNetCore;

//CORS
var MyAllowSpecificOrigins = "_myAllowSpecificOrigins";

var builder = WebApplication.CreateBuilder(args);

//CORS
builder.Services.AddCors(options =>
{
    options.AddPolicy(name: MyAllowSpecificOrigins,
                      policy =>
                      {
                          /*   
                           *   ANGULAR: */
                          policy.WithOrigins("http://localhost:4200",
                                                 "https://localhost:4200").AllowAnyMethod().AllowAnyHeader();
                          

                          /*
                           REACT:
                           
                          policy.WithOrigins("http://localhost:3000",
                                             "https://localhost:3000");
                          */
                      });
});


// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();
builder.Services.AddScoped<IRegularGuestService, RegularGuestService>();
builder.Services.AddScoped<IRegularGuestRepository, RegularGuestRepository>();
builder.Services.AddScoped<IRoomService, RoomService>();
builder.Services.AddScoped<IRoomRepository, RoomRepository>();
builder.Services.AddScoped<ICommentService, CommentService>();
builder.Services.AddScoped<ICommentRepository, CommentRepository>();
builder.Services.AddScoped<IBookingService, BookingService>();
builder.Services.AddScoped<IBookingRepository, BookingRepository>();
builder.Services.AddScoped<ISaveDbService, SaveDbService>();

var connString = "Data Source =Katzenpension.db";
builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlite(connString));

var app = builder.Build();

//seeding DB
using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    try
    {
        var context = services.GetRequiredService<AppDbContext>();
        DbSeeds.Initialize(context);
    }
    catch (Exception e)
    {
        var logger = services.GetRequiredService<ILogger<Program>>();
        logger.LogError(e, "Error seeding DB");
    }
}

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.MapScalarApiReference();
}

app.UseHttpsRedirection();

//CORS
app.UseCors(MyAllowSpecificOrigins);

app.UseAuthorization();

app.MapControllers();

app.Run();

