using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;

namespace Shop.Model.Goods
{
    public class GoodsBrand : BasicAggregateRoot<Guid> //商品品牌表
    {
        public string Brand_Name { get; set; }  //品牌名称

    }
}
