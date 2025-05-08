namespace CukiApp.View
{
    partial class Estoque
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
            entMerc = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            entMerc.Location = new Point(12, 246);
            entMerc.Name = "button1";
            entMerc.Size = new Size(122, 30);
            entMerc.TabIndex = 0;
            entMerc.Text = "Entrada Mercadoria";
            entMerc.UseVisualStyleBackColor = true;
            entMerc.Click += entMerc_Click;
            // 
            // Estoque
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(689, 288);
            Controls.Add(entMerc);
            Name = "Estoque";
            Text = "Estoque";
            ResumeLayout(false);
        }

        #endregion

        private Button entMerc;
    }
}