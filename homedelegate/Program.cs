using homedelegate.Model;

List<Person> persons = new List<Person>
            {
            new Person { Name="name1",Surname="surname1",Adress="adres1",Salary = 1000},
            new Person { Name="name2",Surname="surname2",Adress="adres2",Salary = 4000},
            new Person { Name="name3",Surname="surname3",Adress="adres3",Salary = 500},
            };

List<Person> changePerson(persons,p=>p.Salary>1000)


            foreach (Person person in persons)
{
    Console.WriteLine($"Name:{person.Name},Surname:{person.Surname},Adress:{person.Adress}");
}
