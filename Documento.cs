public class Documento
{

    public string Nome { get; set; }
    public int Idade { get; set; }
    public string Id { get; set; }
    public string Aparencia { get; set; }
    public DateTime Validade { get; set; }

    public Documento(string nome, int idade, string id, string aparencia, DateTime validade)
    {

        this.Nome = nome;
        this.Idade = idade;
        this.Id = id;
        this.Aparencia = aparencia;
        this.Validade = validade;
    }
}