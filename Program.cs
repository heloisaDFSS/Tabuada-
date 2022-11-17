Console.ForegroundColor = ConsoleColor.DarkMagenta;
Console.Write("\nTábuada do número: ");
int  n = Convert.ToInt32(Console.ReadLine());
Console.ResetColor();

Console.WriteLine();
int m = 0;

if (n>0)
{
   while (m<=10)
      {
         int resul = n * m;
         Console.ForegroundColor = ConsoleColor.Cyan;
         Console.Write($"{n} x {m} = ");
         Console.ResetColor();

         Console.ForegroundColor = ConsoleColor.DarkGreen;
         Console.WriteLine($"{resul}");
         Console.ResetColor();
         
         m = m + 1;
      }
}      

else
{
   Console.Write("O número ");

   Console.ForegroundColor = ConsoleColor.DarkRed;
   Console.Write($"{n} ");
   Console.ResetColor();

   Console.WriteLine("não é positivo");
}

Console.WriteLine();
