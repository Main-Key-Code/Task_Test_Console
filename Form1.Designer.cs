
namespace Task_Test_Console
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_RandomStart = new System.Windows.Forms.Button();
            this.btn_RandomStop = new System.Windows.Forms.Button();
            this.btn_NumberStart = new System.Windows.Forms.Button();
            this.btn_RandomRun = new System.Windows.Forms.Button();
            this.btn_NumberStop = new System.Windows.Forms.Button();
            this.btn_NumberRun = new System.Windows.Forms.Button();
            this.btn_TaskStart = new System.Windows.Forms.Button();
            this.txtBox_RandomTask = new System.Windows.Forms.RichTextBox();
            this.btn_TaskStop = new System.Windows.Forms.Button();
            this.btn_TimeRun = new System.Windows.Forms.Button();
            this.txtBox_NumberTask = new System.Windows.Forms.RichTextBox();
            this.txtBox_TimeTask = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btn_RandomStart
            // 
            this.btn_RandomStart.Location = new System.Drawing.Point(680, 54);
            this.btn_RandomStart.Name = "btn_RandomStart";
            this.btn_RandomStart.Size = new System.Drawing.Size(307, 23);
            this.btn_RandomStart.TabIndex = 5;
            this.btn_RandomStart.Text = "Random : Task 시작";
            this.btn_RandomStart.UseVisualStyleBackColor = true;
            this.btn_RandomStart.Click += new System.EventHandler(this.btn_RandomStart_Click);
            // 
            // btn_RandomStop
            // 
            this.btn_RandomStop.Location = new System.Drawing.Point(680, 83);
            this.btn_RandomStop.Name = "btn_RandomStop";
            this.btn_RandomStop.Size = new System.Drawing.Size(307, 23);
            this.btn_RandomStop.TabIndex = 6;
            this.btn_RandomStop.Text = "Random : Task 정지";
            this.btn_RandomStop.UseVisualStyleBackColor = true;
            this.btn_RandomStop.Click += new System.EventHandler(this.btn_RandomStop_Click);
            // 
            // btn_NumberStart
            // 
            this.btn_NumberStart.Location = new System.Drawing.Point(354, 54);
            this.btn_NumberStart.Name = "btn_NumberStart";
            this.btn_NumberStart.Size = new System.Drawing.Size(307, 23);
            this.btn_NumberStart.TabIndex = 7;
            this.btn_NumberStart.Text = "Number Count : Task 시작";
            this.btn_NumberStart.UseVisualStyleBackColor = true;
            this.btn_NumberStart.Click += new System.EventHandler(this.btn_NumberStart_Click);
            // 
            // btn_RandomRun
            // 
            this.btn_RandomRun.Location = new System.Drawing.Point(680, 23);
            this.btn_RandomRun.Name = "btn_RandomRun";
            this.btn_RandomRun.Size = new System.Drawing.Size(307, 23);
            this.btn_RandomRun.TabIndex = 8;
            this.btn_RandomRun.Text = "Random : Task Run";
            this.btn_RandomRun.UseVisualStyleBackColor = true;
            this.btn_RandomRun.Click += new System.EventHandler(this.btn_RandomRun_Click);
            // 
            // btn_NumberStop
            // 
            this.btn_NumberStop.Location = new System.Drawing.Point(354, 83);
            this.btn_NumberStop.Name = "btn_NumberStop";
            this.btn_NumberStop.Size = new System.Drawing.Size(307, 23);
            this.btn_NumberStop.TabIndex = 9;
            this.btn_NumberStop.Text = "Number Count : Task 정지";
            this.btn_NumberStop.UseVisualStyleBackColor = true;
            this.btn_NumberStop.Click += new System.EventHandler(this.btn_NumberStop_Click);
            // 
            // btn_NumberRun
            // 
            this.btn_NumberRun.Location = new System.Drawing.Point(354, 22);
            this.btn_NumberRun.Name = "btn_NumberRun";
            this.btn_NumberRun.Size = new System.Drawing.Size(307, 23);
            this.btn_NumberRun.TabIndex = 10;
            this.btn_NumberRun.Text = "Number Count : Task Run";
            this.btn_NumberRun.UseVisualStyleBackColor = true;
            this.btn_NumberRun.Click += new System.EventHandler(this.btn_NumberRun_Click);
            // 
            // btn_TaskStart
            // 
            this.btn_TaskStart.Location = new System.Drawing.Point(21, 54);
            this.btn_TaskStart.Name = "btn_TaskStart";
            this.btn_TaskStart.Size = new System.Drawing.Size(307, 23);
            this.btn_TaskStart.TabIndex = 11;
            this.btn_TaskStart.Text = "시간 : Task 시작";
            this.btn_TaskStart.UseVisualStyleBackColor = true;
            this.btn_TaskStart.Click += new System.EventHandler(this.btn_TaskStart_Click);
            // 
            // txtBox_RandomTask
            // 
            this.txtBox_RandomTask.Location = new System.Drawing.Point(680, 112);
            this.txtBox_RandomTask.Name = "txtBox_RandomTask";
            this.txtBox_RandomTask.Size = new System.Drawing.Size(307, 600);
            this.txtBox_RandomTask.TabIndex = 2;
            this.txtBox_RandomTask.Text = "";
            // 
            // btn_TaskStop
            // 
            this.btn_TaskStop.Location = new System.Drawing.Point(21, 83);
            this.btn_TaskStop.Name = "btn_TaskStop";
            this.btn_TaskStop.Size = new System.Drawing.Size(307, 23);
            this.btn_TaskStop.TabIndex = 12;
            this.btn_TaskStop.Text = "시간 : Task 정지";
            this.btn_TaskStop.UseVisualStyleBackColor = true;
            this.btn_TaskStop.Click += new System.EventHandler(this.btn_TaskStop_Click);
            // 
            // btn_TimeRun
            // 
            this.btn_TimeRun.Location = new System.Drawing.Point(21, 22);
            this.btn_TimeRun.Name = "btn_TimeRun";
            this.btn_TimeRun.Size = new System.Drawing.Size(307, 23);
            this.btn_TimeRun.TabIndex = 13;
            this.btn_TimeRun.Text = "시간 : Task Run";
            this.btn_TimeRun.UseVisualStyleBackColor = true;
            this.btn_TimeRun.Click += new System.EventHandler(this.btn_TimeRun_Click);
            // 
            // txtBox_NumberTask
            // 
            this.txtBox_NumberTask.Location = new System.Drawing.Point(354, 112);
            this.txtBox_NumberTask.Name = "txtBox_NumberTask";
            this.txtBox_NumberTask.Size = new System.Drawing.Size(307, 600);
            this.txtBox_NumberTask.TabIndex = 3;
            this.txtBox_NumberTask.Text = "";
            // 
            // txtBox_TimeTask
            // 
            this.txtBox_TimeTask.Location = new System.Drawing.Point(21, 112);
            this.txtBox_TimeTask.Name = "txtBox_TimeTask";
            this.txtBox_TimeTask.Size = new System.Drawing.Size(307, 600);
            this.txtBox_TimeTask.TabIndex = 4;
            this.txtBox_TimeTask.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.btn_RandomStart);
            this.Controls.Add(this.btn_RandomStop);
            this.Controls.Add(this.btn_NumberStart);
            this.Controls.Add(this.btn_RandomRun);
            this.Controls.Add(this.btn_NumberStop);
            this.Controls.Add(this.btn_NumberRun);
            this.Controls.Add(this.btn_TaskStart);
            this.Controls.Add(this.txtBox_RandomTask);
            this.Controls.Add(this.btn_TaskStop);
            this.Controls.Add(this.btn_TimeRun);
            this.Controls.Add(this.txtBox_NumberTask);
            this.Controls.Add(this.txtBox_TimeTask);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_RandomStart;
        private System.Windows.Forms.Button btn_RandomStop;
        private System.Windows.Forms.Button btn_NumberStart;
        private System.Windows.Forms.Button btn_RandomRun;
        private System.Windows.Forms.Button btn_NumberStop;
        private System.Windows.Forms.Button btn_NumberRun;
        private System.Windows.Forms.Button btn_TaskStart;
        private System.Windows.Forms.RichTextBox txtBox_RandomTask;
        private System.Windows.Forms.Button btn_TaskStop;
        private System.Windows.Forms.Button btn_TimeRun;
        private System.Windows.Forms.RichTextBox txtBox_NumberTask;
        private System.Windows.Forms.RichTextBox txtBox_TimeTask;
    }
}

