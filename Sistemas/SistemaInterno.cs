using POOAlura.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOAlura.Sistemas
{
    public class SistemaInterno
    {

        public bool Logar(IAutenticavel funcionario, string senha)
        {
            bool usuarioAutenticado = funcionario.Autenticar(senha);

            if ( usuarioAutenticado)
            {
                Console.WriteLine("Bem vindo");
                return true;
            }
            else
            {
                Console.WriteLine("Usuario ou senha invalida!");
                return false;
            }
        }
    }
}
