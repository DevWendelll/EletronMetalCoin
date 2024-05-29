using Metalcoin.Core.Abstracts;
using MetalCoin.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetalCoin.Core.Domain
{
    public class Usuario : Entidade
    {
        public string Nome { get; set; }
        public string  Email { get; set; }
        public string Senha { get; set; }
        public TipoPerfil Perfil { get; set; }
    }
}
