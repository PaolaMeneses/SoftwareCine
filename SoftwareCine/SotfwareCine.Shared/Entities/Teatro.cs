using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SotfwareCine.Shared.Entities
{
    public class Teatro
    {
        [Key]
        public int IdTeatro { get; set; }

        [Display(Name = "Teatro")]
        [MaxLength(100, ErrorMessage = "El campo {0} debe tener máximo {1} caractéres.")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string NTeatro { get; set; } = null!;

       // public ICollection<Horario> Horarios { get; set; }
    }
}

