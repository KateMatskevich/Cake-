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
    
    public partial class Category
    {
        public int ID_category { get; set; }
        public Nullable<int> ID_Custom_cake { get; set; }
        public Nullable<int> ID_Catalog { get; set; }
        public Nullable<int> Is_cust { get; set; }
    
        public virtual Catalog Catalog { get; set; }
        public virtual Custom_cake Custom_cake { get; set; }
    }
}
