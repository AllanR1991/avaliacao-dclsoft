namespace exercicio1
{
    public class Calc
    {
        public static int ConvertIdadeEmDias(int anos, int meses, int dias)
        {
            int anosEmDias = anos * 365;
            int mesesEmDias = meses * 30;

            return anosEmDias + mesesEmDias + dias;
        }

        
    }
}