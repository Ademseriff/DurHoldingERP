using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DurHoldingErp.Core.Entities
{
    /// <summary>
    /// ortak database tanımlamalarının yapıldığı class entity katmanına bağlı.
    /// </summary>
    public abstract class EntityBase :IEntityBase
    {
        public virtual Guid Id { get; set; } = new Guid();

        public virtual DateTime CreateTime { get; set; } = DateTime.Now;

        public virtual bool? IsDeleted { get; set; } = false;
    }
}
