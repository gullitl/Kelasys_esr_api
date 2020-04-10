
using System.ComponentModel.DataAnnotations.Schema;

namespace Kelasys.ESR.Models.Entities {
    [Table("professeur")]
    public class Professeur : Membre {
        
        public string TitreFormation { get; set; }


    }
}
