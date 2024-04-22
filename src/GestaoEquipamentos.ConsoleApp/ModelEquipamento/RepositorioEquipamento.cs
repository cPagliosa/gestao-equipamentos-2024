using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestaoEquipamentos.ConsoleApp.ModelPrincipal;

namespace GestaoEquipamentos.ConsoleApp.ModelEquipamento
{
    public class RepositorioEquipamento
    {
        //responsavel por cadastrar um novo equipamento
        public void Cadastro()
        {
            Console.Clear();
            Console.Write("** Cadastro de Equipamento **\n\n" +
                "Informe o nome do equipamento: ");
            string nome = Console.ReadLine();
            if (nome.Length >= 6)
            {
                Console.Write("Informe o preço do equipamento: ");
                decimal preco = Convert.ToDecimal(Console.ReadLine());

                Console.Write("Informe o numero de serie: ");
                string numero = Console.ReadLine();

                Console.Write("Informe a data de fabricação do equipamento: ");
                string data = Console.ReadLine();

                Console.Write("Informe o fabricante do equipamento: ");
                string fabricante = Console.ReadLine();

                Equipamento equipamento = new Equipamento(GerarId(), nome, fabricante, data, numero, preco);


                Program.listaEquipamento.AddFirst(equipamento);

                MostrarMsgVerde("Cadastro realizado com sucesso");
                Pausa();


            }
            else
            {
                MostrarMsgAmarela("Nome Invalido! Tem que possuir mais que 5 caracteres");
                Pausa();
            }
        }

        //responsavel em mostrar a lista toda
        public void MostrarLista()
        {
            Console.Clear();
            Console.WriteLine("** Lista de Equipamentos **\n");

            if (Program.listaEquipamento.Count == 0)
            {
                Console.WriteLine("Nem um Equipamento cadastrado");
                this.Pausa();
            }

            Console.WriteLine(
                "{0, -10} | {1, -15}| {2,-10} | {3, -15} | {4, -10} | {5, -10}",
                "Id", "Nome", "Num Serie", "Fabricante", "Preço", "Data de Fabricação", ConsoleColor.Red
            );
            Console.WriteLine("--------------------------------------------------------------------------------------------");
            foreach (var equip in Program.listaEquipamento)
            {
                Console.WriteLine(
                "{0, -10} | {1, -15}| {2,-10} | {3, -15} | {4, -10} | {5, -10}",
                equip.Id, equip.Nome, equip.Serie, equip.Frabricante, equip.Preco, equip.DataFabricacao);
                Console.WriteLine("--------------------------------------------------------------------------------------------");

            }
            Pausa();
        }

        //responsavel em editar
        public void Editar()
        {
            Console.Clear();
            Console.WriteLine("** Editar Equipamentos **\n");

            Console.Write("Informe o id do equipamento a ser editado: ");
            int i = Convert.ToInt32(Console.ReadLine());

            foreach (var equip in Program.listaEquipamento)
            {
                if (i == equip.Id)
                {
                    Console.Write("\nInforme o nome do equipamento: ");
                    equip.Nome = Console.ReadLine();
                    if (equip.Nome.Length >= 6)
                    {
                        Console.Write("Informe o preço do equipamento: ");
                        equip.Preco = Convert.ToDecimal(Console.ReadLine());

                        Console.Write("Informe o numero de serie: ");
                        equip.Serie = Console.ReadLine();

                        Console.Write("Informe a data de fabricação do equipamento: ");
                        equip.DataFabricacao = Console.ReadLine();

                        Console.Write("Informe o fabricante do equipamento: ");
                        equip.Frabricante = Console.ReadLine();

                        MostrarMsgVerde("Edição concluida co sucesso");
                        Pausa();
                        break;

                    }
                    else
                    {
                        MostrarMsgAmarela("Nome Invalido! Tem que possuir mais que 5 caracteres");
                        Pausa();
                    }
                }
            }
        }

        //responsavel por deletar
        public void Remover()
        {
            Console.Clear();
            Console.WriteLine("** Remover Equipamentos **\n");
            Console.Write("Informe o id do equipamento a ser deletado: ");
            int i = Convert.ToInt32(Console.ReadLine());

            foreach (var equip in Program.listaEquipamento)
            {
                if (i == equip.Id)
                {
                    Program.listaEquipamento.Remove(equip);
                    MostrarMsgVerde("Remocao concluida com sucesso!!");
                    Pausa();
                    break;
                }
            }

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
