
using CukiApp.Controller;
using CukiApp.View;

namespace CukiApp
{
    partial class TelaInicial
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
            button1 = new Button();
            button2 = new Button();
            comboBox1 = new ComboBox();
            label1 = new Label();
            button3 = new Button();
            richTextBox1 = new RichTextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 239);
            button1.Name = "button1";
            button1.Size = new Size(118, 32);
            button1.TabIndex = 0;
            button1.Text = "Adicionar Receita";
            button1.UseVisualStyleBackColor = true;
            button1.Click += buttonAddItem_Click;
            // 
            // button2
            // 
            button2.Location = new Point(136, 239);
            button2.Name = "button2";
            button2.Size = new Size(120, 32);
            button2.TabIndex = 1;
            button2.Text = "Adicionar item";
            button2.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(63, 12);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(395, 23);
            comboBox1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 15);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 3;
            label1.Text = "Receita";
            // 
            // button3
            // 
            button3.Location = new Point(420, 239);
            button3.Name = "button3";
            button3.Size = new Size(102, 32);
            button3.TabIndex = 4;
            button3.Text = "Efetivar Receita";
            button3.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(12, 55);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(159, 115);
            richTextBox1.TabIndex = 5;
            richTextBox1.Text = "";
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // TelaInicial
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(534, 283);
            Controls.Add(richTextBox1);
            Controls.Add(button3);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "TelaInicial";
            Text = "Tela Inicial";
            ResumeLayout(false);
            PerformLayout();
        }

        private void buttonAddReceita_Click(object sender, EventArgs e)
        {
            TelaAdicionarReceita novoForm = new TelaAdicionarReceita();
            novoForm.Show();
        }
        
        private void buttonAddItem_Click(object sender, EventArgs e)
        {
            TelaAdicionarItem novoForm = new TelaAdicionarItem();
            novoForm.Show();
        }



        #endregion

        private Button button1;
        private Button button2;
        private ComboBox comboBox1;
        private Label label1;
        private Button button3;
        private RichTextBox richTextBox1;
    }
}
