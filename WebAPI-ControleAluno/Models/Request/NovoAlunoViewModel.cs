﻿using System.ComponentModel.DataAnnotations;
using WebAPI_ControleAluno.Models.CustomValidation;

namespace WebAPI_ControleAluno.Models.Request
{
    public class NovoAlunoViewModel
    {
        public int Codigo { get; set; }


        [Required(ErrorMessage = "o nome é obrigatório.")]
        [MinLength(3, ErrorMessage = "O nome deve ter no mínimo 3 caracteres.")]
        public string Nome { get; set; }


        [RaValidation(ErrorMessage = "RA inválido.")]
        public string RA { get; set; }


        [EmailValidation(ErrorMessage = "E-mail inválido", EmailRequerido = false)]
        public string email { get; set; }


        [CpfValidation(ErrorMessage = "CPF inválido.")]
        public string CPF { get; set; }


        [Required(ErrorMessage = "O campo é obrigatório.")]
        public bool Ativo { get; set; }
    }
}
