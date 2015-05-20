using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoeClosetWithInitializer
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shoe> shoeCloset = new List<Shoe>() {
                new Shoe() { Style = Style.Sneakers, Color = "Black" },
                new Shoe() { Style = Style.Clogs, Color = "Brown" },
                new Shoe() { Style = Style.Wingtips, Color = "Black" },
                new Shoe() { Style = Style.Loafers, Color = "White" },
                new Shoe() { Style = Style.Loafers, Color = "Red" },
                new Shoe() { Style = Style.Sneakers, Color = "Green" },
            };

            int numberOfShoes = shoeCloset.Count;
            foreach (Shoe shoe in shoeCloset)
            {
                shoe.Style = Style.Flipflops;
                shoe.Color = "Orange";
            }
            shoeCloset.RemoveAt(4);
            Shoe thirdShoe = shoeCloset[2];
            Shoe secondShoe = shoeCloset[1];
            shoeCloset.Clear();
            shoeCloset.Add(thirdShoe);
            if (shoeCloset.Contains(secondShoe))
                Console.WriteLine("That’s surprising.");

        }
    }
}
