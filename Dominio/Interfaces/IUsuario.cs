using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Interfaces
{
    public interface IUsuario
    {
        Task<bool> AdicionaUsuario(string email, string senha, int idade, string celular);

        Task<bool> ExisteUsuario(string email, string senha);
    }
}
