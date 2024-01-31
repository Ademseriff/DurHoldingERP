using DurHoldingErp.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DurHoldingErp.Entity.Entities
{
    public class Users : EntityBase
    {
        public string Name { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public string  Role { get; set; }
    }
}
