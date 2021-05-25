using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch8_Pg369_DuckApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Duck> ducks = new List<Duck>() {
                new Duck() { Kind = KindOfDuck.Mallard, Size = 17 },
                new Duck() { Kind = KindOfDuck.Muscovy, Size = 18 },
                new Duck() { Kind = KindOfDuck.Decoy, Size = 14 },
                new Duck() { Kind = KindOfDuck.Muscovy, Size = 11 },
                new Duck() { Kind = KindOfDuck.Mallard, Size = 14 },
                new Duck() { Kind = KindOfDuck.Decoy, Size = 13 },
            };

            PrintDucks(ducks);
            ducks.Sort();
            PrintDucks(ducks);

            DuckCompareBySize sizeComparer = new DuckCompareBySize();
            ducks.Sort(sizeComparer);
            PrintDucks(ducks);

            DuckCompareByKind kindComparer = new DuckCompareByKind();
            ducks.Sort(kindComparer);
            PrintDucks(ducks);

            DuckComparer comparer = new DuckComparer();

            comparer.SortBy = SortCriteria.KindThenSize;
            ducks.Sort(comparer);
            PrintDucks(ducks);

            comparer.SortBy = SortCriteria.SizeThenKind;
            ducks.Sort(comparer);
            PrintDucks(ducks);

            Console.ReadKey();
        }

        public static void PrintDucks(List<Duck> ducks)
        {
            foreach (Duck duck in ducks)
                Console.WriteLine(duck);
            Console.WriteLine("End of List\n");
        }
    }
}
