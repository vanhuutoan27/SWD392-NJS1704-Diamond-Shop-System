using AutoMapper;
using BussinessLogic.Automapper;
using BussinessLogic.Services;
using BussinessLogic.Settings;
using Data_Access.Data;
using Data_Access.Repositories;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using PROJECT_SWD.GlobalExceptionHandler;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

// Add CORS policy
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAllOrigins",
        builder =>
        {
            builder.AllowAnyOrigin()
                   .AllowAnyMethod()
                   .AllowAnyHeader();
        });
});

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(option =>
{
    option.SwaggerDoc("v1", new OpenApiInfo { Title = "Demo API", Version = "v1" });
    option.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
    {
        In = ParameterLocation.Header,
        Description = "Please enter a valid token",
        Name = "Authorization",
        Type = SecuritySchemeType.Http,
        BearerFormat = "JWT",
        Scheme = "Bearer"
    });
    option.AddSecurityRequirement(new OpenApiSecurityRequirement
    {
        {
            new OpenApiSecurityScheme
            {
                Reference = new OpenApiReference
                {
                    Type=ReferenceType.SecurityScheme,
                    Id="Bearer"
                }
            },
            new string[]{}
        }
    });
});

builder.Services.AddAutoMapper(typeof(UserProfile));

// Register your services and repositories
builder.Services.AddScoped<UserRepository>();
builder.Services.AddScoped<UserService>();
builder.Services.AddScoped<LoginService>();
builder.Services.AddScoped<LoginRepository>();
builder.Services.AddScoped<RefreshtokenRepository>();
builder.Services.AddScoped<RoleRepository>();
builder.Services.AddScoped<RegistRepository>();
builder.Services.AddScoped<RegisterService>();
builder.Services.AddScoped<RefreshtokenService>();

builder.Services.AddDbContext<ApplicationDbContext>(option =>
{
    var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
    option.UseSqlServer(connectionString);
});

builder.Services.Configure<JwtSettings>(builder.Configuration.GetSection("JwtSettings"));
var key = Encoding.ASCII.GetBytes(builder.Configuration.GetSection("JwtSettings:Key").Value ??
    throw new Exception("JwtSettings:Key is not found"));
var tokenValidationParameter = new TokenValidationParameters()
{
    ValidateIssuer = false,
    ValidateAudience = false,
    ValidateLifetime = true,
    ValidateIssuerSigningKey = true,
    IssuerSigningKey = new SymmetricSecurityKey(key),
    RequireExpirationTime = true,
    ClockSkew = TimeSpan.Zero
};

builder.Services.AddAuthentication(options =>
{
    options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
})
           .AddJwtBearer(jwt =>
           {
               jwt.Events = new JwtBearerEvents
               {
                   OnAuthenticationFailed = async (context) =>
                   {
                       throw new UnauthorizedAccessException("Failed to validate token");
                   }
               };
               jwt.SaveToken = true;
               jwt.TokenValidationParameters = tokenValidationParameter;
           });

builder.Services.AddSingleton(tokenValidationParameter);
builder.Services.AddTransient<UnauthourizeExceptionHandlingMiddleware>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

// Use CORS middleware
app.UseCors("AllowAllOrigins");

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();