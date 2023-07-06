
//MyClass c=new MyClass(1,"divya");
/*using ConsoleApp4;
using Constructor.oops;


using OopsBasics;


//Employee employee = new Employee(10,"AAAA");

//Console.WriteLine(employee.Id);
//Console.WriteLine(employee.Name);
//Console.WriteLine(employee.ObjectCreatedTime);
MathMethods m = new MathMethods();

int ans = m.Add(10, 90);
Console.WriteLine(ans);

ParentXClass parentXClass = new ParentXClass();
Console.WriteLine(parentXClass.GetName());

ChildXClass childXClass = new ChildXClass();
Console.WriteLine(childXClass.GetName());

parentXClass = new ChildXClass();
Console.WriteLine(parentXClass.GetName());

//function call of functionExamples

FunctionExamples f= new FunctionExamples();
int x = 190;
int y = 210;
int avg = 0;
int sum= 0;
sum=f.SumAndAvg(x,y,ref avg);
Console.WriteLine(avg);
Console.WriteLine(sum);


//Collections
CollectionExample example = new CollectionExample();

example.ExampleOfArray();
Console.ReadLine();
//*********************************************************
//Encapsulation
*/
/*using OopsBasics;
using ConsoleApp4;
using Constructor.oops;
using IndexersExampleProj;

Console.WriteLine("Hello, World!");
Employee emp = new Employee();
emp.IpConfig = "Suresh";
emp.SalaryReview = "Can increase the salary";

//Console.WriteLine( emp.SalaryReview);

//var ff = emp.FeedBack1;
//Console.WriteLine(emp.FeedBack1);
Console.WriteLine(emp.IpConfig);

//static classes
var result = Mathutility.add(10M, 20.7M);
Console.WriteLine(result);  

//INDEXER example
var tempRecord = new TempRecord();
tempRecord[1] = 58.3F;
tempRecord[5] = 60.1F;

        // Use the indexer's get accessor
        //for (int i = 0; i < 10; i++)
        //{
        //    Console.WriteLine($"Element #{i} = {tempRecord[i]}");
Cars car = new Cars();
    car[0] = new CarParts
        {
            Name = "Swift",
            Part1 = "wwer",
            Part2 = "Horm",
            Part3 = "rets",
            Part4 = "navi"
        };

        car[1] = new CarParts
        {
            Name = "Benz",
            Part1 = "wwer",
            Part2 = "Horm",
            Part3 = "rets",
            Part4 = "navi"
        };

        car[2] = new CarParts
        {
            Name = "BMW",
            Part1 = "wwer",
            Part2 = "Horm",
            Part3 = "rets",
            Part4 = "navi"
        };
        car[3] = new CarParts
        {
            Name = "Audi",
            Part1 = "wwer",
            Part2 = "Horm",
            Part3 = "rets",
            Part4 = "navi"
        };
        car[4] = new CarParts
        {
            Name = "Ferari",
            Part1 = "wwer",
            Part2 = "Horm",
            Part3 = "rets",
            Part4 = "navi"
        };

        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("************************************************");
            Console.WriteLine(car[i].Name + " " + car[i].Part1);
            Console.WriteLine("************************************************");
        }

        // Keep the console window open in debug mode.
        Console.WriteLine("Press any key to exit.");
        Console.ReadKey();*/

//Sealed class
using Constructor.oops;

Addit program = new Addit();
int d=program.add(10, 20);
Console.WriteLine(d);
