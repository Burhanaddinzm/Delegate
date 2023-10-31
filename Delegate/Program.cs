//Delegate:
#region 1ci
//List<int> Numbers = new List<int>
//{
//    1,5,212,12,11,2,4,2,56,767,867,53,54,1231,23343,232
//};
//ShowNumbers(IsOdd);
//void ShowNumbers(Methode methode)
//{
//    if (methode == IsEven)
//    {
//        Console.WriteLine("Cut Ededler");
//    }
//    else
//    {
//        Console.WriteLine("Tek Ededler");
//    }

//    for (int i = 0; i < Numbers.Count; i++)
//    {
//        if (methode(Numbers[i]))
//        {
//            Console.WriteLine(Numbers[i]);
//        }
//    }
//}

//bool IsEven(int num)
//{
//    return (num % 2 == 0);
//}
//bool IsOdd(int num)
//{
//    return (num % 2 != 0);
//}
////Delegate burada return type'i bool olan ve parametr olaraq int qebul eden methodlara aiddir.
//delegate bool Methode(int Num);
#endregion

#region 2ci
//void ShowGroupName()
//{
//    Console.WriteLine("P237");
//}
//void ShowAcademyName()
//{
//    Console.WriteLine("Code Academy");
//}
//void ShowName(string name)
//{
//    Console.WriteLine(name);
//}

//Test1 test = ShowGroupName;
//test += ShowAcademyName;
//test();

//delegate void Test1();
//delegate void Test2(string name);

#endregion

#region 3cu

//int SumNumber(int num)
//{
//    return num + 10;
//}
//int SubNumber(int num)
//{
//    return num - 10;
//}

//char GetFirstLetter(string data)
//{
//    return data[0];
//}
//char GetLastLetter(string data)
//{
//    return data[data.Length - 1];
//}
////Anonym methode
//FuncInt funcInt = (n) => n + 10;
//Console.WriteLine(funcInt(100));


//delegate char FuncChar(string data);
//delegate int FuncInt(int num);

#endregion

//Func,Action and Predicate:
#region 1ci
////    Parametr         Return
//Func <int, string, char, bool> func = (num1, name2, char1)=> true;
//Console.WriteLine(func(10,"Test1",'A'));

//void Test1(int num1,string name2 )
//{
//    Console.WriteLine(num1+" "+name2);
//}
////Action only works with void methode
//Action<int, string> action = Test1;
//action(15,"Test2");

//bool Test2(int num)
//{
//    return false;
//}
////Predicate only returns bool and takes 1 parametr
//Predicate<int> predicate = Test2;
//Console.WriteLine(predicate(20));
#endregion

#region 2ci List ile

List<int> numbers = new List<int>()
{
    1,2,4,5,42,8,9,10,11,12,
};
//FirstOrDefault methodu Func delegate'ni istiyir. Return type'i bool olmalidir ve parametri int.
int Num = numbers.FirstOrDefault((num) => num == 22);

//Find methodu Predicate delegate'ni isteyir
Num = numbers.Find(x => x > 1 && x < 200);

//bool FindNumber(int num)
//{
//    return num == 42;
//}
Console.WriteLine(Num);

#endregion