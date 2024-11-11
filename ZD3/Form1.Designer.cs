
namespace ZD3
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.num1 = new System.Windows.Forms.NumericUpDown();
            this.num2 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.num3 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.num4 = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.num1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num4)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(8, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ширина дороги";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 326);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 52);
            this.button1.TabIndex = 1;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // num1
            // 
            this.num1.Location = new System.Drawing.Point(12, 57);
            this.num1.Maximum = new decimal(new int[] {
            1661992959,
            1808227885,
            5,
            0});
            this.num1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(120, 20);
            this.num1.TabIndex = 2;
            this.num1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // num2
            // 
            this.num2.Location = new System.Drawing.Point(16, 131);
            this.num2.Maximum = new decimal(new int[] {
            1661992959,
            1808227885,
            5,
            0});
            this.num2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(120, 20);
            this.num2.TabIndex = 4;
            this.num2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Длинна дороги";
            // 
            // num3
            // 
            this.num3.Location = new System.Drawing.Point(16, 202);
            this.num3.Maximum = new decimal(new int[] {
            1661992959,
            1808227885,
            5,
            0});
            this.num3.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num3.Name = "num3";
            this.num3.Size = new System.Drawing.Size(120, 20);
            this.num3.TabIndex = 6;
            this.num3.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(287, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Масса дорожного покрытия";
            // 
            // num4
            // 
            this.num4.Location = new System.Drawing.Point(12, 281);
            this.num4.Maximum = new decimal(new int[] {
            1661992959,
            1808227885,
            5,
            0});
            this.num4.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num4.Name = "num4";
            this.num4.Size = new System.Drawing.Size(120, 20);
            this.num4.TabIndex = 8;
            this.num4.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(8, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(258, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "Коэффициент прочности";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(297, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(491, 368);
            this.listBox1.TabIndex = 9;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(411, 386);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 52);
            this.button2.TabIndex = 10;
            this.button2.Text = "Удалить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.num4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.num3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.num2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.num1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.num1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown num1;
        private System.Windows.Forms.NumericUpDown num2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown num3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown num4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button2;
    }
}

