using Entitati;
using System;
namespace Biblioteca.Ui {
    public class Program {
        static void Main(string[] args) {
            var biblioteca = new Biblioteca();
            Console.Write("Cate carti doriti sa introduceti? - ");
            int nr_carti = int.Parse(Console.ReadLine());
            for (int i = 0; i < nr_carti; i++)
            {
                biblioteca.AddElement(new CarteMgr().AddCarte());
            }
            Console.Write("Cate reviste doriti sa introduceti? - ");
            int nr_reviste = int.Parse(Console.ReadLine());
            for (int i = 0; i < nr_reviste; i++)
            {
                biblioteca.AddElement(new RevistaMgr().AddRevista());
            }

            Biblioteca.PrintLista();
            Console.WriteLine("Ce carte doriti sa imprumutati? (Specificati titlul)");
            string title = Console.ReadLine();
            Biblioteca.UseLinq(title);
            Console.WriteLine("Cartea cu titlul " + title + " a fost imprumutata!");
            Biblioteca.PrintLista();
        }
    }
}
