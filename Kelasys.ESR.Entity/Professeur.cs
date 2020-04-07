
using System.ComponentModel.DataAnnotations.Schema;

namespace Kelasys.ESR.Entity {
    [Table("professeur")]
    public class Professeur : Membre {
        public string TitreFormation { get; set; }

    }
}
