using Kelasys.esr.Utils.Enumerations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Kelasys.esr.Models.Entities {
    [Table("utilisateur")]
    public class Utilisateur {
        [Key]
        public string NomUtilisateur { get; set; }
        public string MotDePasse { get; set; }
        public NiveauAcces NiveauAcces { get; set; }

    }
}
