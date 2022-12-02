//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Product_market.Components
{
    using System;
    using System.Collections.Generic;
    
    public partial class Orders
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Orders()
        {
            this.Orders_Product = new HashSet<Orders_Product>();
        }
    
        public int Id { get; set; }
        public System.DateTime Date { get; set; }
        public int SumCount { get; set; }
        public int SumPrice { get; set; }
        public string ExecutionStage { get; set; }
        public int CustomerId { get; set; }
        public int ExecutorId { get; set; }
        public Nullable<int> ProcessingStageId { get; set; }
    
        public virtual Customer Customer { get; set; }
        public virtual Executor Executor { get; set; }
        public virtual ProcessingStage ProcessingStage { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Orders_Product> Orders_Product { get; set; }
    }
}
