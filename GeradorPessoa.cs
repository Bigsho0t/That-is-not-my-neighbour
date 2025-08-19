using System.Collections.Specialized;
using System.Runtime.CompilerServices;

public class GeradorPessoa
{

    private static Random random = new Random();

    private static string[] nomes =
    {
    "Ana", "Bruno", "Carlos", "Daniela", "Eduardo",
    "Fernanda", "Gabriel", "Helena", "Igor", "Juliana",
    "Kaio", "Larissa", "Marcos", "Nathalia", "Otávio",
    "Paula", "Quintino", "Rafaela", "Samuel", "Tatiane",
    "Ubirajara", "Vanessa", "Willian", "Xênia", "Yasmin",
    "Zeca", "Alice", "Bernardo", "Camila", "Diego",
    "Elisa", "Fábio", "Giovana", "Henrique", "Isabela",
    "João", "Karen", "Leonardo", "Milena", "Nicole",
    "Oscar", "Pedro", "Queila", "Renato", "Sabrina",
    "Thiago", "Ulisses", "Vitória", "Wesley", "Yuri"
    };

    private static string[] aparencias = new string[]
{
    "Cabelo loiro",
    "Cabelo castanho",
    "Cabelo preto",
    "Cabelo ruivo",
    "Cabelo grisalho",
    "Cabelo raspado",
    "Cabelo ondulado",
    "Cabelo cacheado",
    "Cabelo curto",
    "Cabelo longo",
    "Barba cheia",
    "Barba por fazer",
    "Barba longa",
    "Sem barba",
    "Bigode fino",
    "Bigode grosso",
    "Roupa azul",
    "Roupa preta",
    "Roupa vermelha",
    "Roupa camuflada",
    "Roupa elegante",
    "Roupa simples",
    "Armadura de couro",
    "Casaco longo",
    "Jaqueta de couro",
    "Óculos escuros",
    "Chapéu de palha",
    "Capuz escondendo o rosto",
    "Cicatriz no rosto",
    "Tatuagem visível"
};

    public static (Pessoa, Documento) Gerar()
    {

        string nome = nomes[random.Next(nomes.Length)];
        int idade = random.Next(18, 60);
        string id = random.Next(1000, 9999).ToString();
        string aparencia = aparencias[random.Next(aparencias.Length)];
        bool impostor = random.Next(100) < 35;

        Pessoa pessoa = new Pessoa(nome, idade, id, aparencia, impostor);

        Documento documento = new Documento(nome, idade, id, aparencia, DateTime.Now.AddYears(2));

        if (impostor)
        {

            int tipoErro = random.Next(1, 5);

            switch (tipoErro)
            {

                case 1:
                    documento.Nome = "???";
                    break;

                case 2:
                    documento.Id = "0000";
                    break;

                case 3:
                    documento.Aparencia = aparencias[random.Next(aparencias.Length)];
                    break;

                case 4:
                    documento.Validade = DateTime.Now.AddYears(-1);
                    break;
            }
        }

        return (pessoa, documento);
    }
}