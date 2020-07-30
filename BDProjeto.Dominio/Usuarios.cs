using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace BDProjeto.Dominio
{
    public class Usuarios
    {
        public int Id { get; set; }

        [DisplayName("Nome")]
        [Required(ErrorMessage = "Preencha o nome do usuário!")]
        public string Nome { get; set; }
        [DisplayName("Cargo")]
        [Required(ErrorMessage = "Preencha o cargo do usuário!")]
        public string Cargo { get; set; }
        [DisplayName("Data de Cadastro")]
        [Required(ErrorMessage = "Preencha a data de cadastro do usuário!")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString ="{0:dd/MM/yyyy}")]
        public DateTime Data { get; set; }
    }
}
