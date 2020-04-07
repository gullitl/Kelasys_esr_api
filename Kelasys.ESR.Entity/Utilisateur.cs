using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Kelasys.ESR.Entity {
    public class Utilisateur {
        [Key]
        public string NomUtilisateur { get; set; }
        public string MotDePasse { get; set; }
        public int MembreId { get; set; }
        public Membre Membre { get; set; }
    }
}
