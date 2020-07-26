namespace tic_tac {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.p00 = new System.Windows.Forms.Label();
            this.p10 = new System.Windows.Forms.Label();
            this.p11 = new System.Windows.Forms.Label();
            this.p01 = new System.Windows.Forms.Label();
            this.p12 = new System.Windows.Forms.Label();
            this.p21 = new System.Windows.Forms.Label();
            this.p02 = new System.Windows.Forms.Label();
            this.p20 = new System.Windows.Forms.Label();
            this.p22 = new System.Windows.Forms.Label();
            this.ai_get_score = new System.Windows.Forms.Button();
            this.ai_take_turn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // p00
            // 
            this.p00.AutoSize = true;
            this.p00.Location = new System.Drawing.Point(227, 115);
            this.p00.Name = "p00";
            this.p00.Size = new System.Drawing.Size(35, 13);
            this.p00.TabIndex = 0;
            this.p00.Text = "label1";
            this.p00.Click += new System.EventHandler(this.pXX_Click);
            // 
            // p10
            // 
            this.p10.AutoSize = true;
            this.p10.Location = new System.Drawing.Point(315, 115);
            this.p10.Name = "p10";
            this.p10.Size = new System.Drawing.Size(35, 13);
            this.p10.TabIndex = 1;
            this.p10.Text = "label2";
            this.p10.Click += new System.EventHandler(this.pXX_Click);
            // 
            // p11
            // 
            this.p11.AutoSize = true;
            this.p11.Location = new System.Drawing.Point(315, 166);
            this.p11.Name = "p11";
            this.p11.Size = new System.Drawing.Size(35, 13);
            this.p11.TabIndex = 3;
            this.p11.Text = "label3";
            this.p11.Click += new System.EventHandler(this.pXX_Click);
            // 
            // p01
            // 
            this.p01.AutoSize = true;
            this.p01.Location = new System.Drawing.Point(227, 166);
            this.p01.Name = "p01";
            this.p01.Size = new System.Drawing.Size(35, 13);
            this.p01.TabIndex = 2;
            this.p01.Text = "label4";
            this.p01.Click += new System.EventHandler(this.pXX_Click);
            // 
            // p12
            // 
            this.p12.AutoSize = true;
            this.p12.Location = new System.Drawing.Point(315, 216);
            this.p12.Name = "p12";
            this.p12.Size = new System.Drawing.Size(35, 13);
            this.p12.TabIndex = 7;
            this.p12.Text = "label5";
            this.p12.Click += new System.EventHandler(this.pXX_Click);
            // 
            // p21
            // 
            this.p21.AutoSize = true;
            this.p21.Location = new System.Drawing.Point(403, 166);
            this.p21.Name = "p21";
            this.p21.Size = new System.Drawing.Size(35, 13);
            this.p21.TabIndex = 6;
            this.p21.Text = "label6";
            this.p21.Click += new System.EventHandler(this.pXX_Click);
            // 
            // p02
            // 
            this.p02.AutoSize = true;
            this.p02.Location = new System.Drawing.Point(227, 216);
            this.p02.Name = "p02";
            this.p02.Size = new System.Drawing.Size(35, 13);
            this.p02.TabIndex = 5;
            this.p02.Text = "label7";
            this.p02.Click += new System.EventHandler(this.pXX_Click);
            // 
            // p20
            // 
            this.p20.AutoSize = true;
            this.p20.Location = new System.Drawing.Point(403, 115);
            this.p20.Name = "p20";
            this.p20.Size = new System.Drawing.Size(35, 13);
            this.p20.TabIndex = 4;
            this.p20.Text = "label8";
            this.p20.Click += new System.EventHandler(this.pXX_Click);
            // 
            // p22
            // 
            this.p22.AutoSize = true;
            this.p22.Location = new System.Drawing.Point(403, 216);
            this.p22.Name = "p22";
            this.p22.Size = new System.Drawing.Size(35, 13);
            this.p22.TabIndex = 8;
            this.p22.Text = "label9";
            this.p22.Click += new System.EventHandler(this.pXX_Click);
            // 
            // ai_get_score
            // 
            this.ai_get_score.Location = new System.Drawing.Point(12, 12);
            this.ai_get_score.Name = "ai_get_score";
            this.ai_get_score.Size = new System.Drawing.Size(75, 23);
            this.ai_get_score.TabIndex = 9;
            this.ai_get_score.Text = "Get score";
            this.ai_get_score.UseVisualStyleBackColor = true;
            this.ai_get_score.Click += new System.EventHandler(this.button1_Click);
            // 
            // ai_take_turn
            // 
            this.ai_take_turn.Location = new System.Drawing.Point(12, 41);
            this.ai_take_turn.Name = "ai_take_turn";
            this.ai_take_turn.Size = new System.Drawing.Size(75, 23);
            this.ai_take_turn.TabIndex = 10;
            this.ai_take_turn.Text = "AI take turn";
            this.ai_take_turn.UseVisualStyleBackColor = true;
            this.ai_take_turn.Click += new System.EventHandler(this.ai_take_turn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ai_take_turn);
            this.Controls.Add(this.ai_get_score);
            this.Controls.Add(this.p22);
            this.Controls.Add(this.p12);
            this.Controls.Add(this.p21);
            this.Controls.Add(this.p02);
            this.Controls.Add(this.p20);
            this.Controls.Add(this.p11);
            this.Controls.Add(this.p01);
            this.Controls.Add(this.p10);
            this.Controls.Add(this.p00);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label p00;
        private System.Windows.Forms.Label p10;
        private System.Windows.Forms.Label p11;
        private System.Windows.Forms.Label p01;
        private System.Windows.Forms.Label p12;
        private System.Windows.Forms.Label p21;
        private System.Windows.Forms.Label p02;
        private System.Windows.Forms.Label p20;
        private System.Windows.Forms.Label p22;
        private System.Windows.Forms.Button ai_get_score;
        private System.Windows.Forms.Button ai_take_turn;
    }
}

