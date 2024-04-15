namespace exercicio1
{
    public static class Utils
    {
        public static string PerguntaString(string pergunta)
        {
            Console.WriteLine($"\n{pergunta}");
            return Console.ReadLine();
        }

        public static char PerguntaChar(string pergunta)
        {
            bool check = true;
            char response;
            do
            {
                if (check)
                {
                    Console.WriteLine($"\n{pergunta}");
                    check = char.TryParse(Console.ReadLine(), out response);
                    if (response != 'n' && response != 's')
                    {
                        do
                        {
                            Console.ForegroundColor = ConsoleColor.Red;                            
                            Console.WriteLine("O valor inserido é invalido, favor inserir (s) para fazer um novo calculo ou (n) sair do sistema: ");
                            Console.ResetColor();
                            check = char.TryParse(Console.ReadLine(), out response);                            
                        } while (response != 'n' && response != 's');

                    };
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("O valor inserido é invalido, favor inserir um número inteiro: ");
                    Console.ResetColor();
                    check = char.TryParse(Console.ReadLine(), out response);
                }
                Console.ResetColor();
            } while (!check);
            return response;
        }

        public static int PerguntaInt(string pergunta)
        {
            bool check = true;
            int response;
            do
            {
                if (check)
                {
                    Console.WriteLine($"\n{pergunta}");
                    check = int.TryParse(Console.ReadLine(), out response);
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("O valor inserido é invalido, favor inserir um numero inteiro: ");
                    Console.ResetColor();
                    check = int.TryParse(Console.ReadLine(), out response);
                }
                Console.ResetColor();
            } while (!check);
            return response;
        }

        public static float PerguntaFloat(string pergunta)
        {
            bool check = true;
            float response;
            do
            {
                if (check)
                {
                    Console.WriteLine($"\n{pergunta}");
                    check = float.TryParse(Console.ReadLine(), out response);
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("O valor inserido é invalido, favor inserir um numero inteiro: ");
                    Console.ResetColor();
                    check = float.TryParse(Console.ReadLine(), out response);
                }
                Console.ResetColor();
            } while (!check);
            return response;
        }

        public static double PerguntaDouble(string pergunta)
        {
            bool check = true;
            double response;
            do
            {
                if (check)
                {
                    Console.WriteLine($"\n{pergunta}");
                    check = double.TryParse(Console.ReadLine(), out response);
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("O valor inserido é invalido, favor inserir um numero inteiro: ");
                    Console.ResetColor();
                    check = double.TryParse(Console.ReadLine(), out response);
                }
                Console.ResetColor();
            } while (!check);
            return response;
        }

        public static decimal PerguntaDecimal(string pergunta)
        {
            bool check = true;
            decimal response;
            do
            {
                if (check)
                {
                    Console.WriteLine($"\n{pergunta}");
                    check = decimal.TryParse(Console.ReadLine(), out response);
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("O valor inserido é invalido, favor inserir um numero inteiro: ");
                    Console.ResetColor();
                    check = decimal.TryParse(Console.ReadLine(), out response);
                }
                Console.ResetColor();
            } while (!check);
            return response;
        }

        public static void ExibeMensagemPulandoLinha(string texto)
        {
            Console.WriteLine(texto);
        }

        public static void ExibeMensagem(string texto)
        {
            Console.Write(texto);
        }

        public static void BarraCarregamento(string texto, int quantidadePontinhos, int tempo)
        {
            Utils.ExibeMensagem(texto);
            for (int i = 0; i <= quantidadePontinhos; i++)
            {
                Utils.ExibeMensagem(".");
                Thread.Sleep(tempo);
            }
        }
    }
}