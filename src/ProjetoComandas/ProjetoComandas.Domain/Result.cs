using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoComandas.Domain
{
    public struct Result<T>
    {
        T? Value;
        Exception? Exception;

        public Result(T valor)
        {
            this.Value = valor;
            this.Exception = default;
        }

        public Result(Exception exception)
        {
            this.Value = default;
            this.Exception = exception;            
        }



        public T? GetValue()
        {
            if (EhSucesso())
                return Value!;
            else
                return default;
        }

        public Exception GetError()
        {
            if (EhErro())
                return Exception!;
            else
                return new Exception("");
        }

        public bool EhSucesso()
        {
            return Exception is null;
        }

        public bool EhErro()
        {
            return Exception is not null;
        }

    }
}
