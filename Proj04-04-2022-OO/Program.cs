// See https://aka.ms/new-console-template for more information
using Model;

Console.WriteLine("Hello, World!");

Client c1 = new Client()
{
    Id = 1,
    Name = "Teste",
    Telephone = "15 4444-3333"
};

Client c2 = new Client()
{
    Id = 2,
    Name = "Teste2",
    Telephone = "14 7744-3333"
};

Employee e1 = new Employee()
{
    Id = 1,
    Name = "Empl 1",
    Telephone = "12 0000-3333"
};

Employee e2 = new Employee()
{
    Id = 2,
    Name = "Empl 2",
    Telephone = "77 1211-3333"
};

//Declarando as listas
List<Client> clients = new List<Client>();
List<Employee> employees = new List<Employee>();

//Atribuindo os objetos as listas
clients.Add(c1);
clients.Add(c2);    
employees.Add(e1);
employees.Add(e2);

//Incluindo as listas no objeto Hotel
Hotel hotel = new Hotel()
{
    Client = clients,
    Employee = employees
};

//Imprimir os dados 
Console.WriteLine(hotel.getClient());
Console.WriteLine(hotel.getEmployee());
