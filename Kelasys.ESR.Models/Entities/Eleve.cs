
using Kelasys.ESR.Utils.Enumerations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Kelasys.ESR.Models.Entities {
    [Table("eleve")]
    public class Eleve : Membre {
        
        public AnneeEnseignement AnneeEnseignement { get; set; }

        public NiveauxEnseignement NiveauxEnseignement { get; set; }

        public AnneeScolaire AnneeScolaire { get; set; }
    }
}
