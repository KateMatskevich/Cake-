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
    
    public partial class Custom_cake
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Custom_cake()
        {
            this.Category = new HashSet<Category>();
        }
    
        public int ID_custom_cake { get; set; }
        public Nullable<int> ID_biscuit { get; set; }
        public Nullable<int> ID_cream { get; set; }
        public Nullable<int> ID_decoration { get; set; }
        public Nullable<double> Weight { get; set; }
    
        public virtual Biscuit Biscuit { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Category> Category { get; set; }
        public virtual Cream Cream { get; set; }
        public virtual Decoration Decoration { get; set; }
    }
}
