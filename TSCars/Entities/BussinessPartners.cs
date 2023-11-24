using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSCars.Entities
{
    public class BussinessPartners : EntityBase
    {
        public string? Name { get; set; }
        public string? OwnerName { get; set; }
        public string? ComtactNumber { get; set; }
        public string? Description { get; set; }

        public override string ToString() => $"Id: {Id}, Name: {Name} , OwnerName: {OwnerName}, ContactNumber :{ComtactNumber} Description: {Description} ";
    }
}
