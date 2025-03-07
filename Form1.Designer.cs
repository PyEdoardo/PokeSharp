﻿namespace PokeSharp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            materialButton1 = new MaterialSkin.Controls.MaterialButton();
            materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            labelNome = new MaterialSkin.Controls.MaterialLabel();
            pictureBox1 = new PictureBox();
            labelTipos = new MaterialSkin.Controls.MaterialLabel();
            labelAltura = new MaterialSkin.Controls.MaterialLabel();
            labelPeso = new MaterialSkin.Controls.MaterialLabel();
            materialCard1 = new MaterialSkin.Controls.MaterialCard();
            pictureBox2 = new PictureBox();
            statusStrip1 = new StatusStrip();
            toolStripDropDownButton1 = new ToolStripDropDownButton();
            temasToolStripMenuItem = new ToolStripMenuItem();
            temaBrancoToolStripMenuItem = new ToolStripMenuItem();
            temaEscuroToolStripMenuItem = new ToolStripMenuItem();
            resetarCacheToolStripMenuItem = new ToolStripMenuItem();
            githubDoDesenvolvedorToolStripMenuItem = new ToolStripMenuItem();
            textBoxNome3 = new TextBox();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            materialCard1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // materialButton1
            // 
            materialButton1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton1.Depth = 0;
            materialButton1.HighEmphasis = true;
            materialButton1.Icon = null;
            materialButton1.Location = new Point(19, 273);
            materialButton1.Margin = new Padding(4, 6, 4, 6);
            materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton1.Name = "materialButton1";
            materialButton1.NoAccentTextColor = Color.Empty;
            materialButton1.Size = new Size(97, 36);
            materialButton1.TabIndex = 9;
            materialButton1.Text = "Procurar";
            materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton1.UseAccentColor = false;
            materialButton1.UseVisualStyleBackColor = true;
            materialButton1.Click += materialButton1_Click;
            // 
            // materialLabel2
            // 
            materialLabel2.AutoSize = true;
            materialLabel2.Depth = 0;
            materialLabel2.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel2.Location = new Point(19, 159);
            materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(246, 19);
            materialLabel2.TabIndex = 8;
            materialLabel2.Text = "Digite o Nome do Pokemon abaixo";
            materialLabel2.Click += materialLabel1_Click;
            // 
            // labelNome
            // 
            labelNome.AutoSize = true;
            labelNome.Depth = 0;
            labelNome.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            labelNome.Location = new Point(17, 14);
            labelNome.MouseState = MaterialSkin.MouseState.HOVER;
            labelNome.Name = "labelNome";
            labelNome.Size = new Size(47, 19);
            labelNome.TabIndex = 11;
            labelNome.Text = "Nome:";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(265, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(223, 149);
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // labelTipos
            // 
            labelTipos.AutoSize = true;
            labelTipos.Depth = 0;
            labelTipos.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            labelTipos.Location = new Point(17, 166);
            labelTipos.MouseState = MaterialSkin.MouseState.HOVER;
            labelTipos.Name = "labelTipos";
            labelTipos.Size = new Size(45, 19);
            labelTipos.TabIndex = 13;
            labelTipos.Text = "Tipos:";
            // 
            // labelAltura
            // 
            labelAltura.AutoSize = true;
            labelAltura.Depth = 0;
            labelAltura.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            labelAltura.Location = new Point(17, 63);
            labelAltura.MouseState = MaterialSkin.MouseState.HOVER;
            labelAltura.Name = "labelAltura";
            labelAltura.Size = new Size(51, 19);
            labelAltura.TabIndex = 14;
            labelAltura.Text = "Altura: ";
            // 
            // labelPeso
            // 
            labelPeso.AutoSize = true;
            labelPeso.Depth = 0;
            labelPeso.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            labelPeso.Location = new Point(17, 114);
            labelPeso.MouseState = MaterialSkin.MouseState.HOVER;
            labelPeso.Name = "labelPeso";
            labelPeso.Size = new Size(44, 19);
            labelPeso.TabIndex = 15;
            labelPeso.Text = "Peso: ";
            // 
            // materialCard1
            // 
            materialCard1.BackColor = Color.FromArgb(255, 255, 255);
            materialCard1.Controls.Add(pictureBox2);
            materialCard1.Controls.Add(labelNome);
            materialCard1.Controls.Add(pictureBox1);
            materialCard1.Controls.Add(labelPeso);
            materialCard1.Controls.Add(labelTipos);
            materialCard1.Controls.Add(labelAltura);
            materialCard1.Depth = 0;
            materialCard1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard1.Location = new Point(282, 87);
            materialCard1.Margin = new Padding(14);
            materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard1.Name = "materialCard1";
            materialCard1.Padding = new Padding(14);
            materialCard1.Size = new Size(489, 309);
            materialCard1.TabIndex = 16;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(266, 149);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(222, 160);
            pictureBox2.TabIndex = 16;
            pictureBox2.TabStop = false;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripDropDownButton1 });
            statusStrip1.Location = new Point(3, 425);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(794, 22);
            statusStrip1.TabIndex = 17;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripDropDownButton1
            // 
            toolStripDropDownButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripDropDownButton1.DropDownItems.AddRange(new ToolStripItem[] { temasToolStripMenuItem, resetarCacheToolStripMenuItem, githubDoDesenvolvedorToolStripMenuItem });
            toolStripDropDownButton1.Image = (Image)resources.GetObject("toolStripDropDownButton1.Image");
            toolStripDropDownButton1.ImageTransparentColor = Color.Magenta;
            toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            toolStripDropDownButton1.Size = new Size(29, 20);
            toolStripDropDownButton1.Text = "toolStripDropDownButton1";
            // 
            // temasToolStripMenuItem
            // 
            temasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { temaBrancoToolStripMenuItem, temaEscuroToolStripMenuItem });
            temasToolStripMenuItem.Name = "temasToolStripMenuItem";
            temasToolStripMenuItem.Size = new Size(223, 22);
            temasToolStripMenuItem.Text = "Temas";
            // 
            // temaBrancoToolStripMenuItem
            // 
            temaBrancoToolStripMenuItem.Name = "temaBrancoToolStripMenuItem";
            temaBrancoToolStripMenuItem.Size = new Size(143, 22);
            temaBrancoToolStripMenuItem.Text = "Tema Branco";
            temaBrancoToolStripMenuItem.Click += temaBrancoToolStripMenuItem_Click;
            // 
            // temaEscuroToolStripMenuItem
            // 
            temaEscuroToolStripMenuItem.Name = "temaEscuroToolStripMenuItem";
            temaEscuroToolStripMenuItem.Size = new Size(143, 22);
            temaEscuroToolStripMenuItem.Text = "Tema Escuro";
            temaEscuroToolStripMenuItem.Click += temaEscuroToolStripMenuItem_Click;
            // 
            // resetarCacheToolStripMenuItem
            // 
            resetarCacheToolStripMenuItem.Name = "resetarCacheToolStripMenuItem";
            resetarCacheToolStripMenuItem.Size = new Size(223, 22);
            resetarCacheToolStripMenuItem.Text = "Resetar Cache";
            resetarCacheToolStripMenuItem.Click += resetarCacheToolStripMenuItem_Click;
            // 
            // githubDoDesenvolvedorToolStripMenuItem
            // 
            githubDoDesenvolvedorToolStripMenuItem.Name = "githubDoDesenvolvedorToolStripMenuItem";
            githubDoDesenvolvedorToolStripMenuItem.Size = new Size(223, 22);
            githubDoDesenvolvedorToolStripMenuItem.Text = "Github do Desenvolvedor ❤️";
            githubDoDesenvolvedorToolStripMenuItem.Click += githubDoDesenvolvedorToolStripMenuItem_Click_1;
            // 
            // textBoxNome3
            // 
            textBoxNome3.Location = new Point(0, 0);
            textBoxNome3.Name = "textBoxNome3";
            textBoxNome3.Size = new Size(100, 23);
            textBoxNome3.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textBox1.AutoCompleteSource = AutoCompleteSource.CustomSource;
            textBox1.Location = new Point(19, 197);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 18;
            textBox1.KeyDown += textBox1_KeyDown;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox1);
            Controls.Add(statusStrip1);
            Controls.Add(materialCard1);
            Controls.Add(materialButton1);
            Controls.Add(materialLabel2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            materialCard1.ResumeLayout(false);
            materialCard1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MaterialSkin.Controls.MaterialTextBox textBoxNome2;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel labelNome;
        private PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialLabel labelTipos;
        private MaterialSkin.Controls.MaterialLabel labelAltura;
        private MaterialSkin.Controls.MaterialLabel labelPeso;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private StatusStrip statusStrip1;
        private ToolStripDropDownButton toolStripDropDownButton1;
        private ToolStripMenuItem temasToolStripMenuItem;
        private ToolStripMenuItem resetarCacheToolStripMenuItem;
        private ToolStripMenuItem githubDoDesenvolvedorToolStripMenuItem;
        private TextBox textBoxNome3;
        private ToolStripMenuItem temaBrancoToolStripMenuItem;
        private ToolStripMenuItem temaEscuroToolStripMenuItem;
        private PictureBox pictureBox2;
        private MaterialSkin.Controls.MaterialTextBox2 materialTextBox21;
        private TextBox textBox1;
    }
}
