using APIEmpFunc.Infra.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIEmpFunc.Infra.Data.Interfaces
{
    public interface IFuncionarioRepository : IBaseRepository<Funcionario>
    {
        Funcionario GetByCpf(string cpf);
        Funcionario GetByMatricula(string matricula);
    }

}
