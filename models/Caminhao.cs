using System;
using System.Collections.Generic;

namespace Model
{
    public class Caminhao
    {
        public int idCaminhao { get; set; }
        public string placa { get; set; }
        public string motorista { get; set; }

        public static List<Caminhao> caminhaos = 

        public Caminhao(int IdCaminhao, string Placa, string Motorista)
        {
            IdCaminhao = idCaminhao;
            Placa = placa;
            Motorista = motorista;
        }
    }
}