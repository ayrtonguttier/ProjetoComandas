using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using Xunit.Abstractions;

namespace Testes.Dependencias
{
    internal class MyTestLogger<T> : ILogger<T>
    {
        private readonly ITestOutputHelper output;

        public MyTestLogger(ITestOutputHelper output)
        {
            this.output = output;
        }

        public IDisposable BeginScope<TState>(TState state)
        {
            return new FakeDisposable();
        }

        public bool IsEnabled(LogLevel logLevel)
        {
            return true;
        }

        public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception? exception, Func<TState, Exception?, string> formatter)
        {
            output.WriteLine(
                state?.ToString() + Environment.NewLine +
                exception?.ToString());
        }
    }

    internal class FakeDisposable : IDisposable
    {
        public void Dispose()
        {
            
        }
    }
}
