namespace provafinalc
{
    partial class lista31bimexer1a3
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDownprimeirotermo = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownultimotermo = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownrazao = new System.Windows.Forms.NumericUpDown();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.buttonrazao = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownprimeirotermo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownultimotermo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownrazao)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "EXERCICIO 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(241, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "INSIRA O PRIMEIRO TERMO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(241, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "INSIRA O ULTIMO TERMO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(241, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "INSIRA A RAZÃO";
            // 
            // numericUpDownprimeirotermo
            // 
            this.numericUpDownprimeirotermo.Location = new System.Drawing.Point(441, 24);
            this.numericUpDownprimeirotermo.Maximum = new decimal(new int[] {
            -1304428545,
            434162106,
            542,
            0});
            this.numericUpDownprimeirotermo.Name = "numericUpDownprimeirotermo";
            this.numericUpDownprimeirotermo.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownprimeirotermo.TabIndex = 4;
            // 
            // numericUpDownultimotermo
            // 
            this.numericUpDownultimotermo.Location = new System.Drawing.Point(441, 69);
            this.numericUpDownultimotermo.Maximum = new decimal(new int[] {
            -1304428545,
            434162106,
            542,
            0});
            this.numericUpDownultimotermo.Name = "numericUpDownultimotermo";
            this.numericUpDownultimotermo.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownultimotermo.TabIndex = 5;
            // 
            // numericUpDownrazao
            // 
            this.numericUpDownrazao.Location = new System.Drawing.Point(441, 111);
            this.numericUpDownrazao.Maximum = new decimal(new int[] {
            -1304428545,
            434162106,
            542,
            0});
            this.numericUpDownrazao.Name = "numericUpDownrazao";
            this.numericUpDownrazao.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownrazao.TabIndex = 6;
            // 
            // buttonrazao
            // 
            this.buttonrazao.Location = new System.Drawing.Point(627, 69);
            this.buttonrazao.Name = "buttonrazao";
            this.buttonrazao.Size = new System.Drawing.Size(75, 23);
            this.buttonrazao.TabIndex = 7;
            this.buttonrazao.Text = "clique";
            this.buttonrazao.UseVisualStyleBackColor = true;
            this.buttonrazao.Click += new System.EventHandler(this.buttonrazao_Click);
            // 
            // lista31bimexer1a3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonrazao);
            this.Controls.Add(this.numericUpDownrazao);
            this.Controls.Add(this.numericUpDownultimotermo);
            this.Controls.Add(this.numericUpDownprimeirotermo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "lista31bimexer1a3";
            this.Text = "lista31bimexer1a3";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownprimeirotermo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownultimotermo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownrazao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDownprimeirotermo;
        private System.Windows.Forms.NumericUpDown numericUpDownultimotermo;
        private System.Windows.Forms.NumericUpDown numericUpDownrazao;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button buttonrazao;
    }
}