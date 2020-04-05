using System;
using System.Collections.Generic;
using System.Text;

namespace Kelasys.ESR.Entity {
    public class Membre : EntityBase{
        public string Nom { get; set; }
        public string Postnom { get; set; }
        public string Prenom { get; set; }
        public string Photo { get; set; }
        public string Email { get; set; }
    }
}
