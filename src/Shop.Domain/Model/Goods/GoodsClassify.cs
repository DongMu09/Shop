using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;

namespace Shop.Model.Goods
{
    public class GoodsClassify : BasicAggregateRoot<Guid> //商品分类表
    {
        public string Classify_Name { get; set; }
    }
}
