using System;
using System.Collections.Generic;
using System.Text;

namespace P03_Ferrari
{
    public interface ICar
    {
        string Model { get; }

        string Brake();

        string Gas();

        string DriverName { get; }

    }
}
