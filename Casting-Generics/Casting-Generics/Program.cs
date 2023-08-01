// Boxing

//int num = 5;

//object t = num;

//num = 100;

//Console.WriteLine(num);
//Console.WriteLine(t);

// Unboxing 


//int num = 5;

//object t = num;

//int j = (int)t;
//Console.WriteLine(j);



// Upcasting

//using Casting_Generics;

//Animal animal1 = new Animal();

//Fish fish1 = new Fish();

//Animal animal3= fish1;

//Animal animal2 = new Fish();

//// Downcasting- alt seviyyeye cast

//Fish fish3 = (Fish)animal1;

//Book book= new Book();

//object[] animals = {book, 1,"Salam", animal1,fish1,animal3,animal2,fish3 };





//foreach (var item in animals)
//{
//	if (item is Animal)
//	{
//		((Animal)item).Name = "Tulku";
//        Console.WriteLine(((Animal)item).Name);

//    }
//}


//foreach (var item in animals)
//{
//    if (item is Animal a)
//    {
//        a.Name = "Tulku";
//        Console.WriteLine(a.Name);

//    }
//}


//foreach (var item in animals)
//{
//    Animal animal = item as Animal;
//    if (animal != null)
//    {
//        animal.Name = "Canavar";
//        Console.WriteLine(animal.Name);
//    }
//}



// Implicit

//byte num1 = 5;
//int num2 = num1;



// Excplicit

//int num1 = 5;

//byte num2=(byte)num1;


//static void Test(int? a)
//{
//    Test2((int)a);
//}

//Test();
//static void Test(int? a=5)
//{
//    Test2((int)a);
//}

//static void Test2(int m)
//{

//    Console.WriteLine(m);
//}

using Casting_Generics;

//IntList intList = new IntList();

//intList.Add(5);
//intList.Add(15);

//var result = intList.GetAll();

//foreach (var item in result)
//{
//    Console.WriteLine(item);
//}


//StringList stringList = new StringList();
//stringList.Add("Salam");
//stringList.Add("hi");

//var result = stringList.GetAll();

//foreach (var item in result)
//{
//    Console.WriteLine(item);
//}

// Butun typelar ucun


//DataList<int> datas = new DataList<int>();
//datas.Add(1);
//datas.Add(2);
//datas.Add(3);
//datas.Add(4);

//var result = datas.GetAll();

//foreach (var item in result)
//{
//    Console.WriteLine(item);
//}


//DataList<string> datas = new DataList<string>();
//datas.Add("Salam");
//datas.Add("Salam2");
//datas.Add("Salam3");
//datas.Add("Salam4");

//var result = datas.GetAll();

//foreach (var item in result)
//{
//    Console.WriteLine(item);
//}


//DataList<bool> statuses = new DataList<bool>();
//statuses.Add(true);
//statuses.Add(false);


//var listBool = statuses.GetAll();

//foreach (var item in listBool)
//{
//    Console.WriteLine(item);
//}


// Book ucun

//DataList<Book> books = new DataList<Book>();

//books.Add(new Book { Id = 1, Name = "Xosrov ve Shirin" });
//books.Add(new Book { Id = 2, Name = "Isgendername" });

//var result = books.GetAll();

//foreach (var item in result)
//{
//    Console.WriteLine(item.Name);
//}


//Repository<string> data1 = new Repository<string>();
//Repository<Book> data2 = new Repository<Book>();
//Repository<bool> data3 = new Repository<bool>();




//Repository<BirdGerics, AnimalGenerics> animal = new Repository<BirdGerics, AnimalGenerics>();




//DataList<Employee> employees = new DataList<Employee>();

//employees.Add(new Employee { Id = 1, Name = "Ismayil" });
//employees.Add(new Employee { Id = 2, Name = "Xeyyam" });

//var result = employees.GetById(1);

//Console.WriteLine(result.Id);






//DataList<Book> books = new DataList<Book>();

//books.Add(new Book { Id = 1, Name = "Xosrov ve Shirin" });
//books.Add(new Book { Id = 2, Name = "Isgendername" });

//var result = books.GetAll();

//foreach (var item in result)
//{
//    Console.WriteLine(item.Id);
//}




DataList<Employee> employees = new DataList<Employee>();

employees.Add(new Employee { Id = 1, Name = "Ismayil" });
employees.Add(new Employee { Id = 2, Name = "Xeyyam" });

var result = employees.Delete(1);

Console.WriteLine(result);

















