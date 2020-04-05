using Kelasys.ESR.Utils.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kelasys.ESR.Entity {
    public class AnneeScolaire {
        public AnneeEnseignement AnneeEnseignement { get; set; }
        public Enseignement Enseignement { get; set; }
        public string Description { get; set; }
    }
}
