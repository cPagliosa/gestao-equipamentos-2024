namespace GestaoEquipamentos.ConsoleApp
{
    internal class Program
    {
        public static LinkedList<Equipamento> listaEquipamentos = new LinkedList<Equipamento>();
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();

                Controller_Menu_Principal menu_Principal = new Controller_Menu_Principal();

                menu_Principal.Iniciar();

                Console.WriteLine("\n\nVocê tem certeza que quer sair?\n[1] Sim   [2] Não");
                Console.Write("Qual a sua escolha: ");
                int h = Convert.ToInt32(Console.ReadLine());
                if (h == 1) break;
            }
            
        }
    }
}
