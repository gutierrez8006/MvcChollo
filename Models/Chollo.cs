using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MvcChollos2.Models
{
    [Table("CHOLLOS")]
    public class Chollo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column("IDCHOLLO")]
        public int IdChollo { get; set; }

        [Column("TITULO")]
        public String Titular { get; set; }

        [Column("ENLACE")]
        public String Enlace { get; set; }

        [Column("DESCRIPCION")]
        public String Descripcion { get; set; }

        [Column("FECHA")]
        public DateTime Fecha { get; set; }

        [Column("CATEGORIA")]
        public String Categoria { get; set; }
    }
}