using System;
using System.Collections.Generic;

namespace UrnaEletronica
{
    internal class Program
    {
        static void Main(string[] args)
        {

            
            {
                
                string opcao;
                opcao = "0";
               
                Urna urna = new Urna();

                Candidato candidato = new Candidato();


                while (opcao != "5")
                {
                    


                    Console.WriteLine("o que deseja fazer?");
                    Console.WriteLine("1 - Cadastrar Candidato  2 - Ver Candidadtos  3 - Votar  4 - Ver Resultado  5 - Sair");
                    opcao = Console.ReadLine();

                    switch (opcao)
                    {
                        case "1":
                            Candidato ca = new Candidato();
                            Urna.Inserir(ca);

                                break;                            

                        case "2":

                            Console.WriteLine("Os Candidatos são:");
                            urna.Listar();

                            break;

                        case "3":

                            Console.WriteLine("Os Candidatos são:");
                            urna.Votar();
                            Console.WriteLine("Digite o ID de seu Candidato:");                            
                            int voto;
                            Console.WriteLine(candidato.Id);
                            voto = int.Parse(Console.ReadLine()); 
                            Console.WriteLine(candidato.Id);
                            Console.ReadKey();
                            if (voto == candidato.Id)
                            
                                candidato.Votos++;
                           
                            else
                            
                                Console.WriteLine("Id incorreto");
                            
                            break;

                        case "4":

                            Console.WriteLine("Resultado Parcial:");
                            urna.Resultado();
                            break;

                        case "5":

                            Console.WriteLine(" até logo");
                            break;

                        default:
                            Console.WriteLine("comando nao encontrado");
                            break;

                    }

                  
                }
            }










        }

           

       
    
    }
}

