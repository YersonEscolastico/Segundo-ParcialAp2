using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    [Serializable]
    public class Transacciones
    {
        [Key]
        public int TransaccionId { get; set; }
        public DateTime Fecha { get; set; }
        public string Tipo { get; set; }
        public decimal Monto { get; set; }


        public Transacciones()
        {
            TransaccionId = 0;
            Fecha = DateTime.Now;
            Tipo = string.Empty;
            Monto = 0;
        }
    }
}