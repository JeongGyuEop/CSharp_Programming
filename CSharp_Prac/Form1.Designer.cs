namespace CSharp_Prac
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.Btn_JulCha = new System.Windows.Forms.Button();
            this.Btn_Thread = new System.Windows.Forms.Button();
            this.Btn_JulCha2 = new System.Windows.Forms.Button();
            this.Btn_Thread2 = new System.Windows.Forms.Button();
            this.Btn_Thread2_1 = new System.Windows.Forms.Button();
            this.Btn_Thread2_2 = new System.Windows.Forms.Button();
            this.Btn_Foreground = new System.Windows.Forms.Button();
            this.Btn_Background = new System.Windows.Forms.Button();
            this.Btn_Start = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_FileOpen = new System.Windows.Forms.Button();
            this.Btn_Thread_Start = new System.Windows.Forms.Button();
            this.Btn_JoinThread_Start = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btn_JulCha
            // 
            this.Btn_JulCha.Font = new System.Drawing.Font("굴림", 20F);
            this.Btn_JulCha.Location = new System.Drawing.Point(12, 157);
            this.Btn_JulCha.Name = "Btn_JulCha";
            this.Btn_JulCha.Size = new System.Drawing.Size(137, 76);
            this.Btn_JulCha.TabIndex = 0;
            this.Btn_JulCha.Text = "절차";
            this.Btn_JulCha.UseVisualStyleBackColor = true;
            this.Btn_JulCha.Click += new System.EventHandler(this.Btn_JulCha_Click);
            // 
            // Btn_Thread
            // 
            this.Btn_Thread.Font = new System.Drawing.Font("굴림", 20F);
            this.Btn_Thread.Location = new System.Drawing.Point(155, 157);
            this.Btn_Thread.Name = "Btn_Thread";
            this.Btn_Thread.Size = new System.Drawing.Size(137, 76);
            this.Btn_Thread.TabIndex = 1;
            this.Btn_Thread.Text = "뜨레드";
            this.Btn_Thread.UseVisualStyleBackColor = true;
            this.Btn_Thread.Click += new System.EventHandler(this.Btn_Thread_Click);
            // 
            // Btn_JulCha2
            // 
            this.Btn_JulCha2.Font = new System.Drawing.Font("굴림", 20F);
            this.Btn_JulCha2.Location = new System.Drawing.Point(12, 239);
            this.Btn_JulCha2.Name = "Btn_JulCha2";
            this.Btn_JulCha2.Size = new System.Drawing.Size(137, 76);
            this.Btn_JulCha2.TabIndex = 2;
            this.Btn_JulCha2.Text = "절차2";
            this.Btn_JulCha2.UseVisualStyleBackColor = true;
            this.Btn_JulCha2.Click += new System.EventHandler(this.Btn_JulCha2_Click);
            // 
            // Btn_Thread2
            // 
            this.Btn_Thread2.Font = new System.Drawing.Font("굴림", 20F);
            this.Btn_Thread2.Location = new System.Drawing.Point(155, 239);
            this.Btn_Thread2.Name = "Btn_Thread2";
            this.Btn_Thread2.Size = new System.Drawing.Size(137, 76);
            this.Btn_Thread2.TabIndex = 3;
            this.Btn_Thread2.Text = "뜨레드2";
            this.Btn_Thread2.UseVisualStyleBackColor = true;
            this.Btn_Thread2.Click += new System.EventHandler(this.Btn_Thread2_Click);
            // 
            // Btn_Thread2_1
            // 
            this.Btn_Thread2_1.Font = new System.Drawing.Font("굴림", 20F);
            this.Btn_Thread2_1.Location = new System.Drawing.Point(298, 239);
            this.Btn_Thread2_1.Name = "Btn_Thread2_1";
            this.Btn_Thread2_1.Size = new System.Drawing.Size(137, 76);
            this.Btn_Thread2_1.TabIndex = 4;
            this.Btn_Thread2_1.Text = "뜨레드2-1";
            this.Btn_Thread2_1.UseVisualStyleBackColor = true;
            this.Btn_Thread2_1.Click += new System.EventHandler(this.Btn_Thread2_1_Click);
            // 
            // Btn_Thread2_2
            // 
            this.Btn_Thread2_2.Font = new System.Drawing.Font("굴림", 20F);
            this.Btn_Thread2_2.Location = new System.Drawing.Point(441, 239);
            this.Btn_Thread2_2.Name = "Btn_Thread2_2";
            this.Btn_Thread2_2.Size = new System.Drawing.Size(137, 76);
            this.Btn_Thread2_2.TabIndex = 5;
            this.Btn_Thread2_2.Text = "뜨레드2-2";
            this.Btn_Thread2_2.UseVisualStyleBackColor = true;
            this.Btn_Thread2_2.Click += new System.EventHandler(this.Btn_Thread2_2_Click);
            // 
            // Btn_Foreground
            // 
            this.Btn_Foreground.Font = new System.Drawing.Font("굴림", 20F);
            this.Btn_Foreground.Location = new System.Drawing.Point(12, 361);
            this.Btn_Foreground.Name = "Btn_Foreground";
            this.Btn_Foreground.Size = new System.Drawing.Size(159, 76);
            this.Btn_Foreground.TabIndex = 6;
            this.Btn_Foreground.Text = "포그라운드";
            this.Btn_Foreground.UseVisualStyleBackColor = true;
            // 
            // Btn_Background
            // 
            this.Btn_Background.Font = new System.Drawing.Font("굴림", 20F);
            this.Btn_Background.Location = new System.Drawing.Point(177, 361);
            this.Btn_Background.Name = "Btn_Background";
            this.Btn_Background.Size = new System.Drawing.Size(159, 76);
            this.Btn_Background.TabIndex = 7;
            this.Btn_Background.Text = "백그라운드";
            this.Btn_Background.UseVisualStyleBackColor = true;
            // 
            // Btn_Start
            // 
            this.Btn_Start.Font = new System.Drawing.Font("굴림", 12F);
            this.Btn_Start.Location = new System.Drawing.Point(12, 12);
            this.Btn_Start.Name = "Btn_Start";
            this.Btn_Start.Size = new System.Drawing.Size(97, 32);
            this.Btn_Start.TabIndex = 8;
            this.Btn_Start.Text = "작업 시작";
            this.Btn_Start.UseVisualStyleBackColor = true;
            this.Btn_Start.Click += new System.EventHandler(this.Btn_Start_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 15F);
            this.label1.Location = new System.Drawing.Point(18, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 9;
            // 
            // Btn_FileOpen
            // 
            this.Btn_FileOpen.Font = new System.Drawing.Font("굴림", 12F);
            this.Btn_FileOpen.Location = new System.Drawing.Point(12, 50);
            this.Btn_FileOpen.Name = "Btn_FileOpen";
            this.Btn_FileOpen.Size = new System.Drawing.Size(97, 32);
            this.Btn_FileOpen.TabIndex = 10;
            this.Btn_FileOpen.Text = "파일 오픈";
            this.Btn_FileOpen.UseVisualStyleBackColor = true;
            this.Btn_FileOpen.Click += new System.EventHandler(this.Btn_FileOpen_Click);
            // 
            // Btn_Thread_Start
            // 
            this.Btn_Thread_Start.Font = new System.Drawing.Font("굴림", 12F);
            this.Btn_Thread_Start.Location = new System.Drawing.Point(115, 12);
            this.Btn_Thread_Start.Name = "Btn_Thread_Start";
            this.Btn_Thread_Start.Size = new System.Drawing.Size(144, 32);
            this.Btn_Thread_Start.TabIndex = 11;
            this.Btn_Thread_Start.Text = "뜨레드 작업 시작";
            this.Btn_Thread_Start.UseVisualStyleBackColor = true;
            this.Btn_Thread_Start.Click += new System.EventHandler(this.Btn_Thread_Start_Click);
            // 
            // Btn_JoinThread_Start
            // 
            this.Btn_JoinThread_Start.Font = new System.Drawing.Font("굴림", 12F);
            this.Btn_JoinThread_Start.Location = new System.Drawing.Point(265, 12);
            this.Btn_JoinThread_Start.Name = "Btn_JoinThread_Start";
            this.Btn_JoinThread_Start.Size = new System.Drawing.Size(170, 32);
            this.Btn_JoinThread_Start.TabIndex = 12;
            this.Btn_JoinThread_Start.Text = "Join 뜨레드 작업 시작";
            this.Btn_JoinThread_Start.UseVisualStyleBackColor = true;
            this.Btn_JoinThread_Start.Click += new System.EventHandler(this.Btn_JoinThread_Start_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Btn_JoinThread_Start);
            this.Controls.Add(this.Btn_Thread_Start);
            this.Controls.Add(this.Btn_FileOpen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btn_Start);
            this.Controls.Add(this.Btn_Background);
            this.Controls.Add(this.Btn_Foreground);
            this.Controls.Add(this.Btn_Thread2_2);
            this.Controls.Add(this.Btn_Thread2_1);
            this.Controls.Add(this.Btn_Thread2);
            this.Controls.Add(this.Btn_JulCha2);
            this.Controls.Add(this.Btn_Thread);
            this.Controls.Add(this.Btn_JulCha);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_JulCha;
        private System.Windows.Forms.Button Btn_Thread;
        private System.Windows.Forms.Button Btn_JulCha2;
        private System.Windows.Forms.Button Btn_Thread2;
        private System.Windows.Forms.Button Btn_Thread2_1;
        private System.Windows.Forms.Button Btn_Thread2_2;
        private System.Windows.Forms.Button Btn_Foreground;
        private System.Windows.Forms.Button Btn_Background;
        private System.Windows.Forms.Button Btn_Start;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_FileOpen;
        private System.Windows.Forms.Button Btn_Thread_Start;
        private System.Windows.Forms.Button Btn_JoinThread_Start;
    }
}

