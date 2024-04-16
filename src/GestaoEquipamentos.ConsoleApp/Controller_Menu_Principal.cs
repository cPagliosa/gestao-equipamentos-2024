using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoEquipamentos.ConsoleApp
{
    internal class Controller_Menu_Principal
    {
        //variaveis da classe
        private int id;

        //contrutor
        public Controller_Menu_Principal() { }

        //metados

        //responsavel por mostrar o menu
        public void Iniciar()
        {
            while (true)
            {
                Console.Clear();
                Console.Write("** Gestão de Equipamentos **\n\n" +
                                "1. Controlhe de Equipamentos\n" +
                                "2. Controlhe de Chamada\n" +
                                "3. Sair\n\n" +
                                "Qual sua escolha: ");
                id = Convert.ToInt32(Console.ReadLine());
                if (id == 3) break;
                this.Controller(id);
            }

        }
        //responsavel por fazer o controlhe de qual opcao o usuario escolheu
        private void Controller(int id)
        {
            switch (id)
            {
                case 1:
                    Controller_Menu_Equipamento equip = new Controller_Menu_Equipamento();
                    equip.Iniciar();
                    break;
                case 2:
                    Controller_Menu_Chamada chama = new Controller_Menu_Chamada();
                    chama.Iniciar();
                    break;
            }
        }

        
    }
}
