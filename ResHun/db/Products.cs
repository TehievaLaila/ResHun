//------------------------------------------------------------------------------
// <auto-generated>
//    Этот код был создан из шаблона.
//
//    Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//    Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ResHun.db
{
    using System;
    using System.Collections.Generic;
    
    public partial class Products
    {
        public int ID_Products { get; set; }
        public string Name { get; set; }
        public Nullable<int> Count { get; set; }
        public Nullable<int> ID_Supliers { get; set; }
    
        public virtual Supliers Supliers { get; set; }
    }
}
