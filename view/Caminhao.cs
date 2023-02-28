namespace View
{
    public class Caminhao
    {
        public static void CadastrarCaminhao()
        {
            Console.WriteLine("Cadastrar caminhão");
            Console.WriteLine("Digite o ID do caminhão: ");
            string idCaminhao = Console.ReadLine();
            Console.WriteLine("Digite a Placa do caminhão: ");
            string placa = Console.ReadLine();
            Console.WriteLine("Qual o motorista do caminhao: ");
            string motorista = Console.ReadLine();    
            try{
                Controller.Caminhao.CadastrarCaminhao(idCaminhao, placa, motorista);
                Console.WriteLine("Caminhão cadastrado com sucesso!");
            }catch(Exception e) {
                Console.WriteLine\($"Erro ao cadastrar caminhão: {e.Message}");
            }
        }
        
        public static void AlterarCaminhao()
        {
            Console.WriteLine("Digite o ID do caminhão: ");
            string idCaminhao = Console.ReadLine();
            Console.WriteLine("Digite a placa do caminhão: ");
            string placa = Console.ReadLine();
            Console.WriteLine("Qual o motorista do caminhão");
            string motorista = Console.ReadLine();
            try{
                Controller.Caminhao.AlterarCaminhao(idCaminhao, placa, motorista);
                Console.WriteLine("Caminhão alterado com sucesso!");
            }catch(Exception e) {
                Console.WriteLine($"Erro ao alterar caminhão: {e.Message}");
            }
        }
        
        public static void ExcluirCaminhao()
        {
            Console.WriteLine("Digite o ID do caminhão: ");
            string idCaminhao = Console.ReadLine();
            try{
                Controller.Caminhao.ExcluirCaminhao(idCaminhao);
                Console.WriteLine("Caminhão excluido com sucesso!");
            }catch(Exception e) {
                Console.WriteLine($"Erro ao excluir caminhão: {e.Message}");
            }
        }
        
        public static void ListarCaminhao(){
            Console.WriteLine("Listar caminhões")
            foreach (Model.Caminhao caminhao in Controller.Cidade.ListarCaminhaos()) {
                Console.WriteLine(caminhao);
            }
        }
     }           
 }
