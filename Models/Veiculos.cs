using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace SistemaCadastro.Models

{

    public class Veiculos
    {

        [Display(Name = "Id")]
        public int VeiculosId { get; set; }

        [Required(ErrorMessage = "Informe a PLACA")]
        public string Placa { get; set; }

        [Required(ErrorMessage = "Informe a RENAVAM")]
        public int Renavam { get; set; }

        [Required(ErrorMessage = "Informe o CHASSI")]
        public string Chassi { get; set; }

        [Required(ErrorMessage = "Informe o MOTOR")]
        public string Motor { get; set; }

        [Required(ErrorMessage = "Informe o MARCA")]
        public string Marca { get; set; }

        [Required(ErrorMessage = "Informe a MODELO")]
        public string Modelo { get; set; }

        [Required(ErrorMessage = "Informe o tipo de COMBUSTÍVEL")]
        public string Combustivel { get; set; }

        [Required(ErrorMessage = "Informe o tipo de COR")]
        public string Cor { get; set; }

        [Required(ErrorMessage = "Informe a ANO")]
        public int Ano { get; set; }

        [Required(ErrorMessage = "Informe o STATUS")]
        public string Status { get; set; }

        
    }

}