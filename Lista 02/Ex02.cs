using System;

class Program {
  public static void Main (string[] args) {
    Console.WriteLine ("Digite seu nome completo:");
    string name = Console.ReadLine();
    string [] lista = name.Split(' ');
    Console.WriteLine($"Bem-vindo ao C#, {lista[0]}");
    
  }
}
