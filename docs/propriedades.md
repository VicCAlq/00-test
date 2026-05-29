# Propriedades
Propriedades são como variáveis internas de um objeto. Todas elas devem conter um nome como identificador, e esse nome segue as mesmas regras de nomeação de variáveis comuns:

- Não pode acentos ou cedilhas
- Não pode ter caracteres especiais, exceto o de linha _
- Não pode começar com um número, mas pode ter números no meio do nome
- Idealmente começam com letra minúscula
- Cada palavra que compõe o nome da propriedade após a primeira palavra deve ser marcada com uma maiúscula no começo.

Ao invés de usarmos o sinal de = para atribuir um valor para essa propriedade, usamos o sinal de :

E por fim, para separar uma propriedade da próxima, usamos vírgula. Vejam o exemplo a seguir:

```javascript
const meuObjeto = {
    souUmaPropriedade: "Valor da propriedade",
    propriedadeMemeDaGeracaoDeVoces: 67,
    naMinhaGeracaoEra: 42,
    listaDeItens: [1, 2, 3, "abacate"],
    inception: {
        assistiu: false,
        nota: null,
        vaiAssistir: false,
    },
}
```

Propriedades podem ser de qualquer tipo JavaScript válido: Podem ser strings, números, listas, e até mesmo outros objetos.
