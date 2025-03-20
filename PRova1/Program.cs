
using PRova1;

// Aula dia 19 - 03 - 2025

var func1 = new Funcionario();
func1.nome = "Gabriel Lucena Ferreira";
func1.cpf = "05143068231";
func1.data_de_nascimento = new DateOnly(1990, 1, 1);
func1.sexo = true;
func1.salario = 4000.00;

Console.WriteLine(func1.nome);
Console.WriteLine(func1.cpf);
Console.WriteLine(func1.data_de_nascimento);
Console.WriteLine(func1.sexo);
Console.WriteLine(func1.salario);

var elias = new Funcionario();
elias.nome = "Elias";
elias.cpf = "052.645.988-72";
elias.data_de_nascimento = new DateOnly(1990, 1, 1);
elias.sexo = true;
elias.salario = 4000.00;

Console.WriteLine(elias.nome);
Console.WriteLine(elias.cpf);
Console.WriteLine(elias.data_de_nascimento);
Console.WriteLine(elias.sexo);
Console.WriteLine(elias.salario);