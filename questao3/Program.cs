using questao3;

Console.Clear();
Utils.BarraCarregamento("\n\n\nIniciando o programa", 5,500);
Console.Clear();
float   comissaoCarroVendido,
        salarioFixo,
        valorVendas;

int qtdCarroVendido;

Utils.ExibeMensagemPulandoLinha("Este programa calcula o salário de um vendedor de carro.\n\n");

qtdCarroVendido = Utils.PerguntaInt("Informe a quantidade de carros vendidos pelo vendedor: ");
valorVendas = Utils.PerguntaFloat("Informe o valor total das vendas realizadas pelo vendedor: ");
salarioFixo = Utils.PerguntaFloat("Informe o salário fixo do vendedor: ");
comissaoCarroVendido = Utils.PerguntaFloat("Informe a comissão fixa que o vendedor ganha por carro vendido: ");

Calc.CalculaSalario(qtdCarroVendido,valorVendas,salarioFixo,comissaoCarroVendido);






















