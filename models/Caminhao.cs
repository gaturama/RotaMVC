using System;
using System.Collections.Generic;

namespace Model
{
    public class Caminhao
    {
        public int IdCaminhao { get; set; }
        public string Placa { get; set; }
        public string Motorista { get; set; }

        public static List<Caminhao> Caminhaos { get; set; } = new List<Caminhao>();

        public Caminhao(int idCaminhao, string placa, string motorista)
        {
            IdCaminhao = idCaminhao;
            Placa = placa;
            Motorista = motorista;
            
            Caminhaos.Add(this);
        }
        
        public override string ToString()
        {
            return $"Id: {IdCaminhao}, Placa: {Placa}, Motorista: {Motorista}";
        }
        
        public static void AlterarCaminhao (
            int IdCaminhao, string placa, string motorista
            ){
                Caminhao caminhao = BuscarCaminhao(IdCaminhao);
                caminhao.Placa = placa;
                caminhao.Motorista = motorista;
            }
        
        public static void ExcluirCaminhao (int IdCaminhao)
        {
            Caminhao caminhao = BuscarCaminhao(IdCaminhao);
            Caminhaos.Remove(caminhao);
        }
        
        public static Caminhao BuscarCaminhao(int IdCaminhao)
            {
                Caminhao? caminhao = Caminhaos.Find(c => c.IdCaminhao == IdCaminhao);
                if(caminhao == null) {
                    throw new Exception("Este caminhão não foi encontrado!");
                    }
                    
                return caminhao;
            }
      }
}
