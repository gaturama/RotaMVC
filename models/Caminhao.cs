using System;
using System.Collections.Generic;

namespace Model
{
    public class Caminhao
    {
        public int CaminhaoId { get; set; }
        public string Placa { get; set; }
        public string Motorista { get; set; }

        public static List<Caminhao> Caminhaos { get; set; } = new List<Caminhao>();

        public Caminhao(int caminhaoId, string placa, string motorista)
        {
            caminhaoId = CaminhaoId;
            Placa = placa;
            Motorista = motorista;
            
            Caminhaos.Add(this);
        }
        
        public override string ToString()
        {
            return $"Id: {CaminhaoId}, Placa: {Placa}, Motorista: {Motorista}";
        }
        
        public static void AlterarCaminhao (
            int CaminhaoId, string placa, string motorista
            ){
                Caminhao caminhao = BuscarCaminhao(CaminhaoId);
                caminhao.Placa = placa;
                caminhao.Motorista = motorista;
            }
        
        public static void ExcluirCaminhao (int CaminhaoId)
        {
            Caminhao caminhao = BuscarCaminhao(CaminhaoId);
            Caminhaos.Remove(caminhao);
        }
        
        public static Caminhao BuscarCaminhao(int CaminhaoId)
            {
                Caminhao? caminhao = Caminhaos.Find(c => c.Id == CaminhaoId);
                if(caminhao == null) {
                    throw new Exception("Este caminhão não foi encontrado!");
                    }
                    
                return caminhao;
            }
      }
}
