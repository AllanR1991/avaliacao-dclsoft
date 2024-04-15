using questao3;

Console.Clear();
Utils.BarraCarregamento("\n\n\nIniciando o programa", 5, 500);
Console.Clear();
float comissaoCarroVendido,
        salarioFixo,
        valorVendas;

int qtdCarroVendido;
char novoCalculo;

do
{
    Console.Clear();
    Utils.ExibeMensagemPulandoLinha("Este programa calcula o salário de um vendedor de carro.\n\n");

    qtdCarroVendido = Utils.PerguntaInt("Informe a quantidade de carros vendidos pelo vendedor: ");
    valorVendas = Utils.PerguntaFloat("Informe o valor total das vendas realizadas pelo vendedor: ");
    salarioFixo = Utils.PerguntaFloat("Informe o salário fixo do vendedor: ");
    comissaoCarroVendido = Utils.PerguntaFloat("Informe a comissão fixa que o vendedor ganha por carro vendido: ");

    Utils.BarraCarregamento("\n\nProcessando", 5, 350);

    Calc.CalculaSalario(qtdCarroVendido, valorVendas, salarioFixo, comissaoCarroVendido);
    novoCalculo = Utils.PerguntaChar("Gostaria de fazer um novo calculo, (s) para sim e (n) para não : ");
} while (novoCalculo != 'n');

Utils.BarraCarregamento("\n\nFechando o sistema", 5, 350);
























