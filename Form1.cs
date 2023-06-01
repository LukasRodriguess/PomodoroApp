
using System;
using System.Windows.Forms; // ← Namespace que fornece classes para criar interfaces gráficas do usuário no Windows Forms 
using System.Diagnostics; // ← É o namespace que fornece classes para interagir com processos, eventos e contadores do sistema  


namespace PomodoroApp
{
    public partial class MainForm : Form
    {
        // Declaração de variáveis e objetos

        private Stopwatch stopwatch = new Stopwatch(); // ← Um objeto da classe Stopwatch, que permite medir o tempo decorrido.
        private TimeSpan pomodoroTime = TimeSpan.FromSeconds(15); // ← Uma variável do tipo TimeSpan que define a duração do Pomodoro.
        private TimeSpan breakTime = TimeSpan.FromSeconds(10); // ← Uma variável do tipo TimeSpan que define a duração da pausa.

        private bool isPomodoro = true; // ← Uma variável booleana que indica se está no período do Pomodoro ou da pausa.
        private bool pomodoroFinished = false; // ← Uma variável booleana que indica se o Pomodoro foi concluído.
        private bool breakFinished = false; // ← Uma variável booleana que indica se a pausa foi concluída.
        private bool isPause = true; // ← Uma variável booleana que indica se o Pomodoro está pausado.

        public MainForm()
        {
            InitializeComponent();
            lblTimer.Text = pomodoroTime.ToString(@"mm\:ss");
        }

        // Eventos e métodos ↓

        private void btnStart_Click_1(object sender, EventArgs e)
        {
            
            if (isPause) // ← Verifica se o Pomodoro está pausado 
            {
                // ↓ Exibe um MessageBox para confirmar a ação
                DialogResult result = MessageBox.Show("Deseja iniciar o Pomodoro?", "Confirmação", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    isPause = false;

                    if (!stopwatch.IsRunning) // ← Inicia o timer e o stopwatch
                    {
                        timer.Interval = 1000; // ← Intervalo de 1 segundo
                        timer.Start();
                        stopwatch.Start();
                        btnStart.Enabled = false;
                        btnStop.Enabled = true;
                    }
                }
            }
        }

        /*
         Esse é o evento btnStart_Click, que é acionado quando o botão "Start" é clicado. Ele verifica se o Pomodoro está pausado (variável isPaused). 
         Caso esteja, exibe um MessageBox de confirmação e, se a resposta for afirmativa (DialogResult.Yes), inicia o Pomodoro.

         O timer é iniciado (timer.Start()) e o stopwatch começa a contar o tempo (stopwatch.Start()). Além disso, o botão "Start" é desabilitado (btnStart.Enabled = false) 
         e o botão "Stop" é habilitado (btnStop.Enabled = true).
         */

        private void btnStop_Click(object sender, EventArgs e)
        {

            if (stopwatch.IsRunning)
            {
                DialogResult result = MessageBox.Show("Deseja parar o Pomodoro?", "Confirmação", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    timer.Stop();
                    stopwatch.Stop();
                    btnStart.Enabled = true;
                    btnStop.Enabled = false;
                    isPause = true;
                }
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            TimeSpan elapsedTime = stopwatch.Elapsed;

            if (isPomodoro && elapsedTime >= pomodoroTime && !pomodoroFinished)
            {
                pomodoroFinished |= true;
                timer.Stop();
                stopwatch.Stop();
                DialogResult result = MessageBox.Show("Pomodoro Concluido. Hora de fazer uma pausa");

                if (result == DialogResult.OK)
                {
                    stopwatch.Restart();
                    lblTimer.Text = breakTime.ToString(@"mm\:ss");
                    isPomodoro = false;
                    pomodoroFinished = false;
                    timer.Start();
                    stopwatch.Start();
                }
            }
            else if (!isPomodoro && elapsedTime >= breakTime && !breakFinished)
            {
                breakFinished = true;
                timer.Stop();
                stopwatch.Stop();
                DialogResult result = MessageBox.Show("Pausa concluida. Hora de voltar ao foco");

                if (result == DialogResult.OK)
                {
                    stopwatch.Restart();
                    lblTimer.Text = breakTime.ToString(@"mm\:ss");
                    isPomodoro = true;
                    breakFinished = false;
                    timer.Start();
                    stopwatch.Start();

                }
            }
            else
            {
                TimeSpan remainingTime = (isPomodoro ? pomodoroTime : breakTime) - elapsedTime;
                lblTimer.Text = remainingTime.ToString(@"mm\:ss");
            }
        }

    }
}