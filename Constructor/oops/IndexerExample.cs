using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    namespace IndexersExampleProj
    {
        public class TempRecord
        {
            
            float[] temps = new float[10]
            {
        56.2F, 56.7F, 56.5F, 56.9F, 58.8F,
        61.3F, 65.9F, 62.1F, 59.2F, 57.5F
            };
              public int Length => temps.Length;

            // Indexer declaration.
            // If index is out of range, the temps array will throw the exception.
            public float this[int index]
            {
                get => temps[index];
                set => temps[index] = value;
            }
        }

        public class CarParts
        {
            public string Name { get; set; }
            public string Part1 { get; set; }
            public string Part2 { get; set; }
            public string Part3 { get; set; }
            public string Part4 { get; set; }
        }

        public class Cars
        {
            CarParts[] parts = new CarParts[5];

            public CarParts this[int index]
            {
                get => parts[index];
                set => parts[index] = value;
            }


        }
    }

