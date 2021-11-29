using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsConsoleApp
{
    class Table<T>
    {
        public string color;
        private T numberOfFeets;

        public Table(string color, T numberOfFeets) { this.color = color; this.numberOfFeets = numberOfFeets; }
        public T NumberOfWheels{get;set;}

}
    
}
