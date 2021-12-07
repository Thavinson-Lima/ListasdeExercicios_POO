using System;

class Program {
  public static void Main (string[] args) {
    double b, h, area, perim, diag;
    Console.WriteLine ("Digite a base e a altura do retângulo:");
    b = double.Parse(Console.ReadLine());
    h = double.Parse(Console.ReadLine());
    area = b*h;
    perim = b*2+h*2;
    diag = Math.Sqrt((b*b)+(h*h));
    Console.WriteLine($"Área = {area:0.00} - Perímetro = {perim:0.00} - Diagonal = {diag:0.00}");
  }
}
