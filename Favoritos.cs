using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WIMP_Personas
{
    class Favoritos
    {
        private string linkConteudo;
        private string assunto;
        private string tipoConteudo;
        private DateTime data;

        public Favoritos(string linkConteudo, string assunto, string tipoConteudo, DateTime data)
        {
            this.linkConteudo = linkConteudo;
            this.assunto = assunto;
            this.tipoConteudo = tipoConteudo;
            this.data = data;
            
        }

        public string GetLinkConteudo()
        {
            return linkConteudo;
        }
        public string GetAssunto()
        {
            return assunto;
        }
        public string GettipoConteudo()
        {
            return tipoConteudo;
        }
        public DateTime GetData()
        {
            return data;
        }
    }
}
