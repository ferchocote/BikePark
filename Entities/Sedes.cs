namespace Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Sedes
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Sedes()
        {
            Parqueaderos = new HashSet<Parqueaderos>();
        }

        [Key]
        [Column(TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal sedID { get; set; }

        [StringLength(50)]
        public string sed_nombre { get; set; }

        [StringLength(100)]
        public string sed_direccion { get; set; }

        [StringLength(50)]
        public string sed_latitud { get; set; }

        [StringLength(50)]
        public string sed_longitud { get; set; }

        [StringLength(5)]
        public string sed_estado { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Parqueaderos> Parqueaderos { get; set; }
    }
}
