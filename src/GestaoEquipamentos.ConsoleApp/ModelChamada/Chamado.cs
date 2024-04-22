using GestaoEquipamentos.ConsoleApp.ModelEquipamento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoEquipamentos.ConsoleApp.ModelChamada
{
    public class Chamado
    {
        //Variaveis
        private int id;
        private string titulo;
        private string descricao;
        private Equipamento equipamento;
        private string data;

        //costrutor
        public Chamado(int id, string titulo, string descricao, Equipamento equipamento, string data)
        {
            this.Id = id;
            this.Titulo = titulo;
            this.Descricao = descricao;
            this.Equipamento = equipamento;
            this.Data = data;
        }

        //gets e sets
        public int Id { get => id; set => id = value; }
        public string Titulo { get => titulo; set => titulo = value; }
        public string Descricao { get => descricao; set => descricao = value; }
        public Equipamento Equipamento { get => equipamento; set => equipamento = value; }
        public string Data { get => data; set => data = value; }
    }
}
