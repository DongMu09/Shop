using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Model
{
    public class TodoItem : Volo.Abp.Domain.Entities.BasicAggregateRoot<Guid>
    {
        public string Text { get; set; }
        
    }
}
