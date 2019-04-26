using System;

namespace Contracts.Repository
{
    public interface ILogger
    {
        void Log(Exception ex);
    }
}