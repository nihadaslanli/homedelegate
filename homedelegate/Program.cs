
#region task1
//using homedelegate.Model;
//Person person1 = new Person();
//person1.Name = "Name1";
//person1.Surname = "Surname1";
//person1.Adress = "Adress1";
//person1.Salary = 1100;


//Person person2 = new Person();
//person2.Name = "Name2";
//person2.Surname = "Surname2";
//person2.Adress = "Adress2";
//person2.Salary = 5000;

//Person person3 = new Person();
//person3.Name = "Name3";
//person3.Surname = "Surname3";
//person3.Adress = "Adress3";
//person3.Salary = 800;
//List<Person> list = new List<Person>() { person1,person2,person3 };
//foreach (var item in CalculateSalary(p=>p.Salary>1000,list))
//{
//    Console.WriteLine(item);
//}


//List<Person> CalculateSalary(Predicate<Person> predicate,List<Person>list)
//{
//  return  list.FindAll(predicate);
//}
#endregion
#region task2

//using homedelegate.Model;
//List<Book> books = new()
//{
//    new Book {Id=Guid.NewGuid(),Name="Book1",AuthorName="Nizami" },
//    new Book {Id=Guid.NewGuid(),Name="Book2",AuthorName="fuzuli" },
//    new Book {Id=Guid.NewGuid(),Name="Book3",AuthorName="Nizami" }


//};
//Console.WriteLine(FindBookOfNizami(b => b.AuthorName.Equals( "Nizami"), books));
//int FindBookOfNizami(Predicate<Book> predicate, List<Book> list)
//{
//    return list.FindAll(predicate).Count;
//}



#endregion
#region task3

using homedelegate.Model;

List<Employee> emmployees = new()
{
 new(){Id=Guid.NewGuid(),Name="name1",Age=16,Salary=1500 },
 new(){Id=Guid.NewGuid(),Name="name2",Age=21,Salary=2500 },
 new(){Id=Guid.NewGuid(),Name="name3",Age=19,Salary=3500 },
 new(){Id=Guid.NewGuid(),Name="name4",Age=49,Salary=3500 },
};
var newList = emmployees.FindAll(e=>e.Age > 20 && e.Age < 40);
var sumSalary=newList.Sum(e=>e.Salary);
var minSalary=newList.Min(e=>e.Salary);
var maxSalary=newList.Max(e=>e.Salary);
var avrSalary=newList.Average(e=>e.Salary);
Console.WriteLine(avrSalary);

#endregion



