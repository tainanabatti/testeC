using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu menu = new Menu("");
           // menu.Centralizado = true;
            menu.Items.Add(new MenuItem { Rotulo = "Opcao 1" });
            menu.Items.Add(new MenuItem { Rotulo = "Opcao 2" });
            menu.Items.Add(new MenuItem { Rotulo = "Opcao 3" });
            menu.Show();

            Submenu submenu = new Submenu("");

            submenu.Items.Add(new MenuItem { Rotulo = "SUB 1" });
            submenu.Items.Add(new MenuItem { Rotulo = "SUB 2" });
            submenu.Items.Add(new MenuItem { Rotulo = "SUB 3" });
           // submenu.Show();


            Console.ReadKey();  
       }
    }
}
