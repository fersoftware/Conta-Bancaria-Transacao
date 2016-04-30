using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avaliacao08
{
    class Transacao
    {
        private string tipo;
        private DateTime data;
        private string descricao;
        private float valor;

        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }

        public DateTime Data
        {
            get { return data; }
            set { data = value; }
        }

        public string Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }
        public float Valor
        {
            get { return valor; }
            set { valor = value; }
        }

        public Transacao(string tipo, string descricao, float valor)
        {
            this.Tipo = tipo;
            this.Data = DateTime.Now;
            this.Descricao = descricao;
            this.Valor = valor;
        }
    }
}
