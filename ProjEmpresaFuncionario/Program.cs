using APIEmpFunc.Infra.Data.Interfaces;
using APIEmpFunc.Infra.Data.Repositories;
using ProjEmpresaFuncionario;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c => {
    c.ResolveConflictingActions(apiDescriptions => apiDescriptions.First());
    c.IgnoreObsoleteActions();
    c.IgnoreObsoleteProperties();
    c.CustomSchemaIds(type => type.FullName);
});

#region Mapeamento da inje��o de depend�ncia
DependencyInjection.Register(builder);
#endregion

#region Configura��o do CORS
CorsConfiguration.Register(builder);
#endregion
#region Configura��o do JWT
JWTConfiguration.Register(builder);
#endregion

#region Configura��o do Swagger
SwaggerConfiguration.Register(builder);
#endregion





var app = builder.Build();

SwaggerConfiguration.Use(app);

app.UseAuthentication();
app.UseAuthorization();


CorsConfiguration.Use(app);

app.Run();
