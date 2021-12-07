using System;

class Program {
  public static void Main (string[] args) {
    long horas, minutos, segundos;//o tipo "long" foi usado pois o "int" não consegue representar o resultado das expressões.
    Console.WriteLine ("Digite o intervalo de tempo no formato HH:MM:SS");
    string entrada = Console.ReadLine();
    string [] lista = entrada.Split(':');//cria uma lista do tipo "string" a partir da entrada.
    horas = long.Parse(lista[0]); minutos = long.Parse(lista[1]); segundos = long.Parse(lista[2]);//define dentro da lista as variáveis horas, minutos e segundos.
    segundos = (segundos) + (minutos * 60) + (horas * 3600);//essa linha de código converte todas as variáveis em segundos para resolver o problema. A variável segundos não precisa ser convertida.
    long vel_luz = segundos * 300000;
    Console.WriteLine($"A luz percorreu {vel_luz} km nesse intervalo");
  }
}
