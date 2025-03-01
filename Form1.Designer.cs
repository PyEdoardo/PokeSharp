namespace PokeSharp
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
            textBoxNome = new TextBox();
            labelPokemon = new Label();
            labelNome = new Label();
            labelTipos = new Label();
            labelAltura = new Label();
            labelPeso = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // textBoxNome
            // 
            textBoxNome.Location = new Point(19, 120);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(138, 23);
            textBoxNome.TabIndex = 0;
            // 
            // labelPokemon
            // 
            labelPokemon.AutoSize = true;
            labelPokemon.Location = new Point(19, 92);
            labelPokemon.Name = "labelPokemon";
            labelPokemon.Size = new Size(155, 15);
            labelPokemon.TabIndex = 1;
            labelPokemon.Text = "Digite o Nome do Pokemon";
            // 
            // labelNome
            // 
            labelNome.AutoSize = true;
            labelNome.Location = new Point(319, 76);
            labelNome.Name = "labelNome";
            labelNome.Size = new Size(100, 15);
            labelNome.TabIndex = 2;
            labelNome.Text = "Nome Pokemon: ";
            // 
            // labelTipos
            // 
            labelTipos.AutoSize = true;
            labelTipos.Location = new Point(319, 128);
            labelTipos.Name = "labelTipos";
            labelTipos.Size = new Size(42, 15);
            labelTipos.TabIndex = 3;
            labelTipos.Text = "Tipos: ";
            // 
            // labelAltura
            // 
            labelAltura.AutoSize = true;
            labelAltura.Location = new Point(319, 178);
            labelAltura.Name = "labelAltura";
            labelAltura.Size = new Size(45, 15);
            labelAltura.TabIndex = 4;
            labelAltura.Text = "Altura: ";
            // 
            // labelPeso
            // 
            labelPeso.AutoSize = true;
            labelPeso.Location = new Point(319, 230);
            labelPeso.Name = "labelPeso";
            labelPeso.Size = new Size(38, 15);
            labelPeso.TabIndex = 5;
            labelPeso.Text = "Peso: ";
            // 
            // button1
            // 
            button1.Location = new Point(48, 149);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 6;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(labelPeso);
            Controls.Add(labelAltura);
            Controls.Add(labelTipos);
            Controls.Add(labelNome);
            Controls.Add(labelPokemon);
            Controls.Add(textBoxNome);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxNome;
        private Label labelPokemon;
        private Label labelNome;
        private Label labelTipos;
        private Label labelAltura;
        private Label labelPeso;
        private Button button1;
    }
}
