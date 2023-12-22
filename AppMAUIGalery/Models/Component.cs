using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppMAUIGalery.Models
{
    internal class Component
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public Type Page { get; set; } // para indicar a pagina que irá ser aberta no meu detail

        //com o tipo type, nos vamos receber o tipo que é pra ser instanciado, sendo assim, so vamos instanciar quando o usuario clicar
    }
}
