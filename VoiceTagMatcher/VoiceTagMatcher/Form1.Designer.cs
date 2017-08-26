namespace VoiceTagMatcher
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.processBtn = new System.Windows.Forms.Button();
            this.tagFileOpenBtn = new System.Windows.Forms.Button();
            this.voiceFileOpenBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tagFileTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.voiceFileTextBox = new System.Windows.Forms.TextBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tagComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.confidenceTxtBox = new System.Windows.Forms.TextBox();
            this.startTxtBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.endTxtBox = new System.Windows.Forms.TextBox();
            this.margineNumerical = new System.Windows.Forms.NumericUpDown();
            this.playBtn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.nextBtn = new System.Windows.Forms.Button();
            this.previousBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.margineNumerical)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.processBtn);
            this.groupBox1.Controls.Add(this.tagFileOpenBtn);
            this.groupBox1.Controls.Add(this.voiceFileOpenBtn);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tagFileTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.voiceFileTextBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(587, 128);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Input";
            // 
            // processBtn
            // 
            this.processBtn.Location = new System.Drawing.Point(503, 99);
            this.processBtn.Name = "processBtn";
            this.processBtn.Size = new System.Drawing.Size(75, 23);
            this.processBtn.TabIndex = 6;
            this.processBtn.Text = "Process";
            this.processBtn.UseVisualStyleBackColor = true;
            this.processBtn.Click += new System.EventHandler(this.processBtn_Click);
            // 
            // tagFileOpenBtn
            // 
            this.tagFileOpenBtn.Location = new System.Drawing.Point(503, 56);
            this.tagFileOpenBtn.Name = "tagFileOpenBtn";
            this.tagFileOpenBtn.Size = new System.Drawing.Size(75, 23);
            this.tagFileOpenBtn.TabIndex = 5;
            this.tagFileOpenBtn.Text = "Browse";
            this.tagFileOpenBtn.UseVisualStyleBackColor = true;
            this.tagFileOpenBtn.Click += new System.EventHandler(this.TagFileOpenBtn_Click);
            // 
            // voiceFileOpenBtn
            // 
            this.voiceFileOpenBtn.Location = new System.Drawing.Point(503, 19);
            this.voiceFileOpenBtn.Name = "voiceFileOpenBtn";
            this.voiceFileOpenBtn.Size = new System.Drawing.Size(75, 23);
            this.voiceFileOpenBtn.TabIndex = 4;
            this.voiceFileOpenBtn.Text = "Browse";
            this.voiceFileOpenBtn.UseVisualStyleBackColor = true;
            this.voiceFileOpenBtn.Click += new System.EventHandler(this.VoiceFileOpenBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tag File:";
            // 
            // tagFileTextBox
            // 
            this.tagFileTextBox.Location = new System.Drawing.Point(79, 58);
            this.tagFileTextBox.Name = "tagFileTextBox";
            this.tagFileTextBox.ReadOnly = true;
            this.tagFileTextBox.Size = new System.Drawing.Size(418, 20);
            this.tagFileTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Voice File:";
            // 
            // voiceFileTextBox
            // 
            this.voiceFileTextBox.Location = new System.Drawing.Point(79, 20);
            this.voiceFileTextBox.Name = "voiceFileTextBox";
            this.voiceFileTextBox.ReadOnly = true;
            this.voiceFileTextBox.Size = new System.Drawing.Size(418, 20);
            this.voiceFileTextBox.TabIndex = 0;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.previousBtn);
            this.groupBox2.Controls.Add(this.nextBtn);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.playBtn);
            this.groupBox2.Controls.Add(this.margineNumerical);
            this.groupBox2.Controls.Add(this.endTxtBox);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.startTxtBox);
            this.groupBox2.Controls.Add(this.confidenceTxtBox);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.tagComboBox);
            this.groupBox2.Location = new System.Drawing.Point(12, 146);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(587, 100);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Control";
            // 
            // tagComboBox
            // 
            this.tagComboBox.FormattingEnabled = true;
            this.tagComboBox.Location = new System.Drawing.Point(65, 32);
            this.tagComboBox.Name = "tagComboBox";
            this.tagComboBox.Size = new System.Drawing.Size(121, 21);
            this.tagComboBox.TabIndex = 0;
            this.tagComboBox.SelectedIndexChanged += new System.EventHandler(this.tagComboBox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tag:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(211, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Confidence:";
            // 
            // confidenceTxtBox
            // 
            this.confidenceTxtBox.Location = new System.Drawing.Point(278, 34);
            this.confidenceTxtBox.Name = "confidenceTxtBox";
            this.confidenceTxtBox.ReadOnly = true;
            this.confidenceTxtBox.Size = new System.Drawing.Size(100, 20);
            this.confidenceTxtBox.TabIndex = 3;
            // 
            // startTxtBox
            // 
            this.startTxtBox.Location = new System.Drawing.Point(65, 66);
            this.startTxtBox.Name = "startTxtBox";
            this.startTxtBox.ReadOnly = true;
            this.startTxtBox.Size = new System.Drawing.Size(100, 20);
            this.startTxtBox.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Start:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(182, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "End:";
            // 
            // endTxtBox
            // 
            this.endTxtBox.Location = new System.Drawing.Point(214, 66);
            this.endTxtBox.Name = "endTxtBox";
            this.endTxtBox.ReadOnly = true;
            this.endTxtBox.Size = new System.Drawing.Size(100, 20);
            this.endTxtBox.TabIndex = 7;
            // 
            // margineNumerical
            // 
            this.margineNumerical.Location = new System.Drawing.Point(458, 35);
            this.margineNumerical.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.margineNumerical.Name = "margineNumerical";
            this.margineNumerical.Size = new System.Drawing.Size(120, 20);
            this.margineNumerical.TabIndex = 8;
            // 
            // playBtn
            // 
            this.playBtn.Location = new System.Drawing.Point(503, 71);
            this.playBtn.Name = "playBtn";
            this.playBtn.Size = new System.Drawing.Size(75, 23);
            this.playBtn.TabIndex = 8;
            this.playBtn.Text = "Play";
            this.playBtn.UseVisualStyleBackColor = true;
            this.playBtn.Click += new System.EventHandler(this.playBtn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(391, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Margin(ms):";
            // 
            // nextBtn
            // 
            this.nextBtn.Location = new System.Drawing.Point(422, 71);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(75, 23);
            this.nextBtn.TabIndex = 10;
            this.nextBtn.Text = "Next";
            this.nextBtn.UseVisualStyleBackColor = true;
            this.nextBtn.Click += new System.EventHandler(this.nextBtn_Click);
            // 
            // previousBtn
            // 
            this.previousBtn.Location = new System.Drawing.Point(341, 71);
            this.previousBtn.Name = "previousBtn";
            this.previousBtn.Size = new System.Drawing.Size(75, 23);
            this.previousBtn.TabIndex = 11;
            this.previousBtn.Text = "Previous";
            this.previousBtn.UseVisualStyleBackColor = true;
            this.previousBtn.Click += new System.EventHandler(this.previousBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 257);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Main Window";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.margineNumerical)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button tagFileOpenBtn;
        private System.Windows.Forms.Button voiceFileOpenBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tagFileTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox voiceFileTextBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button processBtn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button playBtn;
        private System.Windows.Forms.NumericUpDown margineNumerical;
        private System.Windows.Forms.TextBox endTxtBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox startTxtBox;
        private System.Windows.Forms.TextBox confidenceTxtBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox tagComboBox;
        private System.Windows.Forms.Button previousBtn;
        private System.Windows.Forms.Button nextBtn;
    }
}

