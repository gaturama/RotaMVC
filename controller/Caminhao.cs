namespace Controller
{
    public class Caminhao
    {
        public static void CadastrarCaminhao(
            string idCaminhao,
            string placa,
            string motorista
        ){
            int idConvert = 0;
            try{
                idConvert = int.Parse(idCaminhao);
            }catch(Exception) {
                throw new Exception ("Este ID é inválido!");
            }
            Model.Caminhao caminhao = new Model.Caminhao(idConvert, placa, motorista);
        }
        
        public static void AlterarCaminhao(
            string idCaminhao,
            string placa,
            string motorista
        ){
            int idConvert = 0;
            try{
                idConvert = int.Parse(idCaminhao);
            }catch(Exception) {
                throw new Exception ("Este ID é inválido!");
            }
            Model.Caminhao.AlterarCaminhao(idConvert, placa, motorista);
        }
        
        public static void ExcluirCaminhao(string id)
        {
            int idConvert = 0;
            try{
                idConvert = int.Parse(id);
            }catch(Exception) {
                throw new Exception ("Este ID é inválido!");
            }
            Model.Caminhao.ExcluirCaminhao(idConvert);
        }
        
       public static Model.Caminhao BuscarCaminhao(string id)
       {
           int idConvert = 0;
           try{
               idConvert = int.Parse(id);
           }catch(Exception) {
               throw new Exception ("Este ID é inválido!");
           }
           
           return Model.Caminhao.BuscarCaminhao(idConvert);
       }
        
        public static List<Model.Caminhao> ListarCaminhaos()
        {
            return Model.Caminhao.Caminhaos;
        }
    }
}
