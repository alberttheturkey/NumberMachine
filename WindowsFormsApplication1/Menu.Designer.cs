namespace NumberMachine
{
    partial class Menu
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
            this.btnAscReplace = new System.Windows.Forms.Button();
            this.btnIncDec = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAscReplace
            // 
            this.btnAscReplace.Location = new System.Drawing.Point(209, 12);
            this.btnAscReplace.Name = "btnAscReplace";
            this.btnAscReplace.Size = new System.Drawing.Size(191, 88);
            this.btnAscReplace.TabIndex = 0;
            this.btnAscReplace.Text = "Ascending Replace";
            this.btnAscReplace.UseVisualStyleBackColor = true;
            // 
            // btnIncDec
            // 
            this.btnIncDec.Location = new System.Drawing.Point(12, 12);
            this.btnIncDec.Name = "btnIncDec";
            this.btnIncDec.Size = new System.Drawing.Size(191, 88);
            this.btnIncDec.TabIndex = 1;
            this.btnIncDec.Text = "Increment/Decrement";
            this.btnIncDec.UseVisualStyleBackColor = true;
            this.btnIncDec.Click += new System.EventHandler(this.btnIncDec_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(333, 219);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(75, 23);
            this.btnQuit.TabIndex = 2;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 106);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(191, 88);
            this.button1.TabIndex = 1;
            this.button1.Text = "Batch copy generator";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnIncDec_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 254);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnIncDec);
            this.Controls.Add(this.btnAscReplace);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAscReplace;
        private System.Windows.Forms.Button btnIncDec;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Button button1;
    }
}