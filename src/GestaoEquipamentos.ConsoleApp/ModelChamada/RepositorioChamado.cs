using GestaoEquipamentos.ConsoleApp.ModelEquipamento;
using GestaoEquipamentos.ConsoleApp.ModelPrincipal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoEquipamentos.ConsoleApp.ModelChamada
{
    public class RepositorioChamado
    {
        //contrutor
        public RepositorioChamado() { }

        public void Cadastro()
        {
            Console.Clear();
            Console.Write("** Cadastro de Chamado **\n\n" +
                "Informe o titulo do chamado: ");
            string titulo = Console.ReadLine();
            
                Console.Write("Informe a descricao do chamado: ");
                string descricao = Console.ReadLine();

                Console.Write("Informe o id do equipamento: ");
                int idEquip = Convert.ToInt32(Console.ReadLine());
                Equipamento equip = this.PegarEquipamento(idEquip);
                if(equip == null)
                {
                MostrarMsgAmarela("Equipamento nao encontrado!!");
                Pausa();
                return;
                }
               
                Chamado chama = new Chamado(this.GerarId(),titulo,descricao,equip,this.PegarData());


                Program.listaChamada.AddFirst(chama);

                MostrarMsgVerde("Cadastro realizado com sucesso");
                Pausa();


        }

        //responsavel em mostrar a lista toda
        public void MostrarLista()
        {
            Console.Clear();
            Console.WriteLine("** Lista de chamados **\n");

            if (Program.listaChamada.Count == 0)
            {
                Console.WriteLine("Nem uma chamada cadastrada");
                this.Pausa();
            }

            Console.WriteLine(
                "{0, -10} | {1, -15}| {2,-20} |{0, -10} | {3, -15} | {4, -15}",
                "Id", "Titulo", "Decricao","Id Equipa...", "Equipamento", "Data de abertura"
            );
            Console.WriteLine("--------------------------------------------------------------------------------------------");
            foreach (var chama in Program.listaChamada)
            {
                Console.WriteLine(
                "{0, -10} | {1, -15}| {2,-20} |{0, -10} | {3, -15} | {4, -15}",
                chama.Id, chama.Titulo, chama.Descricao, chama.Equipamento.Id, chama.Equipamento.Nome,chama.Data);
                Console.WriteLine("--------------------------------------------------------------------------------------------");

            }
            Pausa();
        }

        //responsavel em editar
        public void Editar()
        {
            Console.Clear();
            Console.WriteLine("** Editar hamados **\n");

            Console.Write("Informe o id do chamado a ser editado: ");
            int i = Convert.ToInt32(Console.ReadLine());

            foreach (var chama in Program.listaChamada)
            {
                if (i == chama.Id)
                {
                    Console.Clear();
                    Console.Write("** Cadastro de Chamado **\n\n" +
                        "Informe o titulo do chamado: ");
                    chama.Titulo = Console.ReadLine();

                    Console.Write("Informe a descricao do chamado: ");
                    chama.Descricao = Console.ReadLine();

                    Console.Write("Informe o id do equipamento: ");
                    int idEquip = Convert.ToInt32(Console.ReadLine());
                    Equipamento equip = this.PegarEquipamento(idEquip);
                    if (equip == null)
                    {
                        MostrarMsgAmarela("Equipamento nao encontrado!!");
                        Pausa();
                        return;
                    }
                    chama.Equipamento = equip;

                    MostrarMsgVerde("Cadastro realizado com sucesso");
                    Pausa();
                }
            }
        }

        //responsavel por deletar
        public void Remover()
        {
            Console.Clear();
            Console.WriteLine("** Remover chamado **\n");
            Console.Write("Informe o id do chamado a ser deletado: ");
            int i = Convert.ToInt32(Console.ReadLine());

            foreach (var chama in Program.listaChamada)
            {
                if (i == chama.Id)
                {
                    Program.listaChamada.Remove(chama);
                    MostrarMsgVerde("Remocao concluida com sucesso!!");
                    Pausa();
                    break;
                }
            }

        }

        //responsavel por pegar a data e hora exata quando é realizado o cadastro de chamada
        private string PegarData()
        {
            DateTime data;
            data = DateTime.Now;
            return data.ToString();
        }

        //responsavel por percorrer a lista de equipamento e achar o escolido pelo id
        private Equipamento PegarEquipamento(int id)
        {
            foreach (var eqp in Program.listaEquipamento)
            {
                if(id == eqp.Id)
                {
                    return eqp;
                }
            }
            return null;
        }

        //repondavel por gerar um id não duplicado 
        private int GerarId()
        {
            int id = Program.listaEquipamento.Count;
            if (id != 0)
            {
                int id_max = 1;
                foreach (var equip in Program.listaEquipamento)
                {
                    if (equip.Id >= id_max)
                    {
                        id_max = equip.Id;
                    }
                }
                return id_max + 1;
            }
            else return 1;
        }

        //Metados para imprimir msgs coloridas
        private void MostrarMsgVerde(string msg)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\n{msg}\n");
            Console.ResetColor();
        }
        private void MostrarMsgAmarela(string msg)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"\n{msg}\n");
            Console.ResetColor();

        }
        private void Pausa()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("\nenter pra continuar...");
            Console.ResetColor();
            Console.ReadLine();
        }
    }
}
