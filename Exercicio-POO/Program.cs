using Exercicio_POO;
Celular c = new Celular();

c.Marca = "Samsung";
c.Modelo = "A54";
c.Bateria = 50;

c.MostrarStatus();

c.Ligar();

c.Carregar();

c.MostrarStatus();

//2
Filme f = new Filme();

f.Titulo = " vingadores";
f.Genero = " Ação";
f.Duracao = 180;
f.ExibirInformacoes();
f.IniciarFilme();

//3
Jogo j = new Jogo();
j.Nome = "Mario";
j.Plataforma = "PC";
j.Pontuacao = 140;

j.Jogar();
j.SalvarProgresso();
j.MostrarPontuacao();


//4 
Carro ca = new Carro();
ca.Marca = "Fiat";
ca.Modelo = "Uno";
ca.VelocidadeAtual = 0;

ca.Acelerar();
ca.Acelerar();
ca.ExibirVelocidade();

ca.Frear();
ca.ExibirVelocidade();


//5
Aluno a = new Aluno();

a.Nome = "João";
a.Nota1 = 8;
a.Nota2 = 6;

Console.WriteLine("Média: " + a.CalcularMedia());

a.VerificarAprovacao();

//6
Retangulo r = new Retangulo();
r.Base = 10;
r.altura = 5;

Console.WriteLine("Area " + r.CalcularArea());
Console.WriteLine("Perimetro " + r.CalcularPerimetro());

//7
Funcionario fu = new Funcionario();

fu.Nome = "Carlos";
fu.Salario = 2000;

fu.AumentarSalario(10);
fu.ExibirDados();

//8
Livro l = new Livro();

l.Titulo = "Dom Casmurro";
l.Autor = "Machado de Assis";
l.Disponivel = true;

l.Emprestar();
Console.WriteLine(l.Disponivel);

l.Devolver();
Console.WriteLine(l.Disponivel);

//9 
Animal aB = new Animal();

aB.Nome = "Rex";
aB.Especie = "Cachorro";

aB.EmitirSom();

//10
Pedido p = new Pedido();

p.Numero = 1;
p.Produto = "Mouse";
p.Quantidade = 2;
p.PrecoUnitario = 50;

Console.WriteLine("Total: R$ " + p.CalcularTotal());