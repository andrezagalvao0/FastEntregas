﻿using System;
using System.Collections.Generic;

namespace Persistence
{
    public partial class TbContaBancaria
    {
        public int CodConta { get; set; }
        public int Numero { get; set; }
        public int Agencia { get; set; }
        public string Tipo { get; set; }
        public int CodUsuario { get; set; }
        public int CodBanco { get; set; }

        public TbBanco CodBancoNavigation { get; set; }
        public TbUsuario CodUsuarioNavigation { get; set; }
    }
}
