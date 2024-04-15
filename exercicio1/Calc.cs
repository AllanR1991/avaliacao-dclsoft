namespace questao1
{
    public class Calc
    {
        public static int ConvertIdadeEmDias(int dias,int meses,int anos){
            int anosEmDias = anos*365;
            int mesesEmDias= meses*30;

            return anosEmDias+mesesEmDias+dias;
        }
    }
}