string insira;
Console.ForegroundColor=ConsoleColor.White;
Console.WriteLine("Texto a ser traduzido...: Hackers usavam leet antes de virar modinha.");
Console.ResetColor();
Console.ForegroundColor=ConsoleColor.DarkGray;
Console.Write("Insira o texto...:");
Console.ResetColor();
insira=Console.ReadLine()!.Replace("a","4")
.Replace("e","3")
.Replace("i","1")
.Replace("l","1")
.Replace("o","0")
.Replace("t","7")
.Replace("s","5").ToUpper();
Console.ResetColor();
Console.ResetColor();
Console.WriteLine($"{insira}");
Console.ReadKey(true);
Console.ForegroundColor=ConsoleColor.Blue;
Console.Write(@"
+---------+
| Vinicius|
+---------+");
Console.ResetColor();