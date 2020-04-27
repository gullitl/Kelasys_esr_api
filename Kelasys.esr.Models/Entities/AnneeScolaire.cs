using Kelasys.esr.Utils.Enumerations;
using Kelasys.esr.Utils.Extentions;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Kelasys.esr.Models.Entities {
    [Table("anneescolaire")]
    public class AnneeScolaire {
        [Key, Column(Order = 0)]
        public AnneeEnseignement AnneeEnseignement { get; set; }

        [Key, Column(Order = 1)]
        public NiveauxEnseignement NiveauxEnseignement { get; set; }
        public string Description { get; set; }

        public IEnumerable<Eleve> Eleves { get; set; }

        public override string ToString() {
            return $"{Extention.GetEnumDescription(AnneeEnseignement)} {Extention.GetEnumDescription(NiveauxEnseignement)}";
        }
    }
}
