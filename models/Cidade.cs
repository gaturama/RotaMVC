using System;

namespace Model
{
public class Cidade
{
    public int IdCidade { get; set; }
    public string Nome { get; set; }

    public static List<Cidade> Cidades{ get; set; } = new List<Cidade>();
    public Cidade(int idCidade, string nome)
    {
        IdCidade = idCidade;
        Nome = nome;

        Cidades.Add(this);
    }

    public override string ToString()
    {
        return $"Id: {IdCidade}, Nome: {Nome}";
    }

    public static void AlterarCidade (
        int idCidade, string nome)
        {
            Cidade cidade = BuscarCidade(idCidade);
            cidade.Nome = nome;
        }

        public static void ExcluirCidade (int idCidade)
        {
            Cidade cidade = BuscarCidade(idCidade);
            Cidades.Remove(cidade);
        }

        public static Cidade BuscarCidade(int idCidade)
        {
            Cidade? cidade = Cidades.Find(c => c.IdCidade == idCidade);
            if (cidade == null) {
                throw new Exception("Esta cidade não foi encontrada!");
            }
            return cidade;
        }     
    }
}
