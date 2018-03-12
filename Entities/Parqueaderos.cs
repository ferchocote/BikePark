namespace Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Parqueaderos
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Parqueaderos()
        {
            Lugares = new HashSet<Lugares>();
        }

        [Key]
        [Column(TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal parkID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? sedID { get; set; }

        [StringLength(50)]
        public string park_nombre { get; set; }

        public int? park_cantidad { get; set; }

        [StringLength(5)]
        public string park_estado { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Lugares> Lugares { get; set; }

        public virtual Sedes Sedes { get; set; }
    }
}
