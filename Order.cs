//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cake
{
    using System;
    using System.Collections.Generic;
    
    public partial class Order
    {
        public int ID_Order { get; set; }
        public Nullable<int> ID_User { get; set; }
        public Nullable<int> ID_Promotional_Code { get; set; }
        public Nullable<decimal> Price { get; set; }
        public Nullable<int> ID_order_status { get; set; }
        public Nullable<int> ID_Order_Cake { get; set; }
    
        public virtual Order_status Order_status { get; set; }
        public virtual Order_cake Order_cake { get; set; }
        public virtual Promotional_code Promotional_code { get; set; }
        public virtual dt_user User { get; set; }
    }
}
