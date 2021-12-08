using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;

namespace Shop.Model.Goods
{
    public class CityModel : BasicAggregateRoot<Guid>
    {
        public Guid FatherId { get; set; }
        public string CityName { get; set; }

    }
}
