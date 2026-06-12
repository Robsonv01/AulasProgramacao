// 1
for (let i = 1; i <= 10; i++) {
    console.log(i);
}

// 2
let contador = 10;

while (contador >= 1) {
    console.log(contador);
    contador--;
}

// 3
for (let i = 0; i <= 20; i++) {
    if (i % 2 == 0) {
        console.log(i);
    }
}

// 4
for (let i = 1; i <= 19; i++) {
    if (i % 2 != 0) {
        console.log(i);
    }
}

// 5
let numero = 5;

for (let i = 1; i <= 10; i++) {
    console.log(numero + " x " + i + " = " + (numero * i));
}

// 6
let soma1 = 0;

for (let i = 1; i <= 100; i++) {
    soma1 += i;
}

console.log("Soma de 1 a 100: " + soma1);

// 7
let notas = [8, 7, 6, 9];
let somaNotas = 0;

for (let i = 0; i < notas.length; i++) {
    somaNotas += notas[i];
}

console.log("Média: " + (somaNotas / notas.length));

// 8
let senha = "";

while (senha != "1234") {
    senha = "1234";
}

console.log("Senha correta!");

// 9
let numeros = [10, -5, 8, -2, 3];
let positivos = 0;

for (let i = 0; i < numeros.length; i++) {
    if (numeros[i] > 0) {
        positivos++;
    }
}

console.log("Positivos: " + positivos);

// 10
let valores = [10, 50, 30, 70, 20];
let maior = valores[0];

for (let i = 1; i < valores.length; i++) {
    if (valores[i] > maior) {
        maior = valores[i];
    }
}

console.log("Maior número: " + maior);

// 11
let produtos = [100, 250, 80, 50, 300];

for (let i = 0; i < produtos.length; i++) {
    let desconto = produtos[i] * 0.9;

    console.log(
        "Produto " + (i + 1) +
        ": de R$" + produtos[i] +
        " por R$" + desconto
    );
}

// 12
let temperaturas = [35, 40, 44, 52, 39, 60, 41];

for (let i = 0; i < temperaturas.length; i++) {
    if (temperaturas[i] > 50) {
        console.log("Alerta no registro " + (i + 1));
    }
}

// 13
let alunos = [3, 2, 5, 1, 4];
let total = 0;

for (let i = 0; i < alunos.length; i++) {
    total += alunos[i];
}

console.log("Total de alunos: " + total);

// 14
let total1 = 0;

for (let semana = 1; semana <= 12; semana++) {
    total1 += 5;

    console.log(
        "Semana " + semana +
        ": R$" + total1
    );
}

// 15
let pedidos = [120, 80, 50, 200, 90, 70];
let acumulado = 0;

for (let i = 0; i < pedidos.length; i++) {
    acumulado += pedidos[i];

    if (acumulado > 500) {
        console.log("Passou de R$500 no pedido " + (i + 1));
        console.log("Total acumulado: R$" + acumulado);
        break;
    }
}
