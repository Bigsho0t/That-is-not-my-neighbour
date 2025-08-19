public class Pessoa
{

    public string NomeReal { get; set; }
    public int IdadeReal { get; set; }
    public string IdReal { get; set; }
    public string Aparencia { get; set; }
    public bool Impostor { get; set; }

    public Pessoa(string nome, int idade, string id, string aparencia, bool impostor)
    {

        this.NomeReal = nome;
        this.IdadeReal = idade;
        this.IdReal = id;
        this.Aparencia = aparencia;
        this.Impostor = impostor;
    }
}