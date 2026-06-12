for (let i = 1; i <= 10; i++) {
    console.log(i);
}

//2
let i = 10;

while (i >= 1) {
    console.log(i);
    i--;
}
//3 
for (let i = 0; i <= 20; i++) {
    if (i % 2 == 0) {
        console.log(i);
    }
}
//4
for (let i = 0; i <= 20; i++) {
    if (i % 2 == 0) {
        console.log(i);
    }
}
//5 
let numero = prompt("Digite um número:");
for (let i = 1; i <= 10; i++) {
    console.log(numero + " x " + i + " = " + (numero * i));
}
//6
let soma1 = 0;

for (let i = 1; i <= 100; i++) {
    soma1 += i;
}

console.log(soma);
//7
let soma2 = 0;

for (let i = 1; i <= 100; i++) {
    soma2 += i;
}

console.log(soma2);

//8
let senha = "";

while (senha != "1234") {
    senha = prompt("Digite a senha:");
}

console.log("Senha correta!");
//9 
let senha1 = "";

while (senha1 != "1234") {
    senha1 = prompt("Digite a senha:");
}

console.log("Senha correta!");

//10 
let tentativas = ["1234", "admin", "senha123"];
let senhaCorreta = "senha123";

for (let i = 0; i < tentativas.length; i++) {

    if (tentativas[i] == senhaCorreta) {
        console.log("Acertou na tentativa " + (i + 1));
        break;
    }

}
//11
let produtos = [100, 250, 80, 50, 300];

for (let i = 0; i < produtos.length; i++) {

    let desconto = produtos[i] * 0.9;

    console.log(
        "Produto " + (i + 1) +
        ": de R$" + produtos[i] +
        " por R$" + desconto
    );

}
//12
let temperaturas = [35, 40, 44, 52, 39, 60, 41];

for (let i = 0; i < temperaturas.length; i++) {

    if (temperaturas[i] > 50) {
        console.log("Alerta no registro " + (i + 1));
    }

}
//13
let alunos = [3, 2, 5, 1, 4];
let total = 0;

for (let i = 0; i < alunos.length; i++) {
    total += alunos[i];
}

console.log("Total de alunos: " + total);
//14
let total1 = 0;

for (let semana = 1; semana <= 12; semana++) {

    total1 += 5;

    console.log(
        "Semana " + semana +
        ": R$" + total1
    );

}

//15
let total2 = 0;

for (let semana = 1; semana <= 12; semana++) {

    total2 += 5;

    console.log(
        "Semana " + semana +
        ": R$" + total2
    );

}