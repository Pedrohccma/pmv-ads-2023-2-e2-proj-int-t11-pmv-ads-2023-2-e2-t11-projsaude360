﻿using System;

namespace ProjetoSaude360.Models
{
    public class Cadastro
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string NomeUsuario { get; set; }
        public Enums.Genero Genero { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string Senha { get; set; }
        public Enums.Perfil Perfil { get; set; }

    }
}
