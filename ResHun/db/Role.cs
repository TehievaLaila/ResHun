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
    
    public partial class Role
    {
        public Role()
        {
            this.Authorization = new HashSet<Authorization>();
        }
    
        public int ID_Role { get; set; }
        public string Name { get; set; }
    
        public virtual ICollection<Authorization> Authorization { get; set; }
    }
}