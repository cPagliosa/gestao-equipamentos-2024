using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoEquipamentos.ConsoleApp.ModelEquipamento
{
    public class Equipamento
    {
        //variaveis da classe
        private int id;
        private string nome;
        private string frabricante;
        private string dataFabricacao;
        private string serie;
        private decimal preco;

        //Construtor
        public Equipamento(int id, string nome, string frabricante, string dataFabricacao, string serie, decimal preco)
        {
            this.id = id;
            this.nome = nome;
            this.frabricante = frabricante;
            this.dataFabricacao = dataFabricacao;
            this.serie = serie;
            this.preco = preco;
        }

        //gets e sets
        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Frabricante { get => frabricante; set => frabricante = value; }
        public string DataFabricacao { get => dataFabricacao; set => dataFabricacao = value; }
        public string Serie { get => serie; set => serie = value; }
        public decimal Preco { get => preco; set => preco = value; }
    }
}
