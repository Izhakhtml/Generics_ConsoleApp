using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsConsoleApp
{
    class Chair<T>
    {
        private T heigth;
        private T numberOfFeets;
        public Chair(T heigth, T numberOfFeets) { this.heigth = heigth; this.numberOfFeets = numberOfFeets; }
        public T Heigth{get;set;}
        public T NumberOfFeets{ get;set;}
    }

}
