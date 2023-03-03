using System;
using System.Collections;

//Neste código será controlada toda a entrada de tipos string, conversão de int 

namespace Controller 
{
    public class Rota{
        public static void CadastrarRota(
        string id, 
        string origemId, 
        string destinoId, 
        string caminhaoId, 
        string data,
        string valorRota
    ){

        int idConvert = 0;
        try{
            idConvert = int.Parse(id);
        }catch(Exception){
            throw new Exception("Este ID é inválido!");
        }

        int origemIdConvert = 0;
        try{
            origemIdConvert = int.Parse(origemId);
        }catch(Exception) {
            throw new Exception("Este ID é inválido!");
        }
        double valorRotaConvert = 0;
        try {
            valorRotaConvert = double.Parse(valorRota);
        } catch(Exception)  {
            throw new Exception("O valor digitado é inválido");
        }
        
        Model.Cidade origem = Model.Cidade.BuscarCidade(origemIdConvert);
        Model.Cidade destino = Model.Cidade.BuscarCidade(int.Parse(destinoId));
        Model.Caminhao caminhao = Model.Caminhao.BuscarCaminhao(int.Parse(caminhaoId));
        DateTime dataConvert = DateTime.Parse(data);

        Model.Rota rota = new Model.Rota(idConvert, origem, destino, caminhao, dataConvert, valorRotaConvert);
        }
        
        public static void AlterarRota(
        string id,
        string origemId,
        string destinoId,
        string caminhaoId,
        string data,
        string valorRota
        ){

        int idConvert  = 0;
        try{
            idConvert = int.Parse(id);
        }catch(Exception){
            throw new Exception("Este ID é inválido!");
        }
        
        double valorRotaConvert = 0;
        try {
            valorRotaConvert = double.Parse(valorRota);
        } catch(Exception)  {
            throw new Exception("O valor digitado é inválido");
        }
        
        Model.Cidade origem = Model.Cidade.BuscarCidade(int.Parse(origemId));
        Model.Cidade destino = Model.Cidade.BuscarCidade(int.Parse(destinoId));
        Model.Caminhao caminhao = Model.Caminhao.BuscarCaminhao(int.Parse(caminhaoId));
        DateTime dataConvert = DateTime.Parse(data);
        Model.Rota.AlterarRota(idConvert, origem, destino, caminhao, dataConvert, valorRotaConvert);
    }
        
    public static void ExcluirRota(string id){
        int idConvert  = 0;
        try{
            idConvert = int.Parse(id);
        }catch(Exception){
            throw new Exception("Este ID é inválido!");
        }

        Model.Rota.ExcluirRota(idConvert);
    }
    
    public static Model.Rota BuscarRota(string id){
        int idConvert = 0;
        try {
            idConvert = int.Parse(id);
        } catch (Exception) {
            throw new Exception("Id inválido");
        }

        return Model.Rota.BuscarRota(idConvert);
    }
    
    public static List<string> ListarRotas(){
        List<string> stringRotas = new List<string>();
        IEnumerable<Model.Rota> rotas = from rota in Model.Rota.Rotas
            join origem in Model.Cidade.Cidades on rota.Origem.IdCidade equals origem.IdCidade
            join destino in Model.Cidade.Cidades on rota.Destino.IdCidade equals destino.IdCidade
            join caminhao in Model.Caminhao.Caminhaos on rota.Caminhao.IdCaminhao equals caminhao.IdCaminhao
            select rota;
        
        foreach (Model.Rota rota in rotas){
            stringRotas.Add($"Id: {rota.Id}, Origem: {rota.Origem.Nome}, Destino: {rota.Destino.Nome}, Caminhão: {rota.Caminhao.Placa}, Data: {rota.Data}");
        }
        return stringRotas;
    }
}
}
