string MS = Console.ReadLine();
int ValueSTR = new Random() .Next(1,4);
int Lenght = MS.Length;
string Fin = String.Empty;
if (ValueSTR == 1)
{
int Number1 = new Random() .Next(1,Lenght);
Fin = $"{MS[Number1]}";
}
if (ValueSTR == 2)
{
int Number1 = new Random() .Next(1,Lenght);
int Number2 = new Random() .Next(1,Lenght);
Fin = $"{MS[Number1]}" + $"{MS[Number2]}";
}