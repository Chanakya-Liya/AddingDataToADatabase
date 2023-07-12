using EntityFramework.Models;
using EntityFramework.Data;

using ContosoPizzaContext context = new ContosoPizzaContext();

Customer emily = new Customer()
{
    FirstName = "Emily",
    LastName  = "Watson",
    Address = "Adc Street",
    Phone = "12345",
    Email = "12345@mail.com",
};
context.Customers.Add(emily);

Customer jake = new Customer()
{
    FirstName = "Jake",
    LastName = "Johnson",
    Address = "Bcd Street",
    Phone = "1212",
    Email = "1212@mail.com",
};
context.Customers.Add(jake);

Customer peter = new Customer()
{
    FirstName = "Peter",
    LastName = "Pan",
    Address = "Cde Street",
    Phone = "12345678",
    Email = "12345678@mail.com",
};
context.Customers.Add(peter);
context.SaveChanges();
