namespace TTTNicos
{
    partial class Form2
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
            this.chooseXButton = new System.Windows.Forms.Button();
            this.chooseOButton = new System.Windows.Forms.Button();
            this.exitButtonForm2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // chooseXButton
            // 
            this.chooseXButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chooseXButton.Location = new System.Drawing.Point(112, 75);
            this.chooseXButton.Name = "chooseXButton";
            this.chooseXButton.Size = new System.Drawing.Size(125, 119);
            this.chooseXButton.TabIndex = 0;
            this.chooseXButton.Text = "X";
            this.chooseXButton.UseVisualStyleBackColor = true;
            this.chooseXButton.Click += new System.EventHandler(this.chooseXButton_Click);
            // 
            // chooseOButton
            // 
            this.chooseOButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chooseOButton.Location = new System.Drawing.Point(284, 75);
            this.chooseOButton.Name = "chooseOButton";
            this.chooseOButton.Size = new System.Drawing.Size(125, 119);
            this.chooseOButton.TabIndex = 1;
            this.chooseOButton.Text = "O";
            this.chooseOButton.UseVisualStyleBackColor = true;
            this.chooseOButton.Click += new System.EventHandler(this.chooseOButton_Click);
            // 
            // exitButtonForm2
            // 
            this.exitButtonForm2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitButtonForm2.Location = new System.Drawing.Point(448, 218);
            this.exitButtonForm2.Name = "exitButtonForm2";
            this.exitButtonForm2.Size = new System.Drawing.Size(77, 27);
            this.exitButtonForm2.TabIndex = 2;
            this.exitButtonForm2.Text = "Exit";
            this.exitButtonForm2.UseVisualStyleBackColor = true;
            this.exitButtonForm2.Click += new System.EventHandler(this.exitButtonForm2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Please choose your symbol:";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.CancelButton = this.exitButtonForm2;
            this.ClientSize = new System.Drawing.Size(537, 257);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exitButtonForm2);
            this.Controls.Add(this.chooseOButton);
            this.Controls.Add(this.chooseXButton);
            this.MaximumSize = new System.Drawing.Size(553, 296);
            this.MinimumSize = new System.Drawing.Size(553, 296);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tic Tac Toe - Choose your symbol";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button chooseXButton;
        private System.Windows.Forms.Button chooseOButton;
        private System.Windows.Forms.Button exitButtonForm2;
        private System.Windows.Forms.Label label1;
    }
}