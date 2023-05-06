using System.Security.Cryptography;

int faces, rolagem;

Console.Clear();





Console.WriteLine($"# Rolagem de dados #");
Console.WriteLine();

Console.Write("Quantas faces?.... ");
faces = Convert.ToInt32(Console.ReadLine());


rolagem = RandomNumberGenerator.GetInt32(1, faces + 1);
Console.Write("Rolagem........... ");
Console.Write(rolagem);