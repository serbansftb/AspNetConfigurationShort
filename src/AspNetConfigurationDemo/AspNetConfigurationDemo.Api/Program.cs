using AspNetConfigurationDemo.Api.Services.UserService;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

//Added Configuration Bindings
builder.Services.Configure<UserServiceSettings>(builder.Configuration.GetSection(nameof(UserServiceSettings)));


builder.Services.AddTransient<IUserService, UserService>();
builder.Services.AddControllers();
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

app.UseAuthorization();

app.MapControllers();

app.Run();
