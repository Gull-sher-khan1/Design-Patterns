//using SingleResponsibilityPrinciple;
//var p = new Person("John", 12);
//var persistance = new Persistance(@"C:\objectfile.txt");
//persistance.Save(p);
//--------------------------------------------------------
//using OpenClosedprinciple;
//using SingleResponsibilityPrinciple;
//var p1 = new Person("John", 12);
//var p2 = new Person("Alex", 12);
//var p3 = new Person("Alex", 13);
//var filter = new PersonFilter();
//var people = filter.Filter(new List<Person> { p1, p2, p3 }, new AgeSpecification(12));
//foreach(Person p in people) {
//    Console.WriteLine(p);
//}
//people = filter.Filter(new List<Person> { p1, p2, p3 }, new NameSpecification("Alex"));
//foreach (Person p in people)
//{
//    Console.WriteLine(p);
//}
//--------------------------------------------------------------
// To stop the console from closing.
//using LiskovSubstitutionPrinciple;
//Cat t = new Tiger();
//t.MakeSound();
//--------------------------------------------------------------
//using DependencyInversionPrinciple;
//var notification = new Notification(new EmailService());
//notification.SendNotification("body");
//--------------------------------------------------------------
//using Builder;
//var builder = new PersonBuilder();
//var emp = builder.Create().AssignedAt(PositionLevel.Junior).HasSalary(25000).Build();
//--------------------------------------------------------------
//using Factory;
//Console.WriteLine(Point.Factory.CartesianPoint(1, 2));
//Console.WriteLine(Point.Factory.PolarPoint(1, 2));
//--------------------------------------------------------------
//using Prototype;

//var alex = new Person("Alex", "Smith", new Address(123, "oxford street"));
//var bob = alex.DeepCopy();
//bob.Names[0] = "Bob";
//bob.Address.HouseNumber = 321;
//Console.WriteLine(alex);
//Console.WriteLine(bob);
//--------------------------------------------------------------

//using Adapter;
//var cylinder = new Cylinder(4, 4);
//var hole = new Hole(4);
//var sp1 = new SquarePrismAdapter(new SquarePrism(4,4));
//var sp2 = new SquarePrismAdapter(new SquarePrism(9, 12));
//Console.WriteLine(hole.fits(cylinder));
//Console.WriteLine(hole.fits(sp1));
//Console.WriteLine(hole.fits(sp2));

//--------------------------------------------------------------
//using Bridge;
//var remote = new Remote(new TV(10));
//remote.DecreaseVolume();
//Console.WriteLine(((TV)remote.MyDevice).Volume);
//remote = new Remote(new Radio(10));
//remote.IncreaseVolume();
//Console.WriteLine(((Radio)remote.MyDevice).Volume);
//--------------------------------------------------------------

//using Singleton;

//var g1 = Government.GetInstance("abc");
//var g2 = Government.GetInstance("def");
//var g3 = Government.GetInstance("ghi");
//Console.WriteLine(g1.getName());
//Console.WriteLine(g2.getName());
//Console.WriteLine(g3.getName());
//--------------------------------------------------------------
//using Composite;
//var box = new Box(new List<Product>()
//{
//    new Box(new List<Product>()
//    {
//        new Book(10),
//        new Book(20),
//        new Book(30)
//    }),
//    new Book(40)
//});
//Console.WriteLine(box.GetPrice());
//--------------------------------------------------------------
//using Decorator;
//var d1 = new DecoratorA(new ConcreteComponent());
//Console.WriteLine(d1.Operation());
//d1 = new DecoratorA(null);
//Console.WriteLine(d1.Operation());
//--------------------------------------------------------------
//using Facade;
//var facade = new NotifierFacade(new Message("Me", "You", "Body", "Title"));
//facade.NotifyBy("email");
//facade.NotifyBy("sms");
//facade.NotifyBy("app");
//--------------------------------------------------------------
//using Proxy;

//var client = new Client();
//client.Operate();
//--------------------------------------------------------------
//using Flyweight;
//var factory = new FlyweightFactory(
//    new Tree {Type = "Oak", Color = "Black" },
//    new Tree { Type = "Pine", Color = "Green" },
//    new Tree { Type = "Oak", Color = "Black" },
//    new Tree { Type = "Maple", Color = "Red" },
//    new Tree { Type = "Maple", Color = "Orange" },
//    new Tree { Type = "Pine", Color = "Green" });
//factory.GetAllFlyweights();
//--------------------------------------------------------------
//using ChainOfResponsibility;
//var square = new SquareHoleHandler();
//var circle = new CircleHoleHandler();
//var triangle = new TriangleHoleHandler();
//square.SetNext(circle).SetNext(triangle);
//var objs = new List<string> { "circle", "square", "cone", "triangle" };
//foreach (var obj in objs)
//{
//    Console.WriteLine($"Next Object: {obj}");
//    Console.WriteLine(square.Execute(obj));
//}
//--------------------------------------------------------------
//using Command;
//var invoker = new Invoker(new PrintCommand("printing"));
//invoker.ExecuteCommand();
//invoker = new Invoker(new AddCommand(new Reciever(), 1, 2));
//invoker.ExecuteCommand();
//--------------------------------------------------------------
using Iterator;
var collection = new StringCollection();
collection.AddItem("item1");
collection.AddItem("item2");
collection.AddItem("item3");
var iterator = collection.GetEnumerator();
iterator.MoveNext();
Console.WriteLine((string) iterator.Current);
iterator.MoveNext();
iterator.MoveNext();
iterator.MoveNext();
Console.WriteLine((string)iterator.Current);
Console.ReadKey();
