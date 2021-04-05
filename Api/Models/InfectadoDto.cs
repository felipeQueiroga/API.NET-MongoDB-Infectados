using System;
using System.ComponentModel.DataAnnotations;

namespace Api.Models
{
    public class InfectadoDto
    {
        [Required(ErrorMessage = "A Data de nascimento � obrigat�ria")]
        public DateTime DataNascimento { get; set; }
        [Required(ErrorMessage = "O Sexo � obrigat�rio")]
        public string Sexo { get; set; }
        [Required(ErrorMessage = "A Latirude � obrigat�ria")]
        public double Latitude { get; set; }
        [Required(ErrorMessage = "A Longitude � obrigat�ria")]
        public double Longitude { get; set; }
    }
}