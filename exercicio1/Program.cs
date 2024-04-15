
using exercicio1;

int anos, meses, dias, res;
char novoCalculo;

Console.Clear();

Utils.BarraCarregamento("Carregando o sistema",10,300);

Console.Clear();

Utils.ExibeMensagemPulandoLinha("Este programa exibe a idade de uma pessoa expressa apenas em dias.");

do{
    
    Utils.ExibeMensagemPulandoLinha("\nInforme a idade expressa em anos, meses e dias.");

    anos = Utils.PerguntaInt("Informe os anos : ");
    meses = Utils.PerguntaInt("Informe os meses : ");
    dias = Utils.PerguntaInt("Informe os dia : ");

    res = Calc.ConvertIdadeEmDias(anos,meses,dias);

    Console.ForegroundColor = ConsoleColor.Yellow;
    Utils.ExibeMensagemPulandoLinha(@$"
***************************************************************************************************************************

        A idade expressa em {anos} ano(s), {meses} mês(es) e {dias} dia(s), convertida em apenas dias é de : {res} dia(s)     

***************************************************************************************************************************    

    ");
    Console.ResetColor();
    
    novoCalculo = Utils.PerguntaChar("Gostaria de fazer um novo calculo, (s) para sim e (n) para não : ");
}while(novoCalculo != 'n');

Utils.BarraCarregamento("\nFechando o sistema",10,300);

Utils.ExibeMensagemPulandoLinha("\n\nSistema finalziado com sucesso.");


