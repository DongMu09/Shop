using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;

namespace Shop.Model.Goods
{
    public class OrdersModel : BasicAggregateRoot<Guid> //订单
    {
        //收件人姓名
        public string Name { get; set; }
        //收件人电话
        public string Phone { get; set; }

        //收件人城市
        public int CityId { get; set; }
        //收件人详细地址
        public string Address { get; set; }
        //是否默认
        public string IsDet { get; set; }

        public Guid GoodsID { get; set; } //商品id
    }
}
