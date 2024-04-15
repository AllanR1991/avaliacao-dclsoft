
using exercicio1;

int anos, meses, dias, res;
char novoCalculo;

PeR.ExibeMensagemPulandoLinha("\n\nEste programa exibe a idade de uma pessoa expressa apenas em dias.\n");

do{
    PeR.ExibeMensagemPulandoLinha("Informe a idade expressa em anos, meses e dias.\n");

    anos = PeR.PerguntaInt("Informe o(s) ano(s): ");
    meses = PeR.PerguntaInt("Informe o(s) mês(es)");
    dias = PeR.PerguntaInt("Informe o(s) dia(s)");

    res = Calc.ConvertIdadeEmDias(anos,meses,dias);

    PeR.ExibeMensagemPulandoLinha($"\n\nA idade expressa em {anos} ano(s), {meses} mês(es) e {dias} dia(s), convertida em apenas dias é de : {res} dia(s)\n\n");

    novoCalculo = PeR.PerguntaChar("Gostaria de fazer um novo calculo, (s) para sim e (n) para não : ");

}while(novoCalculo != 'n');

PeR.ExibeMensagemPulandoLinha("Fim do programa.");


