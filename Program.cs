using System.Text.RegularExpressions;

// Strings
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
Console.WriteLine("==========================================\n");

// REGEX - Regular Expressions
Console.Write("Digite a chave PIX: ");

string chavePix = Console.ReadLine();

string padraoCpf = @"^\d{3}\.\d{3}\.\d{3}-\d{2}$";
string padraoCNPJ = @"^\d{2}\.\d{3}\.\d{3}/\d{4}-\d{2}$";
string padraoTelefone = @"^\(\d{2}\)\d{4,5}-\d{4}$";
string padraoEmail = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

string tipoChave;

if (Regex.IsMatch(chavePix, padraoCpf))
    tipoChave = "CPF";
else if (Regex.IsMatch(chavePix, padraoCNPJ))
    tipoChave = "CNPJ";
else if (Regex.IsMatch(chavePix, padraoTelefone))
    tipoChave = "Telefone";
else if (Regex.IsMatch(chavePix, padraoEmail))
    tipoChave = "E-mail";
else
    tipoChave = "Formato inválido";

Console.WriteLine($"Tipo da chave PIX: {tipoChave}");

string email2 = "gustavo@alura.com.br";
string padraoEmailAgrupado = @"(^[a-zA-Z0-9._%+-]+)@([a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$)";

string dominio2 = Regex.Match(email2, padraoEmailAgrupado).Groups[2].Value;
Console.WriteLine(dominio2);
Console.WriteLine("-------------------------");

// Ex 1
Console.WriteLine("Digite o código do cupom: "); 

string codigo = Console.ReadLine(); 
string regex = @"^\d+$"; 
bool ehValido = Regex.IsMatch(codigo, regex); 

if (ehValido) Console.WriteLine("O código é válido.");
else Console.WriteLine("O código não é válido.");
Console.WriteLine("-------------------------");

// Ex 2 
Console.WriteLine("Digite o texto do recibo: ");
string texto = Console.ReadLine();
 
string regex2 = @"R\$ \d+,\d{2}";
 
string valor = Regex.Match(texto, regex2).Value;
 
Console.WriteLine("Valor encontrado: " + valor);
Console.WriteLine("-------------------------");

// Ex 3
string regex3 = @"\s+";
 
Console.WriteLine("Digite sua frase: ");
string frase3 = Console.ReadLine();
 
string textoLimpo = Regex.Replace(frase3, regex3, " ").Trim();
 
Console.WriteLine("Texto limpo: " + textoLimpo + "");
Console.WriteLine("-------------------------");

// Ex 4
string regex4 = @"^\d{2}/\d{2}/\d{4}$";
 
Console.WriteLine("Digite a data (dd/mm/aaaa):");
string data2 = Console.ReadLine();
 
bool formatoCorreto = Regex.IsMatch(data2, regex4);
 
if (formatoCorreto) Console.WriteLine("A data está no formato correto.");
else Console.WriteLine("Formato inválido! Use dd/mm/aaaa.");
Console.WriteLine("-------------------------");

// Ex 5
Console.WriteLine("Digite o texto: ");
string texto2 = Console.ReadLine();
 
string regex5 = @"https?://\S+";
 
string resultado = Regex.Replace(texto2, regex5, "[LINK]");
 
Console.WriteLine(resultado);
Console.WriteLine("-------------------------");
