using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POOAlura.Funcionarios;
using POOAlura.Sistemas;

namespace POOAlura.Funcionarios
{
    public class Diretor : FuncionarioAutenticavel
    {
        //Construtor do diretor agora passa o argumento CPF para a Base 
        //Todo diretor tem um salario base de 5000 que é passado apra a classe base
        public Diretor(string cpf) : base(5000, cpf)
        {
        }

        public override void AumentarSalario()
        {
            Salario *= 1.15;
        }

        public override double GetBonificacao()
        {
            return Salario * 0.5;
        }
    }
}
