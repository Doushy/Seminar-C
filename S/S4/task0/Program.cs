string text = Console.ReadLine();
char[] obrtext = text.ToCharArray();
Array.Reverse(obrtext);
string finaltext = new string(obrtext);

if (text == finaltext)
{
    System.Console.WriteLine("Да");
}
if (text != finaltext)
{
    System.Console.WriteLine("Да");
}
