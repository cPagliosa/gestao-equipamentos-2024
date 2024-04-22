using GestaoEquipamentos.ConsoleApp.ModelChamada;
using GestaoEquipamentos.ConsoleApp.ModelEquipamento;
using System.Collections;

namespace GestaoEquipamentos.ConsoleApp.ModelPrincipal
{
    public class Program
    {
        //lista responsavel por guardar a lista de equipamentos
        public static LinkedList<Equipamento> listaEquipamento = new LinkedList<Equipamento>();
        //lista responsavel por guardar a lista de chamadas
        public static LinkedList<Chamado> listaChamada = new LinkedList<Chamado>();
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();

                TelaPrincipal tela_Principal = new TelaPrincipal();

                tela_Principal.Iniciar();

                Console.WriteLine("\n\nVocê tem certeza que quer sair?\n[1] Sim   [2] Não");
                Console.Write("Qual a sua escolha: ");
                int h = Convert.ToInt32(Console.ReadLine());
                if (h == 1) break;
            }

        }
    }
}
