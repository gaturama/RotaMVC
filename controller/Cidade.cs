namespace Controller
{
    public class Cidade{

        public static void CadastrarCidade(string idCidade, string nome)
        {
            int idConvert = 0;
            try{
                idConvert = int.Parse(idCidade);
            }catch(Exception){
                throw new Exception("Não foi possível cadastrar o cidade.");
            }
            Model.Cidade cidade = new Model.Cidade(idConvert, nome);
        }
        
        public static void AlterarCidade(
            string idCidade,
            string nome
        ){
            int idConvert = 0;
            try{
                idConvert = int.Parse(idCidade);
            }catch(Exception){
                throw new Exception ("Este ID é inválido!");
            }
            Model.Cidade.AlterarCidade(idConvert, nome);
        }
        
        public static void ExcluirCidade(string id)
        {
            int idConvert = 0;
            try{
                idConvert = int.Parse(id);
            }catch(Exception) {
                throw new Exception ("Este ID é inválido!");
            }
            Model.Cidade.ExcluirCidade(idConvert);
        }
        
           public static Model.Cidade BuscarCidade(string id)
           {
               int idConvert = 0;
               try{
                   idConvert = int.Parse(id);
               }catch(Exception) {
                   throw new Exception ("Este ID é inválido!");
               }

               return Model.Cidade.BuscarCidade(idConvert);
           }

            public static List<Model.Cidade> ListarCidades()
            {
                return Model.Cidade.Cidades;
            }
        }
}
