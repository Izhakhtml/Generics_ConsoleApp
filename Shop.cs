using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsConsoleApp
{
    class Shop<T>
    {
        public T numbersTable;
        public T numbersChair;
        public T numbersCabinet;
        public List<T> sizesList;
        public Shop(T numbersTable, T numbersChair , T numbersCabinet, List<T> sizesList) 
        {
            this.numbersTable = numbersTable;
            this.numbersChair = numbersChair;
            this.numbersCabinet = numbersCabinet;
            this.sizesList = sizesList;

        }
        public Shop() { }
    }
}
