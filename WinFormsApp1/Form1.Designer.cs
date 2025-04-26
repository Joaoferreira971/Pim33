namespace WinFormsApp1
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
            btnCadastrar = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            Telefone_Cadastro = new Label();
            Email_Cadastro = new Label();
            Datanasc_Cadastro = new Label();
            CPF_Cadastro = new Label();
            Nome_Cadastro = new Label();
            SuspendLayout();
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(424, 478);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(163, 55);
            btnCadastrar.TabIndex = 0;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(377, 90);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(259, 23);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(377, 177);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(259, 23);
            textBox2.TabIndex = 3;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(377, 261);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(259, 23);
            textBox3.TabIndex = 4;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(377, 338);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(259, 23);
            textBox4.TabIndex = 5;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(377, 421);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(259, 23);
            textBox5.TabIndex = 6;
            // 
            // Telefone_Cadastro
            // 
            Telefone_Cadastro.AutoSize = true;
            Telefone_Cadastro.Location = new Point(378, 401);
            Telefone_Cadastro.Name = "Telefone_Cadastro";
            Telefone_Cadastro.Size = new Size(51, 15);
            Telefone_Cadastro.TabIndex = 7;
            Telefone_Cadastro.Text = "Telefone";
            Telefone_Cadastro.Click += label2_Click;
            // 
            // Email_Cadastro
            // 
            Email_Cadastro.AutoSize = true;
            Email_Cadastro.Location = new Point(378, 320);
            Email_Cadastro.Name = "Email_Cadastro";
            Email_Cadastro.Size = new Size(36, 15);
            Email_Cadastro.TabIndex = 8;
            Email_Cadastro.Text = "Email";
            Email_Cadastro.Click += label3_Click;
            // 
            // Datanasc_Cadastro
            // 
            Datanasc_Cadastro.AutoSize = true;
            Datanasc_Cadastro.Location = new Point(377, 243);
            Datanasc_Cadastro.Name = "Datanasc_Cadastro";
            Datanasc_Cadastro.Size = new Size(114, 15);
            Datanasc_Cadastro.TabIndex = 9;
            Datanasc_Cadastro.Text = "Data de Nascimento";
            // 
            // CPF_Cadastro
            // 
            CPF_Cadastro.AutoSize = true;
            CPF_Cadastro.Location = new Point(378, 159);
            CPF_Cadastro.Name = "CPF_Cadastro";
            CPF_Cadastro.Size = new Size(28, 15);
            CPF_Cadastro.TabIndex = 10;
            CPF_Cadastro.Text = "CPF";
            // 
            // Nome_Cadastro
            // 
            Nome_Cadastro.AutoSize = true;
            Nome_Cadastro.Location = new Point(377, 72);
            Nome_Cadastro.Name = "Nome_Cadastro";
            Nome_Cadastro.Size = new Size(40, 15);
            Nome_Cadastro.TabIndex = 11;
            Nome_Cadastro.Text = "Nome";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1039, 634);
            Controls.Add(Nome_Cadastro);
            Controls.Add(CPF_Cadastro);
            Controls.Add(Datanasc_Cadastro);
            Controls.Add(Email_Cadastro);
            Controls.Add(Telefone_Cadastro);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(btnCadastrar);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCadastrar;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private Label Telefone_Cadastro;
        private Label Email_Cadastro;
        private Label Datanasc_Cadastro;
        private Label CPF_Cadastro;
        private Label Nome_Cadastro;
    }
}
