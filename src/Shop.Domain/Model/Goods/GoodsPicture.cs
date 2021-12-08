using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;

namespace Shop.Model.Goods
{
    public class GoodsPicture : BasicAggregateRoot<Guid> //商品图片表
    {
        public string Picture_Name { get; set; } //图片名称
    }
}
