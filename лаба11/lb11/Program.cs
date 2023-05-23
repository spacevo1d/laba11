
using lb11;
try
{
    ////Задание 1
    //int[] array = { 1, 2, 3, 4, 5, 6, 7, 8 };
    //    string[] array2 = { "f", "g", "h", "k" };
    //Person[] arr= new Person[4];
    //arr[0]=new Person();
    //arr[1]=new Person("Ян","Петкуг", new DateTime(1990, 04, 08), "m");
    //arr[2] = new Person("Катя", "Жпек", new DateTime(2003, 03, 12), "ж");
    //arr[3] = new Person("Женя", "Гпек", new DateTime(2000,01,01), "ж");
    //Swap(arr,1,2);
    //Swap(array, 0, array.Length - 1);
    //Swap(array2, 0, 1);
    //for (int i = 0; i < array.Length; i++)
    //{
    //    Console.Write(array[i]);
    //}
    //Console.WriteLine();
    //for (int i=0; i < array2.Length; i++) Console.Write(array2[i]);
    //Console.WriteLine();
    //for (int i = 0; i < arr.Length; i++) { Console.Write(arr[i]); Console.WriteLine(); }
    //for (int i = 0; i < Del(array,2).Length; i++)
    //{
    //    Console.Write(Del(array, 2)[i]);
    //}
    //Console.WriteLine();

    ////Задание 2

    //Console.WriteLine(arr[1].CompareTo(arr[2]));
    //var a=arr.ToArray();
    //Array.Sort(a);
    //for (int i = 0; i < a.Length; i++) { Console.Write(a[i]); Console.WriteLine(); }
    //Console.WriteLine();
    //Console.WriteLine(Max(a));
    //Console.WriteLine();

    ////Задание 2.b
    //var b = arr.ToArray();
    //Array.Sort(b, new AgeCompare());
    //for (int i = 0; i < b.Length; i++) { Console.Write(b[i]); Console.WriteLine(); }
    //Console.WriteLine();
    //Console.WriteLine(MaxAge(b));
    //Console.WriteLine();


    //Array.Sort(b, new GenCompare());
    //for (int i = 0; i < b.Length; i++) { Console.Write(b[i]); Console.WriteLine(); }
    //Console.WriteLine();
    //Console.WriteLine(MaxGen(b));
    //Console.WriteLine();


    //Задание 3
    MyPair<int, string> pair = new MyPair<int, string>(1, "2");
    Console.WriteLine(pair[0]);
    Console.WriteLine(pair[1]);
    Console.WriteLine();
    pair[0] = 3;
    pair[1] = "two";
    Console.WriteLine(pair[0]);
    Console.WriteLine(pair[1]);
    Console.WriteLine();
    MyTriple<string, double, bool> triple = new MyTriple<string, double, bool>("one", 2, true);
    Console.WriteLine(triple[0]);
    Console.WriteLine(triple[1]);
    Console.WriteLine(triple[2]);
    Console.WriteLine();
    triple[0] = "3";
    triple[1] = 4.0;
    triple[2] = false;
    Console.WriteLine(triple[0]);
    Console.WriteLine(triple[1]);
    Console.WriteLine(triple[2]);
    Console.WriteLine();


    //Задание 4
    //var arr=new DoublyLinkedList<int>();
    //int x;
    //string y=Console.ReadLine();
    //while (y != "")
    //{
    //    x= Convert.ToInt32(y);
    //    if (Math.Abs(x) <= 1000)
    //    {
    //        if (arr.count == 0 || arr.count == 1)
    //        {
    //            arr.Add(x);
    //        }
    //        else
    //        {
    //            if (Math.Abs(arr.GetFisrt()-x)< Math.Abs(arr.GetLast() - x))
    //            {
    //                arr.AddFirst(x);
    //            }
    //            else
    //            {
    //                arr.Add(x);
    //            }
    //        }
    //        y = Console.ReadLine();
    //    }
    //    else
    //    {
    //        Console.WriteLine("Число должно быть по модулю меньше 1000!");
    //    }
    //}
    //arr.showcount();
    //arr.print();


    //Задание 4.b
    //var arr1=new DoublyLinkedList<string>();
    //arr1.Add("1");
    //arr1.Add("4");
    //arr1.AddFirst("5");
    //arr1.AddFirst("PopCorn");
    //arr1.Add("Null");
    //arr1.print();
    //arr1.Delete("1");
    //arr1.print();
}
catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}



static void Swap<T>(T[] array, int a, int b)
{
    T te = array[a];
    array[a] = array[b];
    array[b] = te;
}
static T[] Del<T>(T[] array, int a)
{
    T[] arr=new T[array.Length-1];
    for(int i=0; i < array.Length-1; i++)
    {
        if (i < a)
        {
            arr[i] = array[i];
        }
        else if(i>=a) {
            arr[i] = array[i+1];
        }
    }
    return arr;
}

static T Max<T>(T[] arr)
{
    if (arr == null)
    {
        return default(T);
    }
    else
    {
        Array.Sort(arr);
        return arr[arr.Length-1];
    }
}

static Person MaxAge(Person[] arr)
{
    if (arr == null)
    {
        return null;
    }
    else
    {
        Array.Sort(arr,new AgeCompare());
        return arr[arr.Length-1];
    }
}

static Person MaxGen(Person[] arr)
{
    if (arr == null)
    {
        return null;
    }
    else
    {
        Array.Sort(arr, new GenCompare());
        return arr[arr.Length - 1];
    }
}