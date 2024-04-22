using GestaoEquipamentos.ConsoleApp.ModelEquipamento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoEquipamentos.ConsoleApp.ModelChamada
{
    public class TelaChamado
    {
        //variaveis da classe
        private int id;
        private RepositorioChamado chama = new RepositorioChamado();

        //contrutor
        public TelaChamado() { }

        //responsavel por mostrar o menu
        public void Iniciar()
        {
            while (true)
            {
                Console.Clear();
                Console.Write("** Gestão de Chamados **\n\n" +
                                "1. Cadastrar novo Chamado\n" +
                                "2. Visualizar todos os Chamados \n" +
                                "3. Editar chamado\n" +
                                "4. Remover Chamado\n" +
                                "5. Sair\n\n" +
                                "Qual sua escolha: ");
                id = Convert.ToInt32(Console.ReadLine());
                if (id == 5) break;
                this.Controlhe(id);
            }

        }

        //responsavel por fazer o controlhe de qual opcao o usuario escolheu
        private void Controlhe(int id)
        {
            switch (id)
            {
                case 1:
                    this.chama.Cadastro();
                    break;

                case 2:
                    this.chama.MostrarLista();
                    break;

                case 3:
                    this.chama.Editar();
                    break;

                case 4:
                    this.chama.Remover();
                    break;

            }
        }
    }
}
