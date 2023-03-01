namespace View
{
  public class Rota {
    public static void CadastrarRota() {

      Console.WriteLine("Cadastrar Rota");
      Console.WriteLine("ID: ");
      string id = Console.ReadLine();
      Console.WriteLine("Origem: ");
      string origemId = Console.ReadLine();
      Console.WriteLine("Destino: ");
      string destinoId = Console.ReadLine();
      Console.WriteLine("Caminhão: ");
      string idCaminhao = Console.ReadLine();
      Console.WriteLine("Data: ");
      string data = Console.ReadLine();
      try{
          Controller.Rota.CadastrarRota(id, origemId, destinoId, idCaminhao, data);
          Console.WriteLine("Rota cadastrada com sucesso!");
      }catch(Exception){
        Console.WriteLine("Não foi possível cadastrar a rota");
      }
   }
   
   public static void AlterarRota()
   {
      Console.WriteLine("Alterar Rota");
      Console.WriteLine("ID: ");
      string id = Console.ReadLine();
      Console.WriteLine("Origem: ");
      string origemId = Console.ReadLine();
      Console.WriteLine("Destino: ");
      string destinoId = Console.ReadLine();
      Console.WriteLine("Caminhão: ");
      string idCaminhao = Console.ReadLine();
      Console.WriteLine("Data: ");
      string data = Console.ReadLine();
      try{
          Controller.Rota.AlterarRota(id, origemId, destinoId, idCaminhao, data);
          Console.WriteLine("Rota alterada com sucesso!");
      }catch(Exception){
        Console.WriteLine("Não foi possível alterar a rota");
      }
   }
   
   public static void ExcluirRota()
   {
      Console.WriteLine("Excluir Rota");
      Console.WriteLine("ID: ");
      string id = Console.ReadLine();
      try{
          Controller.Rota.ExcluirRota(id);
          Console.WriteLine("Rota excluída com sucesso!");
      }catch(Exception) {
        Console.WriteLine("Não foi possível excluir a rota");
      }
   }
    
   public static void ListarRotas() {
         Console.WriteLine("Listar Rotas");
         foreach (string rota in Controller.Rota.ListarRotas()) {
            Console.WriteLine(rota);
            }
        }    
    }
} 
