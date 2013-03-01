using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Model.MatCat
{
    [Table("Run")]
    public class TestRun
    {
        [Key]
        public int RunId { get; set; }
        public int MachineId { get; set; }
        public string DomainUrl { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
