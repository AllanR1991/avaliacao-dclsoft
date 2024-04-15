using System.Globalization;

namespace questao3
{
    public class Calc
    {
        public static void CalculaSalario(int qtdCarroVendido, float valorVendas, float salarioFixo, float comissaoCarroVendido)
        {
            float acressimo = 0.05f,
                    totalComissaoFixa,
                    totalComissaoPorcentagem,
                    salario;

            totalComissaoFixa = comissaoCarroVendido * qtdCarroVendido;
            totalComissaoPorcentagem = valorVendas * acressimo;

            salario = totalComissaoFixa + totalComissaoPorcentagem + salarioFixo;

            Utils.ExibeMensagem($"\n\nO valor total do salário do vendedor é de {salario.ToString("C", new CultureInfo("pt-br"))} \n\n");
        }
    }

}