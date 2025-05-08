
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
            button4 = new Button();
            comboBox1 = new ComboBox();
            button5 = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
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
            // BtnEstoque
            // 
            BtnEstoque.Location = new Point(212, 320);
            BtnEstoque.Name = "BtnEstoque";
            BtnEstoque.Size = new Size(96, 33);
            BtnEstoque.TabIndex = 6;
            BtnEstoque.Text = "Estoque";
            BtnEstoque.UseVisualStyleBackColor = true;
            BtnEstoque.Click += BtnEstoque_Click;
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
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(63, 12);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(495, 23);
            comboBox1.TabIndex = 10;
            // 
            // button5
            // 
            button5.Location = new Point(590, 12);
            button5.Name = "button5";
            button5.Size = new Size(91, 23);
            button5.TabIndex = 11;
            button5.Text = "+ Adicionar";
            button5.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 10;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 41.3223152F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 58.6776848F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 96F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 66F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 57F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 47F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 51F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 58F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 296F));
            tableLayoutPanel1.Location = new Point(12, 78);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 49.0196075F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50.9803925F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 185F));
            tableLayoutPanel1.Size = new Size(753, 236);
            tableLayoutPanel1.TabIndex = 12;
            // 
            // TelaInicial
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(777, 364);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(button5);
            Controls.Add(comboBox1);
            Controls.Add(button4);
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
        private Button button4;
        private ComboBox comboBox1;
        private Button button5;
        private TableLayoutPanel tableLayoutPanel1;
    }
}
