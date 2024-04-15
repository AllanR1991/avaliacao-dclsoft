namespace questao3
{
    public static class Utils
    {
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
                    Console.Write("R$ ");
                    check = float.TryParse(Console.ReadLine(), out response);
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("O valor inserido é invalido, favor inserir um numero inteiro ou decimal: ");
                    Console.ResetColor();
                    Console.Write("R$ ");
                    check = float.TryParse(Console.ReadLine(), out response);
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
            ExibeMensagem(texto);
            for (int i = 0; i <= quantidadePontinhos; i++)
            {
                ExibeMensagem(".");
                Thread.Sleep(tempo);
            }
        }
    }
}