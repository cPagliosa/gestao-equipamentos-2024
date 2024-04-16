﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoEquipamentos.ConsoleApp
{
    internal class Controller_Menu_Equipamento
    {
        //variaveis da classe
        private int id;
        private Equipamento equi = new Equipamento();

        //contrutor
        public Controller_Menu_Equipamento() { }

        //metados

        //responsavel por mostrar o menu
        public void Iniciar()
        {
            while (true)
            {
                Console.Clear();
                Console.Write("** Gestão de Equipamentos **\n\n" +
                                "1. Cadastrar novo Equipamento\n" +
                                "2. Visualizar todo os Equipamento \n" +
                                "3. Editar Equipamento\n" +
                                "4. Remover Equipamento\n" +
                                "5. Sair\n\n" +
                                "Qual sua escolha: ");
                id = Convert.ToInt32(Console.ReadLine());
                if (id == 5) break;
                this.Controller(id);
            }

        }

        //responsavel por fazer o controlhe de qual opcao o usuario escolheu
        private void Controller(int id)
        {
            switch (id)
            {
                case 1:
                    this.equi.Cadastro();
                    break;

                case 2:
                    this.equi.MostrarLista();
                    break;

                case 3:
                    this.equi.Editar();
                    break;

                case 4:
                    this.equi.Remover();
                    break;

            }
        }

        
    }
}
