using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Kelasys.ESR.Entity {
    [Table("institution")]
    public class Institution : EntityBase {
        public string Nom { get; set; }
        public string Sigle { get; set; }
        public string Logo { get; set; }
    }
}
