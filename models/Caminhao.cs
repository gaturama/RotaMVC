using System;
using System.Collections.Generic;

namespace Model
{
    public class Caminhao
    {
        public int idCaminhao { get; set; }
        public string Placa { get; set; }
        public string Motorista { get; set; }

        public static List<Caminhao> Caminhaos ={ get; set; } = new List<Caminhao>();

        public Caminhao(int IdCaminhao, string placa, string motorista)
        {
            IdCaminhao = idCaminhao;
            Placa = placa;
            Motorista = motorista;
            
            Caminhaos.Add(this);
        }
        
        public override string ToString()
        {
            return $"Id: {idCaminhao}, Placa: {placa}, Motorista: {motorista}";
        }
        
        public static void AlterarCaminhao (
            int idCaminhao, string placa, string motorista)
            {
                Caminhao caminhao = BuscarCaminhao(idCaminhao);
                caminhao.Placa = placa;
                caminhao.Motorista = motorista;
            }
        
        public static void ExcluirCaminhao (int idCaminhao)
        {
            Caminhao caminhao = BuscarCaminhao(idCaminhao);
            Caminhaos.Remove(caminhao);
        }
        
        public static void Caminhao BuscarCaminhao(int idCaminhao)
            {
                Caminhao? caminhao = Caminhaos.Find(c => c.Id ==idCaminhao);
                if(caminhao == null) {
                    throw new Exception("Esta cidade não foi encontrada!");
                    }
                return cidade;
            }
      }
}
