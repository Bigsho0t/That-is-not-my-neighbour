public class Jogo
{

    public void Iniciar()
    {

        int pontuacao = 0;

        for (int round = 1; round <= 5; round++)
        {

            Console.Clear();
            Console.WriteLine($"--- Pessoa {round} ---");

            var (pessoa, documento) = GeradorPessoa.Gerar();

            Console.WriteLine(">>> Documento apresentado:");
            Console.WriteLine($"Nome: {documento.Nome}");
            Console.WriteLine($"Idade: {documento.Idade}");
            Console.WriteLine($"ID: {documento.Id}");
            Console.WriteLine($"Aparência: {documento.Aparencia}");
            Console.WriteLine($"Validade: {documento.Validade}");

            Console.WriteLine("\n>>> Pessoa diante de você:");
            Console.WriteLine($"Nome (dito pela pessoa): {pessoa.NomeReal}");
            Console.WriteLine($"Idade (dito pela pessoa): {pessoa.IdadeReal}");
            Console.WriteLine($"ID mostrado: {pessoa.IdReal}");
            Console.WriteLine($"Aparência física: {pessoa.Aparencia}");

            Console.Write("\nPermitir entrada? (s/n): ");
            string resposta = Console.ReadLine();

            if (resposta.ToLower() == "s")
            {

                if (!pessoa.Impostor) pontuacao += 2;

                else pontuacao -= 2;
            }

            else
            {

                if (pessoa.Impostor) pontuacao += 2;

                else pontuacao -= 2;
            }
        }

        Console.WriteLine($"\nFim de jogo! Pontuação final: {pontuacao}");
    }
}