using Microsoft.Extensions.Options;
using TSCars.Data;
using TSCars.Entities;
using TSCars.Repositories;

var employeeRepository = new SqlRepository<Employee>(new TSCarsDbContext());
var bussinessPartnersRepository = new SqlRepository<BussinessPartners>(new TSCarsDbContext());

AddBussinessPartners(bussinessPartnersRepository);
AddEmployee(employeeRepository);
AddManager(employeeRepository);
WriteAllToConsole(employeeRepository);
WriteAllToConsole(bussinessPartnersRepository);


static void AddBussinessPartners(IWriteRepository<BussinessPartners> bussinessPartners)
{
    bussinessPartners.Add(new BussinessPartners { Name = "Susspension King", OwnerName = "Sebastian", ComtactNumber = "093214532", Description = "Susspension for van" });
    bussinessPartners.Save();
}
static void AddManager(IWriteRepository<Manager> managerRepository)
{
    managerRepository.Add(new Manager { FirstName = "Sebastian", LastName = "xyz" });
    managerRepository.Add(new Manager { FirstName = "Piotr", LastName = "xyz" });
    managerRepository.Save();
}


static void AddEmployee(IWriteRepository<Employee> employeeRepository)
{
    employeeRepository.Add(new Employee { FirstName = "Dominik", LastName = "xyz" });
    employeeRepository.Add(new Employee { FirstName = "Adam", LastName = "xyz" });
    employeeRepository.Save();
}

void WriteAllToConsole(IReadRepository<IEntity> repository)
{
    var items = repository.GetAll();
    foreach (var item in items)
    {
        Console.WriteLine(item);
    }

}
