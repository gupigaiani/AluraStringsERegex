string linhaCsv = "João,40,999999999";
string telefone = linhaCsv.Split(",")[2];
Console.WriteLine(telefone);

string novaLinha = linhaCsv.Replace(",", " - ");
Console.WriteLine(novaLinha);

string imagem = "foto.jpg";
bool valido = imagem.EndsWith(".jpg");

if(valido) Console.WriteLine("Carregando para o banco de dados");
else Console.WriteLine("Formato inválido");

string email = "gustavo@alura.com.br";
int posicao = email.IndexOf("@");
string dominio = email.Substring(posicao+1);
Console.WriteLine(dominio);

// Ex 1
Console.Write("Digite um texto: ");
string pesquisa = Console.ReadLine();
string chave = "C#";
 
if (pesquisa.Contains(chave))
{
    Console.WriteLine("A palavra-chave foi encontrada na pesquisa.");
}
else
{
    Console.WriteLine("A palavra-chave não foi encontrada.");
}
Console.WriteLine("-------------------------");

// Ex 2
Console.Write("Digite uma frase: ");
string frase = Console.ReadLine();
Console.WriteLine($"A frase contém {frase.Length} caracteres");
Console.WriteLine("-------------------------");

// Ex 3
Console.Write("Digite uma frase: ");
string frase2 = Console.ReadLine();

Console.Write("Qual palavra você quer substituir: ");
string palavra = Console.ReadLine();

Console.Write("Por qual palavra? ");
string palavraNova = Console.ReadLine();

var novaFrase = frase2.Replace(palavra, palavraNova);

Console.WriteLine(novaFrase);
Console.WriteLine("-------------------------");

// Ex 4
string log = "2025-03-25,Erro,Arquivo não encontrado";
string data = log.Split(",")[0];
string tipoErro = log.Split(",")[1];
string mensagem = log.Split(",")[2];
Console.WriteLine($"Data: {data}\nTipo de erro: {tipoErro}\nMensagem: {mensagem}");

// Ex 5
Console.Write("Digite o alerta: ");
string alerta = Console.ReadLine();
Console.WriteLine(alerta.ToUpper());

// Ex 
Console.Write("Digite o nome do cliente: ");
string nome = Console.ReadLine();

Console.Write("Digite o endereço: ");
string endereco = Console.ReadLine();

Console.Write("Digite o valor do frete: ");
double valorFrete = double.Parse(Console.ReadLine());

Console.Write("Digite a data de entrega: ");
string dataEntrega = Console.ReadLine();

Console.WriteLine("========== RELATÓRIO DE ENTREGA ==========\n");
Console.WriteLine($"Cliente: {nome}");
Console.WriteLine($"Endereço: {endereco}");
Console.WriteLine($"Valor Frete: R${valorFrete.ToString("0.00")}");
Console.WriteLine($"Data: {dataEntrega}\n");
Console.WriteLine("==========================================");

