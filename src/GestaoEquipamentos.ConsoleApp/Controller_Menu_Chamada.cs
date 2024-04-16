using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoEquipamentos.ConsoleApp
{
    internal class Controller_Menu_Chamada
    {
        //variaveis da classe
        private int id;

        //contrutor
        public Controller_Menu_Chamada() { }

        //metado responsavel por mostrar o menu
        public void Iniciar()
        {
            while (true)
            {
                Console.Clear();
                Console.Write("**Gestão de Equipamentos **\n\n" +
                                "1. Controlhe de Equipamentos\n" +
                                "2. Controlhe de Chamada\n" +
                                "3. Sair\n" +
                                "Qual sua escolha: ");
                id = Convert.ToInt32(Console.ReadLine());
                if (id == 3) break;
                this.Controller(id);
            }

        }

        private void Controller(int id)
        {
            switch (id)
            {
                case 1:

                    break;
            }
        }
    }
}
