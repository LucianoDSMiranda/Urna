using System;
using System.Collections.Generic;
using System.Linq;

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

            //LAMBDA
            var candidato = CandidatoList.Where(x => x.Id == voto).FirstOrDefault();

            //LINQ
            //var candidato = (from a in CandidatoList where a.Id == voto select a).FirstOrDefault();

            if (candidato != null)
            {
                candidato.Votos++;
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
