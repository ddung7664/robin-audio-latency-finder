namespace Robin_Latency_finder
{
    partial class main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.cb_deviceList = new System.Windows.Forms.ComboBox();
            this.lb_latency = new System.Windows.Forms.Label();
            this.bt_runTest = new System.Windows.Forms.Button();
            this.lb_nowDelay = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lb_license = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cb_deviceList
            // 
            this.cb_deviceList.FormattingEnabled = true;
            this.cb_deviceList.Location = new System.Drawing.Point(149, 34);
            this.cb_deviceList.Name = "cb_deviceList";
            this.cb_deviceList.Size = new System.Drawing.Size(498, 20);
            this.cb_deviceList.TabIndex = 0;
            this.cb_deviceList.SelectedIndexChanged += new System.EventHandler(this.cb_deviceList_SelectedIndexChanged);
            // 
            // lb_latency
            // 
            this.lb_latency.AutoSize = true;
            this.lb_latency.Font = new System.Drawing.Font("넥슨Lv1고딕 Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_latency.Location = new System.Drawing.Point(546, 255);
            this.lb_latency.Name = "lb_latency";
            this.lb_latency.Size = new System.Drawing.Size(64, 22);
            this.lb_latency.TabIndex = 1;
            this.lb_latency.Text = "NULL";
            // 
            // bt_runTest
            // 
            this.bt_runTest.Font = new System.Drawing.Font("넥슨Lv1고딕 Bold", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.bt_runTest.Location = new System.Drawing.Point(29, 79);
            this.bt_runTest.Name = "bt_runTest";
            this.bt_runTest.Size = new System.Drawing.Size(618, 111);
            this.bt_runTest.TabIndex = 2;
            this.bt_runTest.Text = "달리다!!!!!";
            this.bt_runTest.UseVisualStyleBackColor = true;
            this.bt_runTest.Click += new System.EventHandler(this.bt_runTest_Click);
            // 
            // lb_nowDelay
            // 
            this.lb_nowDelay.AutoSize = true;
            this.lb_nowDelay.Font = new System.Drawing.Font("넥슨Lv1고딕 Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_nowDelay.Location = new System.Drawing.Point(546, 220);
            this.lb_nowDelay.Name = "lb_nowDelay";
            this.lb_nowDelay.Size = new System.Drawing.Size(64, 22);
            this.lb_nowDelay.TabIndex = 3;
            this.lb_nowDelay.Text = "NULL";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("넥슨Lv1고딕 Bold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(25, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "출력 장치 :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("넥슨Lv1고딕 Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(389, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "현재 지연 시간 :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("넥슨Lv1고딕 Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(389, 255);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 22);
            this.label3.TabIndex = 6;
            this.label3.Text = "평균 지연 시간 :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("넥슨Lv1고딕", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(443, 311);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(176, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Copyright (c) 2024 선동과 날조";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("넥슨Lv2고딕 Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(47, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(181, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "1. RUN 버튼을 클릭한다";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("넥슨Lv2고딕 Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(47, 249);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(240, 18);
            this.label6.TabIndex = 9;
            this.label6.Text = "2. 소리에 맞추어 \"R\" 키를 누른다";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("넥슨Lv2고딕 Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.Location = new System.Drawing.Point(47, 277);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 18);
            this.label7.TabIndex = 10;
            this.label7.Text = "3. 15번 반복한다";
            // 
            // lb_license
            // 
            this.lb_license.AutoSize = true;
            this.lb_license.Font = new System.Drawing.Font("넥슨Lv1고딕", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_license.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lb_license.Location = new System.Drawing.Point(617, 311);
            this.lb_license.Name = "lb_license";
            this.lb_license.Size = new System.Drawing.Size(49, 13);
            this.lb_license.TabIndex = 12;
            this.lb_license.Text = "License";
            this.lb_license.Click += new System.EventHandler(this.lb_license_Click);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 333);
            this.Controls.Add(this.lb_license);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_nowDelay);
            this.Controls.Add(this.bt_runTest);
            this.Controls.Add(this.lb_latency);
            this.Controls.Add(this.cb_deviceList);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "main";
            this.Text = "Robin Audio Latency finder 0.43.2 by 정승수";
            this.Load += new System.EventHandler(this.main_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainScreen_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_deviceList;
        private System.Windows.Forms.Label lb_latency;
        private System.Windows.Forms.Button bt_runTest;
        private System.Windows.Forms.Label lb_nowDelay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lb_license;
    }
}

