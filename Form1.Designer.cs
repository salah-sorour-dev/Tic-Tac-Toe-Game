namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTurn = new System.Windows.Forms.Label();
            this.lblWinner = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRestart = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Mongolian Baiti", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(506, 32);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(659, 85);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Tic-Tac-Toe Game";
            this.lblTitle.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(131, 310);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 43);
            this.label1.TabIndex = 1;
            this.label1.Text = "Turn";
            // 
            // lblTurn
            // 
            this.lblTurn.AutoSize = true;
            this.lblTurn.Font = new System.Drawing.Font("Mongolian Baiti", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTurn.ForeColor = System.Drawing.Color.White;
            this.lblTurn.Location = new System.Drawing.Point(107, 354);
            this.lblTurn.Name = "lblTurn";
            this.lblTurn.Size = new System.Drawing.Size(159, 43);
            this.lblTurn.TabIndex = 2;
            this.lblTurn.Text = "Player 1";
            // 
            // lblWinner
            // 
            this.lblWinner.AutoSize = true;
            this.lblWinner.Font = new System.Drawing.Font("Mongolian Baiti", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWinner.ForeColor = System.Drawing.Color.Lime;
            this.lblWinner.Location = new System.Drawing.Point(76, 445);
            this.lblWinner.Name = "lblWinner";
            this.lblWinner.Size = new System.Drawing.Size(211, 43);
            this.lblWinner.TabIndex = 4;
            this.lblWinner.Text = "In Progress";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mongolian Baiti", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Yellow;
            this.label3.Location = new System.Drawing.Point(109, 401);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 43);
            this.label3.TabIndex = 3;
            this.label3.Text = "Winner";
            // 
            // btnRestart
            // 
            this.btnRestart.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRestart.Font = new System.Drawing.Font("Mongolian Baiti", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestart.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRestart.Location = new System.Drawing.Point(58, 509);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(246, 53);
            this.btnRestart.TabIndex = 5;
            this.btnRestart.Text = "Restart Game";
            this.btnRestart.UseVisualStyleBackColor = false;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Image = global::WindowsFormsApp1.Properties.Resources.question_mark_96;
            this.button1.Location = new System.Drawing.Point(537, 178);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(184, 151);
            this.button1.TabIndex = 6;
            this.button1.Tag = "?";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button2.Image = global::WindowsFormsApp1.Properties.Resources.question_mark_96;
            this.button2.Location = new System.Drawing.Point(758, 178);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(184, 151);
            this.button2.TabIndex = 7;
            this.button2.Tag = "?";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button3.Image = global::WindowsFormsApp1.Properties.Resources.question_mark_96;
            this.button3.Location = new System.Drawing.Point(972, 178);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(184, 151);
            this.button3.TabIndex = 8;
            this.button3.Tag = "?";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Transparent;
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button6.Image = global::WindowsFormsApp1.Properties.Resources.question_mark_96;
            this.button6.Location = new System.Drawing.Point(972, 355);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(184, 151);
            this.button6.TabIndex = 11;
            this.button6.Tag = "?";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Transparent;
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button5.Image = global::WindowsFormsApp1.Properties.Resources.question_mark_96;
            this.button5.Location = new System.Drawing.Point(758, 355);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(184, 151);
            this.button5.TabIndex = 10;
            this.button5.Tag = "?";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button4.Image = global::WindowsFormsApp1.Properties.Resources.question_mark_96;
            this.button4.Location = new System.Drawing.Point(537, 356);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(184, 151);
            this.button4.TabIndex = 9;
            this.button4.Tag = "?";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.Transparent;
            this.button9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button9.Image = global::WindowsFormsApp1.Properties.Resources.question_mark_96;
            this.button9.Location = new System.Drawing.Point(972, 537);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(184, 151);
            this.button9.TabIndex = 14;
            this.button9.Tag = "?";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Transparent;
            this.button8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button8.Image = global::WindowsFormsApp1.Properties.Resources.question_mark_96;
            this.button8.Location = new System.Drawing.Point(758, 537);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(184, 151);
            this.button8.TabIndex = 13;
            this.button8.Tag = "?";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Transparent;
            this.button7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button7.Image = global::WindowsFormsApp1.Properties.Resources.question_mark_96;
            this.button7.Location = new System.Drawing.Point(537, 538);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(184, 151);
            this.button7.TabIndex = 12;
            this.button7.Tag = "?";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1339, 786);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.lblWinner);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblTurn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTitle);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTurn;
        private System.Windows.Forms.Label lblWinner;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
    }
}

