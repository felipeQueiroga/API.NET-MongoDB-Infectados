using System;
using System.ComponentModel.DataAnnotations;

namespace Api.Models
{
    public class InfectadoDto
    {
        [Required(ErrorMessage = "A Data de nascimento é obrigatória")]
        public DateTime DataNascimento { get; set; }
        [Required(ErrorMessage = "O Sexo é obrigatório")]
        public string Sexo { get; set; }
        [Required(ErrorMessage = "A Latirude é obrigatória")]
        public double Latitude { get; set; }
        [Required(ErrorMessage = "A Longitude é obrigatória")]
        public double Longitude { get; set; }
    }
}