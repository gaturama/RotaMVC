namespace Controller
{
    public class Cidade{

        public static void CadastrarCidade(int idCidade, string nome)
        {
            int idConvert = 0;
            try{
                idConvert = int.Parse(idCidade);
            }catch(Exception){
                throw new Exception("Não foi possível cadastrar o cidade.");
            }
        }
    }
}