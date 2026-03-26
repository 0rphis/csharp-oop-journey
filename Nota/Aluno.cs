using System;
using System.Globalization;

namespace Nota
{
  public class Aluno
  {
    public string Nome;
    public double Nota1;
    public double Nota2;
    public double Nota3;

    public double NotaTotal
    {
      get { return Nota1 + Nota2 + Nota3; }
    }

    private bool Aprovado()
    {
      return NotaTotal >= 60;
    }

    public string Status()
    {
      if (Aprovado())
      {
        return "APROVADO";
      }
      else
      {
        double pontosFaltando = 60 - NotaTotal;
        return $"REPROVADO\nFALTARAM {pontosFaltando.ToString("F2", CultureInfo.InvariantCulture)} PONTOS";
      }
    }
    

  }
}
