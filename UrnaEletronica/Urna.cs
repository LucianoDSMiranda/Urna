using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UrnaEletronica
{

    public class Urna  


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

            foreach (Candidato c in CandidatoList)
            {
                Console.WriteLine("Candidato: " + c.Nome + " / Id: " + c.Id);

            }            

        }        

        public void Resultado()
        { 
            foreach (Candidato c in CandidatoList)
            {
                Console.WriteLine("Candidato: "+c.Nome+" / Votos ="+c.Votos);
            }

        }
    }
        
}



    

