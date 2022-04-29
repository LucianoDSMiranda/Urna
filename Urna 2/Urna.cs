using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Urna_2
{
    internal class Urna
    {
        public static List<Candidato> CandidatoList = new List<Candidato>();


        public static void Inserir(Candidato candidato)
        {

            Console.WriteLine("digite o nome do Candidato");
            candidato.Nome = Console.ReadLine();
            Console.WriteLine("digite o Partido do Candidato");
            candidato.Partido = Console.ReadLine();
            Console.WriteLine("digite o Sigla do Candidato");
            candidato.Sigla = Console.ReadLine();
            Console.WriteLine("digite o ID do Candidato");
            candidato.Id = int.Parse(Console.ReadLine());
            CandidatoList.Add(candidato);
            Console.Clear();
            Console.WriteLine("Candidato Cadastrado!");
        }
        public void Listar()
        {
            foreach (Candidato c in CandidatoList)
            {
                Console.WriteLine("Candidato: " + c.Nome + " / partido: " + c.Partido + " / Sigla: " + c.Sigla + " / Id: " + c.Id + " / Votos =" + c.Votos);
            }


        }

        public void Votar()
        {
            Console.WriteLine("digite o ID do Candidato:");
            int voto = int.Parse(Console.ReadLine());
            //var achou = CandidatoList.Where(x => x.Id == voto).ToList();

            //if (achou.Count() > 0)                
            //    Console.WriteLine("certo");          

            //else            
            //    Console.WriteLine("errado");
            bool achou = false;
            foreach (var item in CandidatoList)
            {
                if (item.Id == voto)                
                    achou = true;              
                              
            }
            if (achou)
            {
                Console.Clear();
                Console.WriteLine("Voto computado!");             
                                             

            }

            else

                Console.WriteLine("Id não encontrado!");


        }


        public void Resultado()
        {
            foreach (Candidato c in CandidatoList)
            {
                Console.WriteLine("Candidato: " + c.Nome + " / Votos =" + c.Votos);
            }

        }
    }
}
