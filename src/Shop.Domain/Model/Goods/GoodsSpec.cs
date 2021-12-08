using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;

namespace Shop.Model.Goods
{
    public class GoodsSpec : BasicAggregateRoot<Guid> //商品规格表
    {
        public string Spec_Name { get; set; } //规格名称
    }
}
