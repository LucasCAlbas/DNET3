using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AAAAAAAAAAAAAAAAAAAAAAA
{
    public class Pou2
    {
        public string nome { get; set; }
        public string classe { get; set; }
        public string familia { get; set; }
        public int idade { get; set; }
        public bool estado { get; set; }
        public int fome { get; set; }
        public int forca { get; set; }

        public void Nascer(string nome, string classe, string familia, int idade, bool estado, int fome, int forca)
        {
            this.nome = nome;
            this.classe = classe;
            this.familia = familia;
            this.idade = 0;
            this.estado = true;
            this.fome = 10;
            this.forca = 10;
        }

        public void Morrer(bool estado, int forca)
        {
            this.estado = false;
            this.forca = 0;
        }

        public void Comer(bool estado, int forca, int fome)
        {
            if (estado)
            {
                if (fome < 100)
                {
                    Console.WriteLine("O rapaz se alimentou com os corpos de suas vítimas!");
                    fome += 10;
                    forca -= 2;

                    if (fome > 100)
                    { fome = 100; }
                }
                else { Console.WriteLine("O rapaz está cheio!"); }
            }
            else { Console.WriteLine("O rapaz não consegue comer porque está morto!"); }
        }
        public void Correr(bool estado, int forca, int fome)
        {
            if (estado)
            {
                if (forca < 5)
                {
                    Console.WriteLine("O rapaz foi perseguir morador de rua!");
                    forca -= 5;
                    fome -= 5;

                    Random random = new Random();
                    random.Next(0, 100);
                    var Chance = random.Next();

                    if (Chance >= 90)
                        Console.WriteLine("O amigo foi atropelado!");
                        estado = !estado;
                }
                else { Console.WriteLine("O rapaz está exausto"); }
            }
            else { Console.WriteLine("ele tá morto :("); }
        }
        public void Dormir(bool estado, int forca, int fome) 
        {
            if (estado)
            {
                Console.WriteLine("Fois as mimir :3");
                forca += 10;
                fome -= 2;
            }
            else { Console.WriteLine("Tá moito ainda :("); }
        }
    }
}
