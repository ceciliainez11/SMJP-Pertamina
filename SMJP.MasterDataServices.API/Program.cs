using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using SMJP.MasterDataServices.API;
using SMJP.MasterDataServices.API.Data;
using Swashbuckle.AspNetCore.SwaggerGen;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddDbContext<AppDbContext>(option =>
{
    option.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});
IMapper mapper = MappingConfig.RegisterMaps().CreateMapper();
builder.Services.AddSingleton(mapper);
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
//builder.Services.AddSwaggerGen(c =>
//{
//    c.SwaggerDoc("v1", new OpenApiInfo { Title = "Your API", Version = "v1" });

//    // Add support for file upload
//    c.OperationFilter<SwaggerFileOperationFilter>();

//    // Include XML comments if available (for better documentation)
//    var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
//    var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
//    if (File.Exists(xmlPath))
//    {
//        c.IncludeXmlComments(xmlPath);
//    }
//});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseStaticFiles(); // Ensure static files are served

app.UseAuthorization();

app.MapControllers();
ApplyMigration();
app.Run();

void ApplyMigration()
{
    using (var scope = app.Services.CreateScope())
    {
        var _db = scope.ServiceProvider.GetRequiredService<AppDbContext>();

        if (_db.Database.GetPendingMigrations().Count() > 0)
        {
            _db.Database.Migrate();
        }
    }
}

//// Define the SwaggerFileOperationFilter
//public class SwaggerFileOperationFilter : IOperationFilter
//{
//    public void Apply(OpenApiOperation operation, OperationFilterContext context)
//    {
//        var fileParams = context.MethodInfo.GetParameters()
//            .Where(p => p.ParameterType == typeof(IFormFile))
//            .ToList();

//        if (fileParams.Any())
//        {
//            operation.Parameters.Clear();
//            foreach (var fileParam in fileParams)
//            {
//                operation.RequestBody = new OpenApiRequestBody
//                {
//                    Content = new Dictionary<string, OpenApiMediaType>
//                    {
//                        ["multipart/form-data"] = new OpenApiMediaType
//                        {
//                            Schema = new OpenApiSchema
//                            {
//                                Type = "object",
//                                Properties =
//                                {
//                                    [fileParam.Name] = new OpenApiSchema
//                                    {
//                                        Type = "string",
//                                        Format = "binary"
//                                    }
//                                }
//                            }
//                        }
//                    }
//                };
//            }
//        }
//    }
//}
