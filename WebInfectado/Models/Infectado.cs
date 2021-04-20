using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WebInfectado.Enum;

namespace WebInfectado.Models
{
    public class Infectado
    {
        public Infectado( DateTime dataNascimento, string sexo, double latitude, double longitude)
        {
            Id = 2;
            DataNascimento = dataNascimento;
            Sexo = sexo;
            Latitude = latitude;
            Longitude = longitude;
        }
        [ScaffoldColumn(false)]
        public int Id { get; set; }
        [DisplayName("Data Nascimento")]
        public DateTime DataNascimento { get; set; }
        public string Sexo { get; set; }
        public double Latitude { get; set; }        
        public double Longitude { get; set; }
    }

}
