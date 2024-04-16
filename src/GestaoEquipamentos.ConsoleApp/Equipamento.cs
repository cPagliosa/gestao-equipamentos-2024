using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace GestaoEquipamentos.ConsoleApp
{
    internal class Equipamento
    {
        //variaveis da classe
        private int id;
        private string nome;
        private string frabricante;
        private string dataFabricacao;
        private int serie;
        private decimal preco;

        //costrutores
        public Equipamento(int id, string nome, string frabricante, string dataFabricacao, int serie, decimal preco)
        {
            this.Id = id;
            this.Nome = nome;
            this.Frabricante = frabricante;
            this.DataFabricacao = dataFabricacao;
            this.Serie = serie;
            this.Preco = preco;
        }

        public Equipamento() { }


        //gets e sets
        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Frabricante { get => frabricante; set => frabricante = value; }
        public string DataFabricacao { get => dataFabricacao; set => dataFabricacao = value; }
        public int Serie { get => serie; set => serie = value; }
        public decimal Preco { get => preco; set => preco = value; }

        //metados

        //responsavel por realizar o cadastro de equipamentos
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
                int numero = Convert.ToInt32(Console.ReadLine());

                Console.Write("Informe a data de fabricação do equipamento: ");
                string data = Console.ReadLine();

                Console.Write("Informe o fabricante do equipamento: ");
                string fabricante = Console.ReadLine();

                Equipamento equipamento = new Equipamento(this.GerarId(),nome,fabricante,data,numero,preco);

                Program.listaEquipamentos.AddFirst(equipamento);

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nCadastro com sucesso!!\n");
                Console.ResetColor();
                Console.Write("enter para continuar");
                Console.ReadLine();


            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("Nome Invalido!! Tem que possuir mais que 5 caracteres\n");
                Console.ResetColor();
                Console.Write("enter para continuar");
                Console.ReadLine();
            }
        }

        //responsavel em mostrar a lista toda
        public void MostrarLista()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("** Lista de Equipamentos **\n");
            Console.ResetColor();
            if(Program.listaEquipamentos.Count == 0 )
            {
                Console.WriteLine("Nem um Equipamento cadastrado");
                Console.Write("enter para continuar");
                Console.ReadLine();
            }

            foreach (var equip in Program.listaEquipamentos)
            {
                Console.WriteLine($"\n-----------------------------------------\n\n" +
                    $"Id: {equip.Id};\n" +
                    $"Nome: {equip.Nome};\n" +
                    $"Numero de serie: {equip.Serie};\n" +
                    $"Preço: {equip.Preco};\n" +
                    $"Fabricante: {equip.frabricante};\n" +
                    $"Data de fabricação: {equip.DataFabricacao}\n" +
                    $"\n-----------------------------------------\n");

                
            }
            Console.Write("enter para continuar");
            Console.ReadLine();
        }

        //responsavel em editar
        public void Editar()
        {
            Console.Clear();
            Console.WriteLine("** Editar Equipamentos **\n");

            Console.Write("Informe o id do equipamento a ser editado: ");
            int i = Convert.ToInt32(Console.ReadLine());
            
            foreach (var equip in Program.listaEquipamentos)
            {
                if(i == equip.Id)
                {
                    Console.Write("\nInforme o nome do equipamento: ");
                    equip.nome = Console.ReadLine();
                    if (equip.nome.Length >= 6)
                    {
                        Console.Write("Informe o preço do equipamento: ");
                        equip.preco = Convert.ToDecimal(Console.ReadLine());

                        Console.Write("Informe o numero de serie: ");
                        equip.serie = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Informe a data de fabricação do equipamento: ");
                        equip.dataFabricacao = Console.ReadLine();

                        Console.Write("Informe o fabricante do equipamento: ");
                        equip.frabricante = Console.ReadLine();

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("\nEdiçao concluido com sucesso!!\n");
                        Console.ResetColor();
                        Console.Write("enter para continuar");
                        Console.ReadLine();
                        break;

                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("Nome Invalido!! Tem que possuir mais que 5 caracteres\n");
                        Console.ResetColor();
                        Console.Write("enter para continuar");
                        Console.ReadLine();
                    }
                }
            }
        }

        //responsavel por deletar
        public void Remover()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("** Remover Equipamentos **\n");
            Console.ResetColor();
            Console.Write("Informe o id do equipamento a ser deletado: ");
            int i = Convert.ToInt32(Console.ReadLine());

            foreach (var equip in Program.listaEquipamentos)
            {
                if (i == equip.Id)
                {
                    Program.listaEquipamentos.Remove(equip);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\nRemocao concluida com sucesso!!\n");
                    Console.ResetColor();
                    Console.Write("enter para continuar");
                    Console.ReadLine();
                    break;
                }
            }
                    
        }

        //repondavel por gerar um id não duplicado 
        private int GerarId()
        {
            int id = Program.listaEquipamentos.Count;
            if (id != 0)
            {
                int id_max = 1;
                foreach (var equip in Program.listaEquipamentos)
                {
                    if (equip.id >= id_max)
                    {
                        id_max = equip.id;
                    }
                }
                return id_max+1;
            } else return 1;
        }

        
    }
}
