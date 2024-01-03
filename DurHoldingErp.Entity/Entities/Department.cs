using DurHoldingErp.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DurHoldingErp.Entity.Entities
{
    /// <summary>
    /// departman tablosu.
    /// </summary>
    public class Department : EntityBase
    {
        

        public string DepartmentName { get; set; }

        public ICollection<Employee> Employees { get; set; }


    }
}
