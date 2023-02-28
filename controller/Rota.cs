namespace Controller
{
    public class Rota
    {
        public static void CadastrarRota(int id, string origemId, string destinoId, string caminhaoId, string data){
            int idConvert  = 0;
            try{
                idConvert = int.Parse(id);
                }catch(Exception){
                    throw new Exception("Não foi possivel cadastrar a rota.");
                }
        }
    }
}