namespace View
{
  public class Cidade
  {
    public static void CadastrarCidade()
    {
      Console.WriteLine("Digite o ID da cidade: ");
      string idCidade = Console.ReadLine();
      Console.WriteLine("Digite o nome da cidade: ");
      string nome = Console.ReadLine();
      try{
          Controller.Cidade.CadastrarCidade(idCidade, nome);
          Console.WriteLine("Cidade cadastrada com sucesso!");
      }catch(Exception e) {
        Console.WriteLine($"Erro ao cadastrar cidade: {e.Message}");
      }
   }
   
   public static void AlterarCidade()
   {
      Console.WriteLine("Digite o ID da cidade: ");
      string idCidade = Console.ReadLine();
      Console.WriteLine("Digite o nome da cidade: ");
      string nome = Console.ReadLine();
      try{
          Controller.Cidade.AlterarCidade(idCidade, nome);
          Console.WriteLine("Cidade alterada com sucesso!");
      }catch(Exception e) {
        Console.WriteLine($"Erro ao alterar cidade: {e.Message}");
      }
   }
   
   public static void ExcluirCidade()
   {
      Console.WriteLine("Digite o ID da cidade: ");
      string idCidade = Console.ReadLine();
      try{
          Controller.Cidade.ExcluirCidade(idCidade);
          Console.WriteLine("Cidade excluida com sucesso!");
      }catch(Exception e) {
        Console.WriteLine($"Erro ao excluir cidade: {e.Message}");
      }
   }
   
   public static void ListarCidades() {
      Console.WriteLine("Listar cidades");
      foreach (Model.Cidade cidade in Controller.Cidade.ListarCidades()) {
        Console.WriteLine(cidade);
      }
   }
}
}
