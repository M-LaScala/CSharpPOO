using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOAlura
{
    internal class OperacaoFinanceiraException : Exception
    {
        public OperacaoFinanceiraException() { }

        public OperacaoFinanceiraException(string message) : base(message) { }

        public OperacaoFinanceiraException(string message, Exception inner) : base(message, inner) { }

    }
}
