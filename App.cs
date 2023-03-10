namespace Program //Código de apresentação de todo o programa
{
public class App
{
     public static void Main(string[] args){
     
     Console.WriteLine("Rastreamento de Caminhões: ");
     int op = 0;
     do{
          Console.WriteLine("=========================");
          Console.WriteLine("0- Sair");
          Console.WriteLine("1- Cadastrar Rota");
          Console.WriteLine("2- Alterar Rota");
          Console.WriteLine("3- Excluir Rota");
          Console.WriteLine("4- Listar Rotas");
          Console.WriteLine("5- Cadastrar Caminhão");
          Console.WriteLine("6- Alterar Caminhão");
          Console.WriteLine("7- Excluir Caminhão");
          Console.WriteLine("8- Listar Caminhões");
          Console.WriteLine("9- Cadastrar Cidade");
          Console.WriteLine("10- Alterar Cidade");
          Console.WriteLine("11- Excluir Cidade");
          Console.WriteLine("12- Listar Cidades");
          Console.WriteLine("=========================");
          Console.WriteLine("Opção: ");
          op = int.Parse(Console.ReadLine());
          
          switch (op){
          case 0:
               Console.WriteLine("Life was like a box of chocolates… You never know what you're gonna get.");
               break;
          case 1:
               View.Rota.CadastrarRota();
               break;
          case 2:
               View.Rota.AlterarRota();
               break;
          case 3:
               View.Rota.ExcluirRota();
               break;
          case 4:
               View.Rota.ListarRotas();
               break;
          case 5:
               View.Caminhao.CadastrarCaminhao();
               break;
          case 6:
               View.Caminhao.AlterarCaminhao();
               break;
          case 7:
               View.Caminhao.ExcluirCaminhao();
               break;
          case 8:
               View.Caminhao.ListarCaminhaos();
               break;
          case 9: 
               View.Cidade.CadastrarCidade();
               break;
          case 10:
               View.Cidade.AlterarCidade();
               break;
          case 11:
               View.Cidade.ExcluirCidade();
               break;
          case 12:
               View.Cidade.ListarCidades();
               break;
          default:
               Console.WriteLine("Opção Inválida");
               break;
          }
          }while(op != 0);
     }
}
}  
