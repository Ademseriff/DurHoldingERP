using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DurHoldingErp.Core.Entities
{
    public abstract class EntityBase :IEntityBase
    {
        public virtual Guid Id { get; set; } = new Guid();

        public virtual DateTime CreateTime { get; set; } = DateTime.Now;

        public virtual bool? IsDeleted { get; set; } = false;
    }
}
