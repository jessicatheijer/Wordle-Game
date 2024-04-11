namespace THA_06_JESSICA_T
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
            this.label_wordle = new System.Windows.Forms.Label();
            this.label_set = new System.Windows.Forms.Label();
            this.textBox_InputUser = new System.Windows.Forms.TextBox();
            this.button_Play = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_wordle
            // 
            this.label_wordle.AutoSize = true;
            this.label_wordle.Font = new System.Drawing.Font("Goudy Stout", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_wordle.ForeColor = System.Drawing.Color.Navy;
            this.label_wordle.Location = new System.Drawing.Point(64, 9);
            this.label_wordle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_wordle.Name = "label_wordle";
            this.label_wordle.Size = new System.Drawing.Size(234, 37);
            this.label_wordle.TabIndex = 0;
            this.label_wordle.Text = "WORDLE";
            // 
            // label_set
            // 
            this.label_set.AutoSize = true;
            this.label_set.Font = new System.Drawing.Font("Snap ITC", 8.25F);
            this.label_set.Location = new System.Drawing.Point(64, 49);
            this.label_set.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_set.Name = "label_set";
            this.label_set.Size = new System.Drawing.Size(235, 30);
            this.label_set.TabIndex = 1;
            this.label_set.Text = "Please set how many times you can \r\nguess before playing";
            this.label_set.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label_set.Click += new System.EventHandler(this.label_set_Click);
            // 
            // textBox_InputUser
            // 
            this.textBox_InputUser.Font = new System.Drawing.Font("Goudy Stout", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_InputUser.Location = new System.Drawing.Point(132, 87);
            this.textBox_InputUser.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_InputUser.Name = "textBox_InputUser";
            this.textBox_InputUser.Size = new System.Drawing.Size(103, 48);
            this.textBox_InputUser.TabIndex = 2;
            this.textBox_InputUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_InputUser.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_InputUser_KeyPress);
            // 
            // button_Play
            // 
            this.button_Play.BackColor = System.Drawing.Color.GreenYellow;
            this.button_Play.Font = new System.Drawing.Font("Goudy Stout", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Play.ForeColor = System.Drawing.Color.MidnightBlue;
            this.button_Play.Location = new System.Drawing.Point(142, 142);
            this.button_Play.Margin = new System.Windows.Forms.Padding(2);
            this.button_Play.Name = "button_Play";
            this.button_Play.Size = new System.Drawing.Size(80, 31);
            this.button_Play.TabIndex = 3;
            this.button_Play.Text = "PLAY!";
            this.button_Play.UseVisualStyleBackColor = false;
            this.button_Play.Click += new System.EventHandler(this.button_Play_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(372, 181);
            this.Controls.Add(this.button_Play);
            this.Controls.Add(this.textBox_InputUser);
            this.Controls.Add(this.label_set);
            this.Controls.Add(this.label_wordle);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Start";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_wordle;
        private System.Windows.Forms.Label label_set;
        private System.Windows.Forms.TextBox textBox_InputUser;
        private System.Windows.Forms.Button button_Play;
    }
}

