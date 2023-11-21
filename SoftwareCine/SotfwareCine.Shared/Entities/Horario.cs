using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace SotfwareCine.Shared.Entities
{
   
        public class Horario
        {
        [Key]
        public int IdHorario { get; set; }

        [Display(Name = "Horario")]

        public DateTime Hhorario { get; set; }
        //public int IdTeatro { get; set; }
        //public Teatro Teatro { get; set; }

        public Horario(DateTime horario)
        {
            Hhorario = horario;
        }

        public Horario() { }
    }
    }




