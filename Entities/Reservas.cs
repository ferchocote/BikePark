namespace Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Reservas
    {
        [Key]
        [Column(TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal resID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? lugID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? usuID { get; set; }

        [StringLength(5)]
        public string res_estado { get; set; }

        public virtual Usuarios Usuarios { get; set; }
    }
}
