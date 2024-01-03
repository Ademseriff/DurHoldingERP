using DurHoldingErp.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DurHoldingErp.Entity.Entities
{
    /// <summary>
    /// entity sınıf müşteri 
    /// </summary>
    public class Employee : EntityBase
    {
     
        public string Name { get; set; }

        public string Surname { get; set; }

        public int Age { get; set; }


        public Guid DepartmentId { get; set; }

        public Department Department { get; set; }
    }
}
