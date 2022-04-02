using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    ConsoleKeyInfo key;
    Console.WriteLine("Por favor presione cualquier tecla. ");
    Console.WriteLine("Si desea salir presione Ctrl+F.");

//Me guardo F
    ConsoleKey f = ConsoleKey.F;
//Me guardo Ctl
    ConsoleModifiers ctl = ConsoleModifiers.Control;


do
{
    

    key = Console.ReadKey();
    Console.WriteLine("" + System.Environment.NewLine +
        "Usted presiono " + key.KeyChar);

    if ((key.Modifiers & ConsoleModifiers.Control) != 0)
    {
        Console.Write("CTL+");
    }

    Console.WriteLine(key.Key.ToString());

} while (key.Modifiers != ctl || key.Key != f);
