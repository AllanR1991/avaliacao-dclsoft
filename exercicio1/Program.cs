
using exercicio1;

int anos, meses, dias, res;
char novoCalculo;

Console.Clear();

Calc.BarraCarregamento("Carregando o sistema",10,300);

Console.Clear();

PeR.ExibeMensagemPulandoLinha("Este programa exibe a idade de uma pessoa expressa apenas em dias.");

do{
    
    PeR.ExibeMensagemPulandoLinha("\nInforme a idade expressa em anos, meses e dias.");

    anos = PeR.PerguntaInt("Informe o(s) ano(s): ");
    meses = PeR.PerguntaInt("Informe o(s) mês(es)");
    dias = PeR.PerguntaInt("Informe o(s) dia(s)");

    res = Calc.ConvertIdadeEmDias(anos,meses,dias);

    Console.ForegroundColor = ConsoleColor.Yellow;
    PeR.ExibeMensagemPulandoLinha(@$"
***************************************************************************************************************************

        A idade expressa em {anos} ano(s), {meses} mês(es) e {dias} dia(s), convertida em apenas dias é de : {res} dia(s)     

***************************************************************************************************************************    

    ");
    Console.ResetColor();
    
    novoCalculo = PeR.PerguntaChar("Gostaria de fazer um novo calculo, (s) para sim e (n) para não : ");

}while(novoCalculo != 'n');

Calc.BarraCarregamento("Fechando o sistema",10,300);

PeR.ExibeMensagemPulandoLinha("\n\nSistema finalziado com sucesso.");


