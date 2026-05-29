# Métodos

Métodos são um tipo especial de propriedade, são funções que pertencem ao objeto no qual são inseridos. Estes métodos podem receber valores externos como qualquer função, mas podem também acessar valores internos do objeto através da palavra `this`.

Sabem a função `console.log` que tanto usamos?
`console` é um objeto, e `log` é um método dentro deste objeto.

Vejamos um exemplo abaixo de objeto com métodos:

```javascript
const celular = {
    modelo: "Poco X7 Pro",
    ligado: false,
    programas: {
        classroom: false,
        slack: false,
        meet: false,
    },
    ligarOuDesligar: function() {
        this.ligado = !this.ligado
    },
    abrirPrograma: function(programa) {
        if (programa === this.programas.classroom) {
            this.programas.classroom = true
        }
        if (programa === this.programas.slack) {
            this.programas.slack = true
        }
        if (programa === this.programas.meet) {
            this.programas.meet = true
        }
    },
    fecharPrograma: function(programa) {
        if (programa === this.programas.classroom) {
            this.programas.classroom = false
        }
        if (programa === this.programas.slack) {
            this.programas.slack = false
        }
        if (programa === this.programas.meet) {
            this.programas.meet = false
        }
    },
}
```

Os métodos `ligarOuDesligar`, `abrirPrograma` e `fecharPrograma` usam a palavra `this` como uma forma de representar o objeto do qual fazem parte, e a partir dele acessar outras propriedades dentro do mesmo objeto.

Os métodos `abrirPrograma` e `fecharPrograma` também recebem um argumento chamado `programa`, para decidir qual programa abrir ou fechar.

Como são chamados estes métodos? Fora do objeto, após o objeto ser criado:

```javascript
celular.ligarOuDesligar() // Liga ou desliga o celular
celular.abrir("slack") // Abre o slack
celular.fechar("slack") // Fecha o slack
```
