using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2___Rappresentare_una_persona_fisica
{
    class Persona
    {
        private int codice;
        private string cognome;
        private string nome;
        private bool registrato;
        private string risposta;

        public Persona(int codice, string cognome, string nome, string risposta)
        {
            this.codice = codice;
            this.cognome = cognome;
            this.nome = nome;
            this.risposta = risposta;
            registrato = false;
        }

        public void Registra()
        {
            registrato = true;
        }

        public void Mostra()
        {
            Console.WriteLine("Codice: " + codice);
            Console.WriteLine("Cognome: " + cognome);
            Console.WriteLine("Nome: " + nome);
            Console.WriteLine("Registrato: " + risposta, registrato ? "Sì" : "No");
        }
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("Inserisci i dati della persona:");

            Console.Write("Codice: ");
            int codice = Convert.ToInt32(Console.ReadLine());

            Console.Write("Cognome: ");
            string cognome = Console.ReadLine();

            Console.Write("Nome: ");
            string nome = Console.ReadLine();

            Console.Write("Vuoi registrare la persona? (Sì/No): ");
            string risposta = Console.ReadLine();

            Persona persona1 = new Persona(codice, cognome, nome, risposta);
            Console.Clear();

            if (risposta.ToLower() == "sì")
            {
                persona1.Registra();
                Console.WriteLine("\nDati della persona dopo la registrazione:");
                persona1.Mostra();
            }
            else
            {
                Console.WriteLine("\nLa persona non è stata registrata.");
            }
            Console.ReadLine();
        }
    }
}
