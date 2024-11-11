var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddSwaggerGen();
builder.Services.AddControllers();

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowDevelopmentOrigin", policy =>
    {
        policy
            .WithOrigins("http://localhost:3000") // Frontend URL 
            .AllowAnyMethod() 
            .AllowAnyHeader();
    });

});

var app = builder.Build();
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    app.UseCors("AllowDevelopmentOrigin");
}

app.UseHttpsRedirection();

app.MapControllers();
app.Run();
