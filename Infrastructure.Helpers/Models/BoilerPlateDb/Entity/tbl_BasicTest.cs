using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Helpers.Models.BoilerPlateDb.Entity
{
    public class tbl_BasicTest
    {
        [Key]
        public int id { get; set; }
        public string? Name { get; set; }
        public string? Country { get; set; }
        public DateTime? SysDate { get; set; }
    }
}
