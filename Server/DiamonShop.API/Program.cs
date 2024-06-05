using AutoMapper;
using AutoMapper.Internal;
using DiamonShop.API;
using DiamonShop.API.Extensions;
using DiamonShop.API.GlobalExceptionHandler;
using DiamonShop.API.Mappings;
using DiamonShop.API.Services;
using DiamonShop.Core.ConfigOptions;
using DiamonShop.Core.Domain.Identity;
using DiamonShop.Core.SeedWorks;
using DiamonShop.Core.services;
using DiamonShop.Data;
using DiamonShop.Data.SeedWorks;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var configuration = builder.Configuration;

builder.Services.AddDataServices(configuration);

// ============== add service identity
builder.Services.AddIdentity<AppUser, AppRole>(options => options.SignIn.RequireConfirmedAccount = false)
    .AddEntityFrameworkStores<DiamondContext>();

builder.Services.Configure<IdentityOptions>(options =>
{
    // Password settings.
    options.Password.RequireDigit = true;
    options.Password.RequireLowercase = true;
    options.Password.RequireNonAlphanumeric = true;
    options.Password.RequireUppercase = true;
    options.Password.RequiredLength = 6;
    options.Password.RequiredUniqueChars = 1;

    // Lockout settings.
    options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(5);
    options.Lockout.MaxFailedAccessAttempts = 5;
    options.Lockout.AllowedForNewUsers = false;

    // User settings.
    options.User.AllowedUserNameCharacters =
    "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-._@+";
    options.User.RequireUniqueEmail = true;
});

//config token 
builder.Services.Configure<JwtTokenSettings>(configuration.GetSection(nameof(JwtTokenSettings)));
builder.Services.AddScoped<SignInManager<AppUser>, SignInManager<AppUser>>();
builder.Services.AddScoped<UserManager<AppUser>, UserManager<AppUser>>();
builder.Services.AddScoped<ITokenService, TokenService>();
builder.Services.AddScoped<RoleManager<AppRole>, RoleManager<AppRole>>();

//Config ServiceManager
builder.Services.AddScoped<IRepositoryManager, RepositoryManager>();
builder.Services.AddScoped<IServiceManager, ServiceManager>();

//Addautomaper 
var mapperConfig = new MapperConfiguration(mc =>
{
    mc.Internal().MethodMappingEnabled = false;
    mc.AddProfile(new MappingConfig());
});
builder.Services.AddAutoMapper(cfg => cfg.Internal().MethodMappingEnabled = false, typeof(MappingConfig).Assembly);

//add GlobalError
builder.Services.AddExceptionHandler<GlobalExceptionHandlers>();

//add Cors
builder.Services.ConfigureCors();

//Add authentication
builder.Services.AddAuthen();


//defalt config
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(opt =>
{
    opt.SwaggerDoc("v1", new OpenApiInfo { Title = "MyAPI", Version = "v1" });
    opt.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
    {
        In = ParameterLocation.Header,
        Description = "Please enter token",
        Name = "Authorization",
        Type = SecuritySchemeType.Http,
        BearerFormat = "JWT",
        Scheme = "bearer"
    });

    opt.AddSecurityRequirement(new OpenApiSecurityRequirement
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
//builder.Services.AddSwaggerGen(c =>
//{
//    c.CustomOperationIds(apiDesc =>
//    {
//        return apiDesc.TryGetMethodInfo(out MethodInfo methodInfo) ? methodInfo.Name : null;
//    });
//    c.SwaggerDoc("AdminAPI", new Microsoft.OpenApi.Models.OpenApiInfo
//    {
//        Version = "v1",
//        Title = "API for Administrators",
//        Description = "API for CMS core domain. This domain keeps track of campaigns, campaign rules, and campaign execution."
//    });
//    //c.ParameterFilter<SwaggerNullableParameterFilter>();
//});
//add authen 
builder.Services.AddAuthentication(o =>
{
    o.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    o.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
}).AddJwtBearer("mySchema", cfg =>
{
    cfg.RequireHttpsMetadata = false;
    cfg.SaveToken = true;
    cfg.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateLifetime = true,
        ClockSkew = TimeSpan.FromSeconds(0),
        ValidIssuer = configuration["JwtTokenSettings:Issuer"],
        ValidAudience = configuration["JwtTokenSettings:Issuer"],
        //IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["JwtTokenSettings:Key"]))
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration.GetSection("JwtTokenSettings:Key").Value))
    };
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseExceptionHandler(opt => { });
app.UseHttpsRedirection();
app.UseCors("CorsPolicy");

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

//seeddata
app.MigrationDatabase();

app.Run();
