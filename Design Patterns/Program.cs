﻿//using SingleResponsibilityPrinciple;
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
using Prototype;

var alex = new Person("Alex", "Smith", new Address(123, "oxford street"));
var bob = alex.DeepCopy();
bob.Names[0] = "Bob";
bob.Address.HouseNumber = 321;
Console.WriteLine(alex);
Console.WriteLine(bob);
Console.ReadKey();