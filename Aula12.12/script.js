function calcularIMC() {
    let peso = document.getElementById("peso").value;
    let altura = document.getElementById("altura").value;
    let resultado = document.getElementById("resultado");

    // Validações
    if (peso === "" || altura === "") {
        resultado.innerHTML = "❌ Preencha todos os campos!";
        resultado.style.color = "red";
        return;
    }

    peso = parseFloat(peso);
    altura = parseFloat(altura);

    if (peso <= 0 || altura <= 0) {
        resultado.innerHTML = "❌ Valores inválidos!";
        resultado.style.color = "red";
        return;
    }

    // Cálculo IMC
    let imc = peso / (altura * altura);
    imc = imc.toFixed(2);

    let classificacao = "";

    if (imc < 18.5) {
        classificacao = "Abaixo do peso";
    } else if (imc < 25) {
        classificacao = "Peso normal";
    } else if (imc < 30) {
        classificacao = "Sobrepeso";
    } else {
        classificacao = "Obesidade";
    }

    resultado.style.color = "black";
    resultado.innerHTML = `Seu IMC é <b>${imc}</b> (${classificacao})`;
}
