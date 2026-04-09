using System;
using System.Globalization;

namespace ContaBancaria
{
    class Conta
    {
        public int Numero { get; set; }
        public string Titular { get; private set; }
        public double Saldo { get; private set; }

        // construtor COM depósito inicial
        public Conta(int numero, string titular)
        {
            Numero = numero;
            Titular = titular;
            Saldo = 0;
        }

        // construtor SEM depósito inicial, saldo começa em 0
        public Conta(int numero, string titular, double deposito)
            : this(numero, titular)
        {
            Saldo = deposito;
        }

        public void Depositar(double valor)
        {
            Saldo += valor;
        }

        public void Sacar(double valor)
        {
            Saldo -= valor + 5.00;
        }

        public override string ToString()
        {
            return "Conta "
                + Numero
                + ", Titular: "
                + Titular
                + ", Saldo: $ "
                + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
