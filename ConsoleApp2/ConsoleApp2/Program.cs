using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        #region Enum
        //public enum Errors { NotFound = 404, UnAuthorization = 410 }

        //public enum Month{ Yanvar=255,Fevral,Mart,Aprel}
        #endregion

        static void Main(string[] args)
        {
            #region Enum
            //foreach (int item in Enum.GetValues(typeof(Month)))
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine((int)Errors.UnAuthorization);
            //int? x = null;
            #endregion


            #region Struct
            //Person p1 = new Person();
            //Person p2 = p1;

            //int x = 5;
            //int y = x;
            //Location location=new Location();
            ////location.Y = 10;
            //location.X = 5;
            //Console.WriteLine(location.X);

            //Location.Hello();
            #endregion

            #region Generic type
            //MyList<Person> list = new MyList<Person>(3);
            //list.AddElm(new Person { Name = "Ibrahim", Surname = "Nezerov" });
            //list.AddElm(new Person { Name = "Miri", Surname = "Donmegeri" });
            //list.AddElm(new Person { Name = "Elman", Surname = "LazimDeyil" });
            //list.AddElm(new Person { Name = "Ibrahim", Surname = "Nezerov" });
            //list.ShowAllPerson();

            //MyList<Animal> list1 = new MyList<Animal>(2);
            //list1.AddElm(new Animal());

            //MyList<int> list2 = new MyList<int>(4);
            //list2.AddElm(2);
            //list2.AddElm(3);

            //MyList<Woman, Person> list = new MyList<Woman, Person>(3);
            #endregion

            string a = "ana";
            
            Console.WriteLine(a.CharCount('z'));
        }

        #region Struct
        //class Person 
        //{
        //    public Person(int y=1)
        //    {

        //    }
        //}

        ////class Woman : Person { }

        //struct Test { }
        //struct Location
        //{
        //    public int X;
        //    public int Y { get; set; }

        //    static Location()
        //    {
        //        Console.WriteLine("First");
        //    }

        //    public static void Hello()
        //    {
        //        Console.WriteLine("Hello");
        //    }
        //}
        #endregion


    }

    #region Generic type
    //class MyList<T,U> where T:U
    //{
    //    private static int index = 0;
    //    private T[] _people;
    //    private int _maxCount;

    //    public MyList(int count)
    //    {
    //        _maxCount = count;
    //        _people = new T[count];
    //    }

    //    public void AddElm(T p)
    //    {
    //        if (index < _maxCount)
    //        {
    //            _people[index] = p;
    //            index++;
    //        }
    //        else
    //        {
    //            Console.WriteLine("Yer yoxdur");
    //        }

    //    }

    //    public void ShowAllPerson()
    //    {
    //        foreach (T item in _people)
    //        {
    //            Console.WriteLine(item);
    //        }
    //    }
    //}

    //class Person
    //{
    //    public string Name { get; set; }
    //    public string Surname { get; set; }

    //    public override string ToString()
    //    {
    //        return Name + " " + Surname;
    //    }
    //}

    //class Woman : Person { }

    //class Animal { }
    #endregion
}
