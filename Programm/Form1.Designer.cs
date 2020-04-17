namespace Programm
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxOriginal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxReplaced = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonReplace = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 187);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(426, 76);
            this.label1.TabIndex = 0;
            this.label1.Text = "Приложение заменяет все трехбуквенные слова на символ, код которого равен среднем" +
    "у арифметическому кодов букв, входящих в замененное слово.";
            // 
            // textBoxOriginal
            // 
            this.textBoxOriginal.Location = new System.Drawing.Point(15, 34);
            this.textBoxOriginal.Multiline = true;
            this.textBoxOriginal.Name = "textBoxOriginal";
            this.textBoxOriginal.Size = new System.Drawing.Size(423, 134);
            this.textBoxOriginal.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Текст для замены";
            // 
            // textBoxReplaced
            // 
            this.textBoxReplaced.Location = new System.Drawing.Point(504, 34);
            this.textBoxReplaced.Multiline = true;
            this.textBoxReplaced.Name = "textBoxReplaced";
            this.textBoxReplaced.Size = new System.Drawing.Size(423, 134);
            this.textBoxReplaced.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(501, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Заменённый текст";
            // 
            // buttonReplace
            // 
            this.buttonReplace.Location = new System.Drawing.Point(504, 187);
            this.buttonReplace.Name = "buttonReplace";
            this.buttonReplace.Size = new System.Drawing.Size(423, 40);
            this.buttonReplace.TabIndex = 3;
            this.buttonReplace.Text = "Заменить текст";
            this.buttonReplace.UseVisualStyleBackColor = true;
            this.buttonReplace.Click += new System.EventHandler(this.buttonReplace_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 246);
            this.Controls.Add(this.buttonReplace);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxReplaced);
            this.Controls.Add(this.textBoxOriginal);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxOriginal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxReplaced;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonReplace;
    }
}

