﻿


int R = 0, I = 0, A = 0, S = 0, E = 0, C = 0;
int temp;

Console.WriteLine("Responda de 0 a 4 para cada afirmação. \n");

Console.WriteLine("R- Realista: ");
Console.WriteLine("1: Gosto de trabalhar com ferramentas, máquinas ou objetos.");
temp = int.Parse(Console.ReadLine());
R += temp;
Console.WriteLine("2: Prefiro atividade prática a discussões teóricas.");
temp = int.Parse(Console.ReadLine());
R += temp;
Console.WriteLine("3: Gosto de consertar, montar ou construir coisas.");
temp = int.Parse(Console.ReadLine());
R += temp;
Console.WriteLine("4: Prefiro ambientes organizados e tarefas manuais.");
temp = int.Parse(Console.ReadLine());
R += temp;

Console.WriteLine("\nI - Investigativo:");
Console.WriteLine("1: Gosto de resolver problemas complexos.");
temp = int.Parse(Console.ReadLine());
I += temp;
Console.WriteLine("2: Tenho interesse em ciência, pesquisa ou experimentos.");
temp = int.Parse(Console.ReadLine());
I += temp;
Console.WriteLine("3: Gosto de analisar informações e entender como as coisas funcionam.");
temp = int.Parse(Console.ReadLine());
I += temp;
Console.WriteLine("4: Prefiro atividades que envolvam reflexão e lógica.");
temp = int.Parse(Console.ReadLine());
I += temp;

Console.WriteLine("\nA - Artístico:");
Console.WriteLine("1: Gosto de criar, desenhar, inventar ou expressar ideias.");
temp = int.Parse(Console.ReadLine());
A += temp;
Console.WriteLine("2: Prefiro atividades com liberdade e sem regras rígidas.");
temp = int.Parse(Console.ReadLine());
A += temp;
Console.WriteLine("3: Gosto de música, artes visuais, escrita ou atuação.");
temp = int.Parse(Console.ReadLine());
A += temp;
Console.WriteLine("4: Sou imaginativo(a) e busco formas diferentes de fazer as coisas.");
temp = int.Parse(Console.ReadLine());
A += temp;

Console.WriteLine("\nS - Social:");
Console.WriteLine("1: Gosto de ajudar, orientar ou cuidar de pessoas.");
temp = int.Parse(Console.ReadLine());
S += temp;
Console.WriteLine("2: Tenho facilidade para ouvir e compreender os outros.");
temp = int.Parse(Console.ReadLine());
S += temp;
Console.WriteLine("3: Prefiro atividades que envolvam ensinar ou apoiar alguém.");
temp = int.Parse(Console.ReadLine());
S += temp;
Console.WriteLine("4: Gosto de trabalhar em equipe e apoiar o bem-estar coletivo.");
temp = int.Parse(Console.ReadLine());
S += temp;

Console.WriteLine("\nE - Empreendedor:");
Console.WriteLine("1: Gosto de liderar, convencer ou motivar pessoas.");
temp = int.Parse(Console.ReadLine());
E += temp;
Console.WriteLine("2: Tenho iniciativa e gosto de tomar decisões.");
temp = int.Parse(Console.ReadLine());
E += temp;
Console.WriteLine("3: Prefiro desafios que envolvam resultados e metas.");
temp = int.Parse(Console.ReadLine());
E += temp;
Console.WriteLine("4: Gosto de criar projetos e colocar ideias em prática.");
temp = int.Parse(Console.ReadLine());
E += temp;

Console.WriteLine("\nC - Convencional:");
Console.WriteLine("1: Gosto de organizar, planejar e manter tudo em ordem.");
temp = int.Parse(Console.ReadLine());
C += temp;
Console.WriteLine("2: Prefiro atividades com regras claras e rotina.");
temp = int.Parse(Console.ReadLine());
C += temp;
Console.WriteLine("3: Gosto de trabalhar com documentos, tabelas ou registros.");
temp = int.Parse(Console.ReadLine());
C += temp;
Console.WriteLine("4: Sou detalhista e cuidadoso(a) com informações.");
temp = int.Parse(Console.ReadLine());
C += temp;

Console.WriteLine("\n--- Resultado ---");
Console.WriteLine($"R: {R}");
Console.WriteLine($"I: {I}");
Console.WriteLine($"A: {A}");
Console.WriteLine($"S: {S}");
Console.WriteLine($"E: {E}");
Console.WriteLine($"C: {C}");

Console.WriteLine("\nPerfil dominante:");

int maior = Math.Max(Math.Max(Math.Max(Math.Max(Math.Max(R, I), A), S), E), C); 



int [] valores = {R, I, A, S, E, C,};
int Maior = valores.Max();

if (maior == 0)
{
    Console.WriteLine("Nenhum perfil dominante.");
}
else if (valores.Count(V => V == maior) > 1)
{
    Console.WriteLine("Perfis empatados.");
}

    if (maior == R)
    Console.WriteLine("(Realista) = Mecânica, Automação, Usinagem, Eletricidade, Plastico, Costura.");
else if (maior == I)
    Console.WriteLine("(Investigativo) = Tecnologia da Informação, Eletroeletrônica, Manutenção, Plastico");
else if (maior == A)
    Console.WriteLine("(Artístico) = Design de Produto, Impressão 3D, Comunicação Visual, Costura");
else if (maior == S)
    Console.WriteLine("(Social) = Segurança do Trabalho, Educação, Saúde Ocupacional");
else if (maior == E)
    Console.WriteLine("(Empreendedor) = Gestão, Vendas Técnicas, Logística");
else if (maior == C)
    Console.WriteLine("(Convencional) = Administração, Controle de Qualidade, Planejamento");

    return;


   if (maior == R)
    Console.WriteLine("(Realista) = Mecânica, Automação, Usinagem, Eletricidade, Plastico, Costura.");
else if (maior == I)
    Console.WriteLine("(Investigativo) = Tecnologia da Informação, Eletroeletrônica, Manutenção, Plastico");
else if (maior == A)
    Console.WriteLine("(Artístico) = Design de Produto, Impressão 3D, Comunicação Visual, Costura");
else if (maior == S)
    Console.WriteLine("(Social) = Segurança do Trabalho, Educação, Saúde Ocupacional");
else if (maior == E)
    Console.WriteLine("(Empreendedor) = Gestão, Vendas Técnicas, Logística");
else if (maior == C)
    Console.WriteLine("(Convencional) = Administração, Controle de Qualidade, Planejamento");
