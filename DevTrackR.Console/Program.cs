var pacotes = new List<Pacote>();

Console.WriteLine("----- DevTrackR - Serviço de Postagem -----");

ExibirMensagemPrincipal();

var opcao = Console.ReadLine();

while (opcao != "0") {
    switch (opcao) {
        case "1":
            CadastrarPacote();
            break;
        case "2":
            AtualizarPacote();
            break;
        case "3":
            ConsultarPacote();
            break;
        default:
            Console.WriteLine("Opção inválida.");
            break;
    }

    ExibirMensagemPrincipal();
    opcao = Console.ReadLine();
}

void ExibirMensagemPrincipal() {
    Console.WriteLine("Digite o código de acordo com o que você quer.");
    Console.WriteLine("1- Cadastro de Pacote");
    Console.WriteLine("2- Atualizar Pacote");
    Console.WriteLine("3- Consultar Pacote");
    Console.WriteLine("0- Sair da aplicação.");
}

void CadastrarPacote() {
    Console.WriteLine("Digite o titulo.");
    var titulo = Console.ReadLine();

    Console.WriteLine("Digite a descrição.");
    var descricao = Console.ReadLine();

    var pacote = new Pacote(titulo, descricao);

    pacotes.Add(pacote);
    
    Console.WriteLine($"Pacote com código {pacote.Codigo} foi cadastrado com sucesso.");
}

void AtualizarPacote() {
    Console.WriteLine("Digite o código do pacote.");
    var codigo = Console.ReadLine();

    var pacote = pacotes.SingleOrDefault(p => p.Codigo == codigo);

    if (pacote == null) {
        Console.WriteLine("Pacote não encontrado!");
        return;
    }

    Console.WriteLine("Digite o status atual.");
    var status = Console.ReadLine();

    pacote.AtualizarStatus(status);
    Console.WriteLine("Pacote atualizado com sucesso.");
}

void ConsultarPacote() {
    Console.WriteLine("Digite o código do pacote.");
    var codigo = Console.ReadLine();

    var pacote = pacotes.SingleOrDefault(p => p.Codigo == codigo);

    if (pacote == null) {
        Console.WriteLine("Pacote não encontrado!");
        return;
    }

    pacote.ExibirDetalhes();
}

var pacotePremium = new PacotePremium("Pacote premium", "Um pacote premium", "Voo ABC");
var pacote = new Pacote("Pacote Normal", "Um Pacote Normal");

var conjuntoPacotes = new List<Pacote> { pacotePremium, pacote };

foreach (var item in conjuntoPacotes) {
    item.ExibirDetalhes();
}

public class Pacote {
    public Pacote(string titulo, string descricao)
    {
        Titulo = titulo;
        Descricao = descricao;

        Codigo = GerarCodigo();
        DataPostagem = DateTime.Now;
        Status = "Postado.";
    }

    private string GerarCodigo() {
        return Guid.NewGuid().ToString();
    }

    public void AtualizarStatus(string status) {
        Status = status;
    }

    public virtual void ExibirDetalhes() {
        Console.WriteLine($"Pacote {Titulo} e Código {Codigo} com status {Status}");
    }

    public string Titulo { get; set; }
    public string Descricao { get; set; }
    public string Codigo { get; set; }
    public DateTime DataPostagem { get; set; }
    public string Status { get ; set; }
}

public class PacotePremium : Pacote {
    public PacotePremium(string titulo, string descricao, string voo) 
        : base(titulo, descricao) {
            Voo = voo;
    }

    public string Voo { get; set; }

    public override void ExibirDetalhes()
    {
        base.ExibirDetalhes();
        Console.WriteLine($"Com voo {Voo}");
    }
}