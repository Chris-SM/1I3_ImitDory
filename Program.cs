string tex = "a";
Console.WriteLine("-----Tradutor de Baleês-----");
Console.Write("digite a palavra que quer traduzir: ");
tex = Console.ReadLine()!.ToLower();
Console.WriteLine("Hum....\nVocê Digitou: "+tex);
Console.WriteLine("Traduzindo ...");
Thread.Sleep(1500);
tex = tex.Replace("a","aaa")
.Replace("e","eee")
.Replace("i","iii")
.Replace("o","ooo")
.Replace("u","uuu")
.Replace("A","AAA")
.Replace("E","EEE")
.Replace("I","III")
.Replace("O","OOO")
.Replace("U","UUU");;
Console.WriteLine(tex);