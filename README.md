# ValidaSenha

Esta documentação se reflete na criação de uma aplicação que valida se uma senha é válida ou não de acordo com as seguintes regras:

- Mínimo de 9 caracteres
- Ao menos 1 letra minúscula
- Ao menos 1 letra maiúscula
- Ao menos 1 número
- Ao menos 1 caractere especial

Para isso, seguimos os seguintes passos:

- Implementação das regras de validação em classes separadas que implementam a interface IPasswordValida
- Criação de uma classe Validator que usa as regras implementadas e valida a senha
- Criação de uma classe ValidatorFactory que instancia a classe Validator com as regras implementadas
- Criação da interface IPasswordValidatorService que define o método ValidatePassword para validar senhas
- Implementação da classe PasswordValidatorService que implementa a interface IPasswordValidatorService e usa os métodos Validadores para validar senhas
- Criação da classe PasswordValidationException para lançar exceções caso a senha seja inválida
- Criação de uma API que expõe um endpoint HTTP POST que recebe uma senha no corpo da requisição e retorna true caso a senha seja válida e false caso contrário
- Criação de testes unitários para validar a funcionalidade da aplicação
- Organização do código em pastas de acordo com o conceito de Clean Code
- Utilização de injeção de dependência para evitar acoplamento entre as classes e facilitar os testes
