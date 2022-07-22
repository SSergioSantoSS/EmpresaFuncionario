using APIEmpFunc.Infra.Data.Interfaces;
using APIEmpFunc.Infra.Data.Repositories;

namespace ProjEmpresaFuncionario
{

    /// <summary>
    /// Classe para configuração da injeção de dependência do projeto
    /// </summary>
    public class DependencyInjection
    {
        /// <summary>
        /// Método para registrar e configurar as dependências
        /// </summary>
        public static void Register(WebApplicationBuilder builder)
        {
            var connectionString = builder.Configuration.GetConnectionString("BD_EMPRESAFUNCIONARIO");

            builder.Services.AddTransient<IEmpresaRepository>(map => new EmpresaRepository(connectionString));

            builder.Services.AddTransient<IFuncionarioRepository>(map => new FuncionarioRepository(connectionString));

            builder.Services.AddTransient<IUsuarioRepository>(map => new UsuarioRepository(connectionString));
        }
    }

}
