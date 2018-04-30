using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameGenerator {
    class Program {
        static void Main(string[] args) {
            SyllableGen testObject = new SyllableGen();

            Console.WriteLine("Name Generator");
            Console.WriteLine("Type number of names to generate. Type end to exit.");

            String input;
            do {
                input = Console.ReadLine();

                int value;
                if (Int32.TryParse(input, out value)) {
                    for (int i = 0; i < value; i++) {
                        Console.WriteLine(testObject.GetAName());
                    }
                }

            } while (input.ToLower() != "end");
        }
    }
}
