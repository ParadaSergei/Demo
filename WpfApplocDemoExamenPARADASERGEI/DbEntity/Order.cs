//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WpfApplocDemoExamenPARADASERGEI.DbEntity
{
    using System;
    using System.Collections.Generic;
    
    public partial class Order
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Order()
        {
            this.Product = new HashSet<Product>();
        }
    
        public int ID { get; set; }
        public string Compound { get; set; }
        public System.DateTime DeliveryOrder { get; set; }
        public System.DateTime DeliveryDate { get; set; }
        public int PickupPoint { get; set; }
        public int UserDataForOrderID { get; set; }
        public int StatusID { get; set; }
    
        public virtual OrderPoint OrderPoint { get; set; }
        public virtual StatusOrder StatusOrder { get; set; }
        public virtual UserData UserData { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Product> Product { get; set; }
    }
}