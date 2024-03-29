﻿
using Business.Abstaract;
using Business.Concrete;
using Entities.Concrete;
using Workspace;

static void SelamVer(string Name = "Misafir Kullanıcı")
{
    Console.WriteLine("Merhaba " + Name);
}

static int Topla(int sayi1, int sayi2)
{
    return sayi1 + sayi2;
}


SelamVer("Emirhan");
SelamVer("Ahmet");
SelamVer("Ali");
SelamVer();

Console.WriteLine("Sonuç: " + Topla(3, 5));

// ---------------------------------------


Person person1 = new Person()
{
    FirstName = "Emirhan",
    LastName = "Doğan",
    NationalIdentity = 5555555555,
    DateOfBirth = new DateTime(2002, 10 ,5)
};

Person person2 = new Person()
{
    FirstName = "Ali",
    LastName = "Ak",
    NationalIdentity = 4444444444,
    DateOfBirth = new DateTime(2005, 5, 5)
};

person1 = person2;
person2.NationalIdentity = 0;
Console.WriteLine(person1.NationalIdentity);
// ----------------------------------


List<string> sehirler = new List<string>() { "İstanbul", "Bursa", "Adana", "Ankara" };
sehirler.Add("Kocaeli");

foreach (var sehir in sehirler)
{
    Console.WriteLine(sehir);
}

// ----------------------------------
// Ödev
MyList<int> list = new MyList<int>(1, 2, 3 );
list.Add(323);
list.Add(2);
list.Add(23);
list.Add(46);

foreach (var item in list.GetAll())
{
    Console.WriteLine(item);
}
// Ödev Son

// ------------------------------------

ISupplierService<Person> supplierservice1 = new PttManager<Person>(new PersonManager());

supplierservice1.GiveMask(new Person()
{
    NationalIdentity = 24243234,
    FirstName = "Eren",
    LastName = "Bil",
    DateOfBirth = new DateTime(2001, 10, 5)
});

ISupplierService<Foreign> supplierservice2 = new PttManager<Foreign>(new ForeignerManager());

supplierservice2.GiveMask(new Foreign()
{
    NationalIdentity = 24243234,
    FirstName = "Eren",
    LastName = "Bil",
    DateOfBirth = new DateTime(2001, 10, 5)
});