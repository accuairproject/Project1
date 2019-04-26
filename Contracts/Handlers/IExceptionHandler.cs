using System; // standard new interface
using System.Collections.Generic; // standard new interface
using System.Text; // standard new interface

namespace Contracts.Handlers // standard new interface
{
    public interface IExceptionHandler // standard new interface
    {
        T Run<T>(Func<T> func);
    }
}