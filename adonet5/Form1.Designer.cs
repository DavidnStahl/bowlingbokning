namespace adonet5
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.sokKunder = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.nyKund = new System.Windows.Forms.Button();
            this.UppdaKund = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(131, 37);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(391, 22);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // sokKunder
            // 
            this.sokKunder.Location = new System.Drawing.Point(555, 36);
            this.sokKunder.Name = "sokKunder";
            this.sokKunder.Size = new System.Drawing.Size(137, 23);
            this.sokKunder.TabIndex = 1;
            this.sokKunder.Text = "Sök kunder";
            this.sokKunder.UseVisualStyleBackColor = true;
            this.sokKunder.Click += new System.EventHandler(this.sokKunder_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kundnamn";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(33, 80);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(659, 276);
            this.listBox1.TabIndex = 3;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // nyKund
            // 
            this.nyKund.Location = new System.Drawing.Point(31, 389);
            this.nyKund.Name = "nyKund";
            this.nyKund.Size = new System.Drawing.Size(153, 23);
            this.nyKund.TabIndex = 4;
            this.nyKund.Text = "Ny Kund";
            this.nyKund.UseVisualStyleBackColor = true;
            this.nyKund.Click += new System.EventHandler(this.nyKund_Click);
            // 
            // UppdaKund
            // 
            this.UppdaKund.Location = new System.Drawing.Point(272, 389);
            this.UppdaKund.Name = "UppdaKund";
            this.UppdaKund.Size = new System.Drawing.Size(206, 23);
            this.UppdaKund.TabIndex = 5;
            this.UppdaKund.Text = "Uppdatera kund";
            this.UppdaKund.UseVisualStyleBackColor = true;
            this.UppdaKund.Click += new System.EventHandler(this.UppdaKund_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(555, 389);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(137, 23);
            this.button4.TabIndex = 6;
            this.button4.Text = "Boka bana";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.UppdaKund);
            this.Controls.Add(this.nyKund);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sokKunder);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button sokKunder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button nyKund;
        private System.Windows.Forms.Button UppdaKund;
        private System.Windows.Forms.Button button4;
    }
}

