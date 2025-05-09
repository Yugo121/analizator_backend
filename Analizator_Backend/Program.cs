using Application.Interfaces;
using Application.Services;
using Infrastructure.Interfaces;
using Infrastructure.Services;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllers();
builder.Services.AddOpenApi();

IInterfaceServiceRegistration infrastructureService = new InterfaceServiceRegistration();
infrastructureService.AddInfrastructure(builder.Services, builder.Configuration);

IApplicationServiceRegistration applicationService = new ApplicationServiceRegistration();
applicationService.AddApplicationServices(builder.Services, builder.Configuration);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
