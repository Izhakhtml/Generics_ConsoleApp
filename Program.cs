using GenericsConsoleApp;
/// exe 1
//Table table = new Table("red", 4);
//Table<double> table = new Table<double>("black", 5.2);
//Console.WriteLine(table.numberOfFeets);
//Table<double> table = new Table<double>("green", 4.3);
//Console.WriteLine(table.NumberOfWheels = 6.3);
/// exe 2
//Chair chair = new Chair();
//exe 1-2
List<int> numbers = new List<int>();
numbers.Add(1);
numbers.Add(2);
numbers.Add(3);
numbers.Add(4);
numbers.Add(5);
//exe 3-4
List<string> letters = new List<string>();
letters.Add("aa");
letters.Add("bb");
letters.Add("cc");
letters.Add("dd");
//exe 5
List<double> doubleNumbers = new List<double>();
doubleNumbers.Add(1.2);
doubleNumbers.Add(2.2);
doubleNumbers.Add(3.2);
//exe 6
double[] arrayNumbers = new double[] { 5.3, 6.3, 7.3, 8.3 };
doubleNumbers.AddRange(arrayNumbers);
//exe 7
doubleNumbers.RemoveAt(4);
//exe 8
int i  = 0;
while (i<numbers.Count)
{
  //Console.WriteLine(numbers[i]);
  i++;
}
//exe 9-10
//Shop<int> shop = new Shop<int>(4,50,20);
// exe 11
List<Shop<int>> shopList = new List<Shop<int>>();
// exe 12
//shopList.Add(new Shop<int>(2,4,6));
//shopList.Add(new Shop<int>(3,6,9));
//shopList.Add(new Shop<int>(4,8,12));
//shopList.Add(new Shop<int>(5,10,15));
int x = 0;
while (x < shopList.Count)
{
    //Console.WriteLine(shopList[x].numbersTable + "" + shopList[x].numbersChair + "" + shopList[x].numbersCabinet + "" + shopList[x].sizesList);
    x++;
}
// exe 13
// create sizeList field
// exe 14
List<int> numbersArr = new List<int>();
//numbersArr.Add(1);
//numbersArr.Add(2);
//numbersArr.Add(3);
//numbersArr.Add(4);
//numbersArr.Add(5);
Shop<int> shop = new Shop<int>(1,2,3,numbersArr);
// exe 15-16
int index = 0;
//while (index < shop.sizesList.Count)
//{
//Console.WriteLine(shop.sizesList[index]);
//index++;
//}
// exe 17
//int userInput = int.Parse(Console.ReadLine());
//while (index < 5)
//{
//    Console.WriteLine("enter number");
//    int userInput = int.Parse(Console.ReadLine());
//    shop.sizesList.Add(userInput);
//    index++;
//}
//int n = 0;
//while (n < shop.sizesList.Count)
//{
//    Console.WriteLine(shop.sizesList[n]);
//    n++;
//}
// exe 18
//while (index < 5)
//{
//    Console.WriteLine("enter number");
//    int userInput = int.Parse(Console.ReadLine());
//    if (userInput > 15)
//    {
//    shop.sizesList.Add(userInput);
//    }
//    else 
//    {
//    shop.sizesList.Add(0);
//    }
//    index++;
//}
//int n = 0;
//while (n < shop.sizesList.Count)
//{
//    Console.WriteLine(shop.sizesList[n]);
//    n++;
//}
// exe 19