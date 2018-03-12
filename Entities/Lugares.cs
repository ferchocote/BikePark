namespace Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Lugares
    {
        [Key]
        [Column(TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal lugID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? parkID { get; set; }

        [StringLength(50)]
        public string lug_nombre { get; set; }

        [StringLength(5)]
        public string lug_estado { get; set; }

        public virtual Parqueaderos Parqueaderos { get; set; }
    }
}
