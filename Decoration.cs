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
    
    public partial class Decoration
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Decoration()
        {
            this.Custom_cake = new HashSet<Custom_cake>();
        }
    
        public int ID_decoration { get; set; }
        public Nullable<int> ID_nuts { get; set; }
        public Nullable<int> ID_berries { get; set; }
    
        public virtual Berries Berries { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Custom_cake> Custom_cake { get; set; }
        public virtual Nuts Nuts { get; set; }
    }
}