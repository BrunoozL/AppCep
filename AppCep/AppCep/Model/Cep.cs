﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AppCep.Model
{
    public class Cep
    {
        public int cep { get; set; }
        public int id_logradouro { get; set; }
        public string tipo { get; set; }
        public string descricao { get; set; }
        public int id_cidade { get; set; }
        public string uf { get; set; }
        public string complemento { get; set; }
        public string descricao_sem_numero { get; set; }
        public string descricao_cidade { get; set; }
        public int codigo_cidade_ibge { get; set; }
        public string descricao_bairro { get; set; }
    }
}
