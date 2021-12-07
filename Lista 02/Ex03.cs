using System;

class Program {
  public static void Main (string[] args) {
    int primeiro_bimestre, segundo_bimestre, media_parcial;
    Console.WriteLine ("Digite a nota do primeiro bimestre da disciplina:");
    primeiro_bimestre = int.Parse(Console.ReadLine());
    Console.WriteLine ("Digite a nota do segundo bimestre da disciplina:");
    segundo_bimestre = int.Parse(Console.ReadLine());
    media_parcial = (primeiro_bimestre*2 + segundo_bimestre*3) / 5;
    Console.WriteLine ($"Média parcial = {media_parcial}");
  }
}
