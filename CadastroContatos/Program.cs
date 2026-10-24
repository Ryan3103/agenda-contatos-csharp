List<Contato> contatos = new List<Contato>();

int opcao;
int contador = 1;

do
{
    Console.WriteLine("--- Agenda contatos ---");
    Console.WriteLine("1.Novo contato");
    Console.WriteLine("2.Listar contatos");
    Console.WriteLine("3.Pesquisar por nome");
    Console.WriteLine("4.Pesquisar nome por ID");
    Console.WriteLine("5.Excluir contato");
    Console.WriteLine("6.Atualizar contato");
    Console.WriteLine("7.Sair");
    Console.WriteLine("Sua opção: ");
    opcao = int.Parse(Console.ReadLine());


    switch (opcao)
    {
        case 1:
            Console.WriteLine("Digite seu nome: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Informe seu número de telefone: ");
            string telefone = Console.ReadLine();

            Contato novoContato = new Contato
            {
                Nome = nome,
                Telefone = telefone,
                Id = contador
            };

            contatos.Add(novoContato);
            contador++;
            break;

        case 2:

            if (contatos.Count == 0)
            {
                Console.WriteLine("Não há contatos cadastrados");
            }
            else
            {
                foreach (Contato contato in contatos)
                {
                    Console.WriteLine($"{contato.Id}, {contato.Nome}, {contato.Telefone}");
                }
            }
            break;

        case 3:
            Console.WriteLine("Digite o nome para pesquisar: ");
            string nomePesquisa = Console.ReadLine();

            bool encontrado = false;
            foreach (Contato contato in contatos)
            {
                if (contato.Nome.ToLower() == nomePesquisa.ToLower())
                {
                    Console.WriteLine($"{contato.Nome}, {contato.Telefone}");
                    encontrado = true;
                }
            }
            if (encontrado == false)
            {
                Console.WriteLine("Contato não encontrado");
            }
            break;

        case 4:
            Console.WriteLine("Informe o ID que deseja procurar: ");
            int IdProcurar = int.Parse(Console.ReadLine());

            bool IdEncontrado = false;

            foreach (Contato contato in contatos)
            {
                if (contato.Id == IdProcurar)
                {
                    Console.WriteLine($"{contato.Id}, {contato.Nome}, {contato.Telefone}");
                    IdEncontrado = true;
                }
            }

            if (IdEncontrado == false)
            {
                Console.WriteLine("Contato não encontrado");
            }
            break;

        case 5:
            Console.WriteLine("Excluir contato selecionado");
            break;

        case 6:
            Console.WriteLine("Atualizar contato selecionado");
            break;

        case 7:
            Console.WriteLine("");
            break;

        default:
            Console.WriteLine("Opção inválida");
            break;
    }
} while (opcao != 7);

Console.WriteLine("Saindo do sistema...");