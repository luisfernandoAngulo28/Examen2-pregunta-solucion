namespace wApp
{
    partial class FListaS
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
            this.cmdAdd = new System.Windows.Forms.Button();
            this.txtEleme = new System.Windows.Forms.TextBox();
            this.lblCola = new System.Windows.Forms.Label();
            this.cmdLlena = new System.Windows.Forms.Button();
            this.cmdDispo = new System.Windows.Forms.Button();
            this.lblRear = new System.Windows.Forms.Label();
            this.cmdLong = new System.Windows.Forms.Button();
            this.lblFront = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLista = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmdAdd
            // 
            this.cmdAdd.Location = new System.Drawing.Point(266, 88);
            this.cmdAdd.Margin = new System.Windows.Forms.Padding(4);
            this.cmdAdd.Name = "cmdAdd";
            this.cmdAdd.Size = new System.Drawing.Size(100, 28);
            this.cmdAdd.TabIndex = 1;
            this.cmdAdd.Text = "Adicionar";
            this.cmdAdd.UseVisualStyleBackColor = true;
            this.cmdAdd.Click += new System.EventHandler(this.cmdAdd_Click);
            // 
            // txtEleme
            // 
            this.txtEleme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtEleme.Location = new System.Drawing.Point(159, 91);
            this.txtEleme.Margin = new System.Windows.Forms.Padding(4);
            this.txtEleme.Name = "txtEleme";
            this.txtEleme.Size = new System.Drawing.Size(87, 22);
            this.txtEleme.TabIndex = 2;
            this.txtEleme.TextChanged += new System.EventHandler(this.txtEleme_TextChanged);
            // 
            // lblCola
            // 
            this.lblCola.AutoSize = true;
            this.lblCola.Location = new System.Drawing.Point(376, 97);
            this.lblCola.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCola.Name = "lblCola";
            this.lblCola.Size = new System.Drawing.Size(20, 17);
            this.lblCola.TabIndex = 3;
            this.lblCola.Text = "...";
            // 
            // cmdLlena
            // 
            this.cmdLlena.Location = new System.Drawing.Point(266, 123);
            this.cmdLlena.Margin = new System.Windows.Forms.Padding(4);
            this.cmdLlena.Name = "cmdLlena";
            this.cmdLlena.Size = new System.Drawing.Size(100, 28);
            this.cmdLlena.TabIndex = 4;
            this.cmdLlena.Text = "Llena";
            this.cmdLlena.UseVisualStyleBackColor = true;
            this.cmdLlena.Click += new System.EventHandler(this.cmdDelete_Click);
            // 
            // cmdDispo
            // 
            this.cmdDispo.Location = new System.Drawing.Point(266, 159);
            this.cmdDispo.Margin = new System.Windows.Forms.Padding(4);
            this.cmdDispo.Name = "cmdDispo";
            this.cmdDispo.Size = new System.Drawing.Size(100, 28);
            this.cmdDispo.TabIndex = 5;
            this.cmdDispo.Text = "Disponibles";
            this.cmdDispo.UseVisualStyleBackColor = true;
            this.cmdDispo.Click += new System.EventHandler(this.cmdFront_Click);
            // 
            // lblRear
            // 
            this.lblRear.AutoSize = true;
            this.lblRear.Location = new System.Drawing.Point(376, 201);
            this.lblRear.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRear.Name = "lblRear";
            this.lblRear.Size = new System.Drawing.Size(20, 17);
            this.lblRear.TabIndex = 6;
            this.lblRear.Text = "...";
            // 
            // cmdLong
            // 
            this.cmdLong.Location = new System.Drawing.Point(266, 201);
            this.cmdLong.Margin = new System.Windows.Forms.Padding(4);
            this.cmdLong.Name = "cmdLong";
            this.cmdLong.Size = new System.Drawing.Size(100, 28);
            this.cmdLong.TabIndex = 7;
            this.cmdLong.Text = "Longitud";
            this.cmdLong.UseVisualStyleBackColor = true;
            this.cmdLong.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblFront
            // 
            this.lblFront.AutoSize = true;
            this.lblFront.Location = new System.Drawing.Point(374, 171);
            this.lblFront.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFront.Name = "lblFront";
            this.lblFront.Size = new System.Drawing.Size(20, 17);
            this.lblFront.TabIndex = 10;
            this.lblFront.Text = "...";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 70);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "lista";
            // 
            // txtLista
            // 
            this.txtLista.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtLista.Location = new System.Drawing.Point(45, 91);
            this.txtLista.Margin = new System.Windows.Forms.Padding(4);
            this.txtLista.Name = "txtLista";
            this.txtLista.Size = new System.Drawing.Size(87, 22);
            this.txtLista.TabIndex = 12;
            this.txtLista.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(171, 70);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "elemento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(169, 18);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 29);
            this.label3.TabIndex = 14;
            this.label3.Text = "TAD Listas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(374, 134);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "...";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(266, 281);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 17);
            this.label5.TabIndex = 16;
            this.label5.Text = "label5";
            // 
            // FListaS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 505);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtLista);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblFront);
            this.Controls.Add(this.cmdLong);
            this.Controls.Add(this.lblRear);
            this.Controls.Add(this.cmdDispo);
            this.Controls.Add(this.cmdLlena);
            this.Controls.Add(this.lblCola);
            this.Controls.Add(this.txtEleme);
            this.Controls.Add(this.cmdAdd);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FListaS";
            this.Text = "FlistaS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button cmdAdd;
        private System.Windows.Forms.TextBox txtEleme;
        private System.Windows.Forms.Label lblCola;
        private System.Windows.Forms.Button cmdLlena;
        private System.Windows.Forms.Button cmdDispo;
        private System.Windows.Forms.Label lblRear;
        private System.Windows.Forms.Button cmdLong;
        private System.Windows.Forms.Label lblFront;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLista;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}