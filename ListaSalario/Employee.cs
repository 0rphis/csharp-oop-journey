using System;
using System.Globalization;

namespace ListaSalario
{
    class Employee
    {
        public string Nome { get; private set; }
        public int Id { get; private set; }
        public double Salario { get; private set; }

        public void AumentarSalario(double porcentagem)
        {
            Salario += Salario * porcentagem / 100.0;
        }

        public bool SearchId(int id)
        {
            return Id == id;
        }

        public Employee(string nome, int id, double salario)
        {
            Nome = nome;
            Id = id;
            Salario = salario;
        }

        public override string ToString()
        {
            return Id + ", " + Nome + ", " + Salario.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
