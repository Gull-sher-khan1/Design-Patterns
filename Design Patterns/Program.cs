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
using LiskovSubstitutionPrinciple;
Cat t = new Tiger();
t.MakeSound();
Console.ReadKey();