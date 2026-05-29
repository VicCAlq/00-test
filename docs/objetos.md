# Objetos
## O que são

Aprendemos já que podemos agrupar diversos valores diferentes em uma estrutura chamada "listas", também chamadas de "arrays". Nesta estrutura, cada item pertencente a ela pode ser acessada através de um índice numérico, começando a partir do número zero.

Mas as vezes precisamos de uma forma mais organizada de agrupar os valores, como por exemplo, informações sobre você. Em uma lista, teríamos algo assim:

```javascript
const pessoa = ["Leila", "Lélis", 19, 1.68, "Estudante", "UPE", "Engenharia", "leilalelis@email.com.br", "(81) 9 9445-5667", "Lália Lélis", "Ludmilo Lélis"]
```

Se quiséssemos acessar a informação de que curso essa pessoa está matriculada, precisaríamos referenciar através do nome da lista e do índice: `pessoa[6]`

Mas e se a gente cria a lista em um canto, e precisamos acessar o valor em outra parte distante do código, sem poder ficar olhando fácil pra contar os índices?

Ou se a lista tiver 40 informações diferentes, você vai ficar contando de um em um?

Para organizar as coisas de forma mais adequada nestes casos, podemos usar "Objetos". Vejamos primeiro como funcionam:

```javascript
const pessoa = {
    nome: "Leila", 
    sobrenome:"Lélis", 
    idade: 19, 
    altura: 1.68, 
    profissao: "Estudante", 
    escolaOuFaculdade"UPE", 
    curso: "Engenharia", 
    email: "leilalelis@email.com.br", 
    telefone: "(81) 9 9445-5667", 
    nomeDaMae: "Lália Lélis", 
    nomeDoPai: "Ludmilo Lélis"}
```

Muito mais fácil de entender, né? Cada valor é armazenado em uma "propriedade" ao invés de um "índice". Podemos acessar os valores assim:

`pessoa.nome` vai acessar o nome armazenado no objeto `pessoa`
`pessoa.nomeDaMae` vai acesar o nome da mãe da pessoa, `Lália Lélis` no exemplo.

E se quisermos usar o nome da propriedade a ser acessada de forma dinâmica, podemos usar uma sintaxe parecida com a de acessar um item de uma lista:

`pessoa["sobrenome"]` acessa o sobrenome da pessoa. Note que o texto "sobrenome" está entre áspas neste caso, pois se trata de uma string comum.

```javascript
const nomeDaPropriedade = "curso"
pessoa[nomeDaPropriedade] // Vai informar o nome do curso, pois a variável "nomeDaPropriedade" tem o valor "curso", então a linha tem o mesmo resultado dos exemplos abaixo
pessoa["curso"]
pessoa.curso
// São a mesma coisa

// O exemplo abaixo não funciona, no entanto
pessoa.nomeDaPropriedade
// Por que ele tenta acessar uma propriedade chamada "nomeDaPropriedade"
```
