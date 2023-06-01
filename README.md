# PomodoroApp
update 1.0

# PomodoroApp
update 1.0

# PomodoroApp

## Descrição do Projeto
PomodoroApp é um aplicativo de cronômetro baseado na técnica de Pomodoro, uma abordagem de gerenciamento de tempo desenvolvida por Francesco Cirillo no final dos anos 1980. O aplicativo permite que os usuários dividam seu tempo em períodos de trabalho focado, chamados de "Pomodoros", intercalados com breves pausas.

O objetivo do Pomodoro é aumentar a produtividade e melhorar o gerenciamento do tempo, evitando distrações e promovendo um trabalho mais concentrado.

## Funcionalidades
O aplicativo PomodoroApp possui as seguintes funcionalidades:

1. Cronômetro do Pomodoro: O usuário pode iniciar o Pomodoro clicando no botão "Start". O cronômetro começará a contar o tempo definido para o Pomodoro (padrão: 20 minutos) e exibirá o tempo restante em um rótulo na interface do usuário.

2. Pausa: Após o término do Pomodoro, o aplicativo exibirá uma mensagem indicando que o Pomodoro foi concluído e é hora de fazer uma pausa. O usuário pode confirmar a mensagem e iniciar a pausa. O cronômetro começará a contar o tempo definido para a pausa (padrão: 10 minutos) e exibirá o tempo restante.

3. Reiniciar: Após a conclusão da pausa, o aplicativo exibirá uma mensagem indicando que a pausa foi concluída e é hora de começar outro Pomodoro. O usuário pode confirmar a mensagem e reiniciar o processo. O cronômetro será reiniciado para o tempo do Pomodoro e começará a contar novamente.

4. Parar: O usuário pode parar o cronômetro a qualquer momento clicando no botão "Stop". O cronômetro será interrompido e o tempo restante será mantido. O usuário pode retomar o cronômetro clicando novamente no botão "Start".

## Como Usar
1. Clone ou faça o download do repositório para o seu ambiente de desenvolvimento.

2. Abra o projeto no Visual Studio ou em qualquer outra IDE que seja compatível com C# e Windows Forms.

3. Compile e execute o projeto.

4. Na interface do usuário do PomodoroApp, clique no botão "Start" para iniciar o Pomodoro. O cronômetro começará a contar o tempo definido para o Pomodoro.

5. Após o término do Pomodoro, uma mensagem será exibida indicando que é hora de fazer uma pausa. Clique em "OK" para iniciar a pausa.

6. Após a conclusão da pausa, uma mensagem será exibida indicando que é hora de começar outro Pomodoro. Clique em "OK" para reiniciar o processo.

7. Para parar o cronômetro a qualquer momento, clique no botão "Stop". Para retomar o cronômetro, clique novamente em "Start".

## Personalização
O aplicativo PomodoroApp possui valores padrão para a duração do Pomodoro e da pausa (20 minutos e 10 minutos, respectivamente). Caso deseje alterar esses valores, você pode modificar as variáveis `pomodoroTime` e `breakTime` no código-fonte.

```csharp
private TimeSpan pomodoroTime = TimeSpan.FromMinutes(20);
private TimeSpan breakTime = TimeSpan.FromMinutes(10);
```  
  
## Contribuição
Contribuições são sempre bem-vindas! Se você tiver alguma melhoria ou nova funcionalidade que gostaria de adicionar ao PomodoroApp, fique à vontade para abrir uma "issue" ou enviar um "pull request".

##Licença
Este projeto está licenciado sob a MIT License. Sinta-se livre para utilizar, modificar e distribuir o código conforme necessário.

Esperamos que o PomodoroApp seja útil para melhorar sua produtividade e gerenciamento do tempo. Aproveite e bons Pomodoros!
