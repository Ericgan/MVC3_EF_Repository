using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Model
{
    [Table("O_PkgOrder")]
    public class PkgOrder
    {
        [Key]
        public int OrderId { get; set; }
    }
}
