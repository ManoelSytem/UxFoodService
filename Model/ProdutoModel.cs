﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UxFoodService.Model
{
    public class ProdutoModel
    {
        public int codigo { get; set; }
        public string nome { get; set; }
        public string descricao { get; set; }
        public decimal valor { get; set; }
        public string valorDecimal { get; set; }

    }
}
