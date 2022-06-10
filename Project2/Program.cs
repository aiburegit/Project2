using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Project2.Data;
using Project2.Data.DataEntities;
using Project2.Data.Repository;
using System.Text.Json.Serialization;
using static Project2.Controllers.AccountController;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllersWithViews();
builder.Services.AddCors();
builder.Services.AddMvc();
builder.Services.AddHttpClient();
builder.Services.AddDbContext<DataBaseContext>(options => { options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));});
builder.Services.AddTransient<IRepository<Category>, ImplementRepository<Category>>();

builder.Services.AddControllers()
                .AddJsonOptions(o =>
                {
                    { o.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.Preserve; }
                });
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)  // добавление сервисов аутентификации
    .AddJwtBearer(options =>
    {
        options.RequireHttpsMetadata = false;
        options.TokenValidationParameters = new TokenValidationParameters
        {
            // укзывает, будет ли валидироваться издатель при валидации токена
            ValidateIssuer = true,
            // строка, представляющая издателя
            ValidIssuer = AuthOptions.ISSUER,

            // будет ли валидироваться потребитель токена
            ValidateAudience = true,
            // установка потребителя токена
            ValidAudience = AuthOptions.AUDIENCE,
            // будет ли валидироваться время существования
            ValidateLifetime = true,

            // установка ключа безопасности
            IssuerSigningKey = AuthOptions.GetSymmetricSecurityKey(),
            // валидация ключа безопасности
            ValidateIssuerSigningKey = true,
        };
    });     // подключение аутентификации с помощью jwt-токенов
builder.Services.AddAuthorization();
var app = builder.Build();


// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseAuthentication();
app.UseAuthorization();
app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();


app.MapControllerRoute(
    name: "default",
    pattern: "{controller}/{action=Index}/{id?}");

app.MapFallbackToFile("index.html"); ;

app.Run();
