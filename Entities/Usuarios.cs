namespace Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Usuarios
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Usuarios()
        {
            Reservas = new HashSet<Reservas>();
        }

        [Key]
        [Column(TypeName = "numeric")]
        public decimal usuID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? tipoUsuID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? tipDocID { get; set; }

        [StringLength(50)]
        public string usu_nombre { get; set; }

        public DateTime? usu_fec_nacimiento { get; set; }

        [StringLength(50)]
        public string usu_num_doc { get; set; }

        [StringLength(5)]
        public string usu_estado { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Reservas> Reservas { get; set; }

        public virtual TipoDocumentos TipoDocumentos { get; set; }

        public virtual TipoUsuarios TipoUsuarios { get; set; }
    }
}
