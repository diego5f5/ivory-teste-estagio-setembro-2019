<h1>Teste de estágio IVORY</h1>


<h2>Questão 1</h2>


<img src="https://i.imgur.com/LXdmFG7.png">

<h3>O que este código faz ?</h3>

- A função do código acima é basicamente calcular o fatorial de um número preestabelecido, neste caso o número 5, representado matematicamente por 5!. 

<h4>Lógica de cálculo de um número fatorial:</h4>

O fatorial de um número é dado pela fórmula:

`
n! = n * (n-1) * (n-2) * ... 1
`

Sendo que 1! e 0! são iguais a 1. Assim, 5! é igual a :

`
5! = 5 * 4 * 3 * 2 * 1 = 120
`

<h3>Como funciona ?</h3> 

- São declaras as variáveis do tipo inteiro: numero e resultado, das quais "numero" representa o valor do qual queremos calcular o fatorial, e o "resultado" a qual receberá o retorno da função Calcular(). 

- Na função Calcular() é recebido como parâmetro a variável "numero", onde a fatoração ocorrerá por recursividade, ou seja a função é chamada dentro dela mesma até que haja um condição de parada, neste caso será o caso "base", onde numero é menor ou igual a 1, conforme o trecho de código abaixo:
```
if (numero <= 1)
{
    return (1);
}
```


<h3>Funcionamento ilustrado:</h3>

<img src="https://i.imgur.com/dPq7lV1.png">
