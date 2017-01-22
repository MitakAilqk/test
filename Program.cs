using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace List_sort
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[] {"mitko", "pesho", "ivan", "stoqn" };
            int[] digits = new int[] {1,3,2,6,8,3,8,9};
 
            var namesList = new List<string>();
            var digitsList = new List<int>();

            namesList.AddRange(names);
            digitsList = digits.ToList();


            for (int i = 0; i < namesList.Count; i++)
            {
                Console.WriteLine(namesList[i]);
            }
            Console.WriteLine(string.Join(", ",namesList));
            namesList.Sort();
            Console.WriteLine(string.Join(", ",namesList));


            Console.WriteLine(string.Join(", ",digitsList));
            digitsList.Sort();
            Console.WriteLine(string.Join(", ", digitsList));
            //digitsList.OrderByDescending(v=>v);
            Console.WriteLine(string.Join(", ", digitsList.OrderByDescending(v => v)));

        }
    }
}
