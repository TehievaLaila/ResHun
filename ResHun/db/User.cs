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
    
    public partial class User
    {
        public User()
        {
            this.Authorization = new HashSet<Authorization>();
            this.OrderDish = new HashSet<OrderDish>();
            this.Reservation = new HashSet<Reservation>();
            this.Review = new HashSet<Review>();
        }
    
        public int ID_User { get; set; }
        public string FirstName { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public byte[] Image { get; set; }
    
        public virtual ICollection<Authorization> Authorization { get; set; }
        public virtual ICollection<OrderDish> OrderDish { get; set; }
        public virtual ICollection<Reservation> Reservation { get; set; }
        public virtual ICollection<Review> Review { get; set; }
    }
}
