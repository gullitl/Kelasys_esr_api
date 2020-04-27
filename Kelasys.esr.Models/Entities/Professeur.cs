
using System.ComponentModel.DataAnnotations.Schema;

namespace Kelasys.esr.Models.Entities {
    [Table("professeur")]
    public class Professeur : Membre {
        
        public string TitreFormation { get; set; }


    }
}
