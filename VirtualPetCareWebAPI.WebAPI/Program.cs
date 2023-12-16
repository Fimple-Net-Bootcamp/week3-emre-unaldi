using VirtualPetCareWebAPI.Business.Abstracts;
using VirtualPetCareWebAPI.Business.Concretes;
using VirtualPetCareWebAPI.DataAccess.Abstracts;
using VirtualPetCareWebAPI.DataAccess.Concretes.EntityFramework;
using VirtualPetCareWebAPI.DataAccess.Mapping;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// PostgreSQL
//builder.Services.AddDbContext<PetCareDbContext>();
builder.Services.AddMvc();

// Controllers
builder.Services.AddControllers();

// AutoMapper
builder.Services.AddAutoMapper(typeof(MappingProfile));

// User Service Bind
builder.Services.AddScoped<IUserService, UserManager>();
builder.Services.AddScoped<IUserDal, EfUserDal>();

// Pet Service Bind
builder.Services.AddScoped<IPetService, PetManager>();
builder.Services.AddScoped<IPetDal, EfPetDal>();

// Health Status Service Bind
builder.Services.AddScoped<IHealthStatusService, HealthStatusManager>();
builder.Services.AddScoped<IHealthStatusDal, EfHealthStatusDal>();

// Food Service Bind
builder.Services.AddScoped<IFoodService, FoodManager>();
builder.Services.AddScoped<IFoodDal, EfFoodDal>();

// Activity Service Bind
builder.Services.AddScoped<IActivityService, ActivityManager>();
builder.Services.AddScoped<IActivityDal, EfActivityDal>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapControllers();

app.UseCors("AllowSpecificOrigin");

app.Run();
