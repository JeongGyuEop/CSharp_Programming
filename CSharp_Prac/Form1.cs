using System;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace CSharp_Prac
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Btn_Start_Click(object sender, EventArgs e)
        {
            label1.Text = "작업 시작됨...";
            /*
                - 라벨이 바뀌기 전에 UI 멈춰서 표시 X
                    라벨 변경이 실행된 직후에 바로 UI가 바뀌는게 아니라 UI 그리기 작업은 나중에 처리될 큐(Queue)에 등록됨.
                    그래서 메인 스레드가 그리기 전에 멈추기 때문에 화면에 표시되지 않고, 코드 실행이 끝나고 나서야 한꺼번에 UI 갱신

                - UI 자체가 응답이 없음
                    Btn_Start는 메인 스레드에서 실행되는데, 오래걸리는 작업이 있으면 메인 스레드는 다른 작업을 못함.
                    즉, 화면을 다시 그리는 일(UI 처리)도 못해서 응답 없음 상태가 됨.
             */

            // 오래 걸리는 작업 (메인 스레드에서 실행됨)
            for (int i = 0; i < 5; i++)
            {
                Thread.Sleep(1000); // 1초씩 멈춤
                Console.WriteLine($"진행 중 ... {i + 1}초");
            }

            label1.Text = "작업 완료!";
        }
        private void Btn_FileOpen_Click(object sender, EventArgs e)
        {
            label1.Text = "파일 읽는 중...";
            string content = File.ReadAllText("C:\\큰파일.txt");  // 오래 걸리는 작업
            label1.Text = "파일 읽기 완료!";
        }

        private void Btn_Thread_Start_Click(object sender, EventArgs e)
        {
            label1.Text = "작업 시작됨 ...";
            Thread thread = new Thread(BackgroundWork);
            thread.Start();
        }
        private void BackgroundWork()
        {
            for (int i = 0; i < 5; i++)
            {
                Thread.Sleep(1000);
                Console.WriteLine($"[스레드] {i + 1}초 경과");
            }

            /*
                label1.Text = "작업 완료!";  
                
                오류 발생
                lable1은 메인(UI) 스레드가 만든 컨트롤
                다른 스레드에서는 label1을 직접 건드릴 수 없음
                UI 작업은 메인스레드만 할 수 있도록 제한되어 있음
            */

            // Invoke: 메인 스레드에서 동작하도록 해주는 기능
            this.Invoke(new MethodInvoker(UpdateLabel));
            // InvokeRequired: Invoke가 필요한 상황인지 체크(현재 실행중인 스레드가 메인인지 아닌지)
        }
        private void UpdateLabel()
        {
            label1.Text = "작업 완료!";
        }

        private void Btn_JoinThread_Start_Click(object sender, EventArgs e)
        {
            label1.Text = "작업 시작됨 ...";

            Thread thread = new Thread(LongTask);
            thread.Start();

            // 스레드가 끝날 때까지 기다리기
            thread.Join(); // 메인 스레드를 여기서 멈춤!!

            label1.Text = "작업 완료!";
        }
        private void LongTask()
        {
            for (int i = 0; i < 5; i++)
            {
                Thread.Sleep(1000);
                Console.WriteLine($"[LongTask] {i + 1}초 경과");
            }
        }

        // ============================================================================================
        // ============================================================================================
        private void Btn_JulCha_Click(object sender, EventArgs e)
        {
            Run(0);
            Run(1);
        } // ========== 절차
        private void Btn_Thread_Click(object sender, EventArgs e)
        {
            Thread thread0 = new Thread(new ParameterizedThreadStart(Run));
            thread0.Start(0);
            Thread.Sleep(100);
            thread0.Abort(); // 함수의 종료를 보장하지 않고 어느 시점이던지 상관 없이 도중에 강제로 중단(예외 발생: 'System.Threading.ThreadAbortException')
                             // 스레드 강제 종료가 시스템에 심각한 영향이 없다는 보장이 있을 때만 사용하는 것이 좋다.

            Thread thread1 = new Thread(new ParameterizedThreadStart(Run));
            thread1.Start(1); 
            Thread.Sleep(100);
            thread1.Join(); // 함수의 종료를 보장하며 스레드가 동작시키는 중인 함수의 끝에 도달하기를 기다린 다음 스레드 종료
        } // ========== 스레드
        void Run(object obj)
        {
            try
            {
                Console.WriteLine(string.Format("Run {0} Start", obj));

                for (int i=0; i<100; i++)
                {
                    Console.WriteLine(string.Format("Run {0} :: {1}", obj, i));
                    Thread.Sleep(10);
                }

                Console.WriteLine(string.Format("Run {0} End", obj));

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        } // 호출 함수

        private void Btn_JulCha2_Click(object sender, EventArgs e)
        {
            Run2();
        }
        private void Btn_Thread2_Click(object sender, EventArgs e)
        {
            Thread th2 = new Thread(new ThreadStart(Run2));
            th2.Start();
        }
        private void Btn_Thread2_1_Click(object sender, EventArgs e)
        {
            Thread th2_1 = new Thread(new ThreadStart(Run2));
            th2_1.Start();
        }
        private void Btn_Thread2_2_Click(object sender, EventArgs e)
        {
            Thread th2_2 = new Thread(new ThreadStart(Run2));
            th2_2.Start();
        }
        void Run2()
        {
            for(int i=0; i<int.MaxValue; i++)
            {
            }
            Console.WriteLine("Run2 함수 종료");
        }

        
    }
}
