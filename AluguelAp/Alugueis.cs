using System;

namespace AluguelAp
{
  class Alugueis
  {

    public string Nome {get; set;}
    public string Email {get; set;}
    public int Quarto {get; set;}

    public Alugueis(string nome, string email, int quarto)
    {
      Nome = nome;
      Email = email;
      Quarto = quarto;
    }

    public override string ToString()
    {
      return Quarto + ": " + Nome + ", " + Email;
    }


  }
}