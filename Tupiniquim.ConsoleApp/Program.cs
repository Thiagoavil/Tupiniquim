using System;

namespace Tupiniquim.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string comandorecebido = "";
            string[] posicaoinicial;
            string lado = "";
            int posicaox = 0;
            int posicaoy = 0;
            int posicaoxmax = 0;
            int posicaoymax = 0;
            string[] posicaomaxt ;

            Console.Write("Digite a dimensão X Y máxima: ");
            posicaomaxt = Console.ReadLine().Split(" ");


            posicaoxmax = Convert.ToInt32(posicaomaxt[0]);
                        
            posicaoymax = Convert.ToInt32(posicaomaxt[1]);

            for (int contador = 0; contador < 2; contador++)
            {
                
                
                    Console.WriteLine("\n Projeto tupiniquim");
                    Console.WriteLine("Digite suas cordenadas: ");

                    posicaoinicial = Console.ReadLine().Split(" ");
                    

                    for (int i = 0; i < posicaoinicial.Length; i++)
                    {
                        if (i == 0)
                            posicaox = Convert.ToInt32(posicaoinicial[i]);
                        else if (i == 1)
                            posicaoy = Convert.ToInt32(posicaoinicial[i]);
                        else if (i == 2)
                            lado = posicaoinicial[i];
                            lado = lado.ToUpper();


                    }

                    Console.WriteLine("Digite o comando: ");
                    comandorecebido = Console.ReadLine();
                    comandorecebido =comandorecebido.ToUpper(); 


                

                foreach (char comando in comandorecebido.ToCharArray())

                {

                    if (comando == 'E' && lado == "N")
                    {
                        lado = "O";
                    }
                    else if (comando == 'E' && lado == "O")
                    {
                        lado = "S";
                    }
                    else if (comando == 'E' && lado == "S")
                    {
                        lado = "L";
                    }
                    else if (comando == 'E' && lado == "L")
                    {
                        lado = "N";
                    }



                    if (comando == 'D' && lado == "N")
                    {
                        lado = "L";
                    }
                    else if (comando == 'D' && lado == "O")
                    {
                        lado = "N";
                    }
                    else if (comando == 'D' && lado == "S")
                    {
                        lado = "O";
                    }
                    else if (comando == 'D' && lado == "L")
                    {
                        lado = "S";
                    }




                    if (comando == 'M' && lado == "N")
                    {
                        posicaoy++;
                    }
                    else if (comando == 'M' && lado == "O")
                    {
                        posicaox--;
                    }
                    else if (comando == 'M' && lado == "S")
                    {
                        posicaoy--;
                    }
                    else if (comando == 'M' && lado == "L")
                    {
                        posicaox++;
                    }



                }
                Console.WriteLine("O robo está na posição: " + posicaox + " " + posicaoy + " " + lado);
            }
        }
    }
}
