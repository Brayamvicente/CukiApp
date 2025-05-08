
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
            label1 = new Label();
            button3 = new Button();
            BtnEstoque = new Button();
            textBox1 = new TextBox();
            button6 = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 321);
            button1.Name = "button1";
            button1.Size = new Size(95, 32);
            button1.TabIndex = 0;
            button1.Text = "Receita";
            button1.UseVisualStyleBackColor = true;
            button1.Click += buttonAddItem_Click;
            // 
            // button2
            // 
            button2.Location = new Point(113, 320);
            button2.Name = "button2";
            button2.Size = new Size(93, 33);
            button2.TabIndex = 1;
            button2.Text = "Item";
            button2.UseVisualStyleBackColor = true;
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
            button3.Location = new Point(663, 320);
            button3.Name = "button3";
            button3.Size = new Size(102, 32);
            button3.TabIndex = 4;
            button3.Text = "Efetivar Receita";
            button3.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            BtnEstoque.Location = new Point(212, 320);
            BtnEstoque.Name = "button5";
            BtnEstoque.Size = new Size(96, 33);
            BtnEstoque.TabIndex = 6;
            BtnEstoque.Text = "Estoque";
            BtnEstoque.UseVisualStyleBackColor = true;
            BtnEstoque.Click += button5_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(73, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(462, 23);
            textBox1.TabIndex = 7;
            // 
            // button6
            // 
            button6.Location = new Point(541, 11);
            button6.Name = "button6";
            button6.Size = new Size(75, 24);
            button6.TabIndex = 8;
            button6.Text = "Buscar";
            button6.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(314, 320);
            button4.Name = "button4";
            button4.Size = new Size(90, 33);
            button4.TabIndex = 9;
            button4.Text = "Venda";
            button4.UseVisualStyleBackColor = true;
            // 
            // TelaInicial
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(777, 364);
            Controls.Add(button4);
            Controls.Add(button6);
            Controls.Add(textBox1);
            Controls.Add(BtnEstoque);
            Controls.Add(button3);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "TelaInicial";
            Text = "Tela Inicial";
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion

        private Button button1;
        private Button button2;
        private Label label1;
        private Button button3;
        private Button BtnEstoque;
        private TextBox textBox1;
        private Button button6;
        private Button button4;
    }
}
