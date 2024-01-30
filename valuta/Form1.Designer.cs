namespace valuta
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
            this.comBox_startValuta = new System.Windows.Forms.ComboBox();
            this.lbl_inputSumma = new System.Windows.Forms.Label();
            this.txtBox_summa = new System.Windows.Forms.TextBox();
            this.comBox_endValuta = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lbl_mainTitle = new System.Windows.Forms.Label();
            this.lbl_inputValuta = new System.Windows.Forms.Label();
            this.lbl_imgPerevod = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comBox_startValuta
            // 
            this.comBox_startValuta.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comBox_startValuta.FormattingEnabled = true;
            this.comBox_startValuta.Items.AddRange(new object[] {
            "USD (Доллар США)",
            "EUR (Евро)",
            "RUB (Российский рубль)"});
            this.comBox_startValuta.Location = new System.Drawing.Point(108, 323);
            this.comBox_startValuta.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.comBox_startValuta.Name = "comBox_startValuta";
            this.comBox_startValuta.Size = new System.Drawing.Size(196, 26);
            this.comBox_startValuta.TabIndex = 0;
            // 
            // lbl_inputSumma
            // 
            this.lbl_inputSumma.AutoSize = true;
            this.lbl_inputSumma.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_inputSumma.Location = new System.Drawing.Point(105, 151);
            this.lbl_inputSumma.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lbl_inputSumma.Name = "lbl_inputSumma";
            this.lbl_inputSumma.Size = new System.Drawing.Size(132, 18);
            this.lbl_inputSumma.TabIndex = 1;
            this.lbl_inputSumma.Text = "Введите сумму";
            // 
            // txtBox_summa
            // 
            this.txtBox_summa.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBox_summa.Location = new System.Drawing.Point(108, 195);
            this.txtBox_summa.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.txtBox_summa.Name = "txtBox_summa";
            this.txtBox_summa.Size = new System.Drawing.Size(196, 26);
            this.txtBox_summa.TabIndex = 2;
            // 
            // comBox_endValuta
            // 
            this.comBox_endValuta.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comBox_endValuta.FormattingEnabled = true;
            this.comBox_endValuta.Items.AddRange(new object[] {
            "USD (Доллар США)",
            "EUR (Евро)",
            "RUB (Российский рубль)"});
            this.comBox_endValuta.Location = new System.Drawing.Point(361, 323);
            this.comBox_endValuta.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.comBox_endValuta.Name = "comBox_endValuta";
            this.comBox_endValuta.Size = new System.Drawing.Size(196, 26);
            this.comBox_endValuta.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(106, 417);
            this.button1.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(217, 41);
            this.button1.TabIndex = 6;
            this.button1.Text = "Конвертировать";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lbl_mainTitle
            // 
            this.lbl_mainTitle.AutoSize = true;
            this.lbl_mainTitle.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_mainTitle.Location = new System.Drawing.Point(102, 68);
            this.lbl_mainTitle.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lbl_mainTitle.Name = "lbl_mainTitle";
            this.lbl_mainTitle.Size = new System.Drawing.Size(202, 23);
            this.lbl_mainTitle.TabIndex = 7;
            this.lbl_mainTitle.Text = "Конвертер валют";
            // 
            // lbl_inputValuta
            // 
            this.lbl_inputValuta.AutoSize = true;
            this.lbl_inputValuta.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_inputValuta.Location = new System.Drawing.Point(105, 280);
            this.lbl_inputValuta.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lbl_inputValuta.Name = "lbl_inputValuta";
            this.lbl_inputValuta.Size = new System.Drawing.Size(162, 18);
            this.lbl_inputValuta.TabIndex = 8;
            this.lbl_inputValuta.Text = "Выберите валюты";
            // 
            // lbl_imgPerevod
            // 
            this.lbl_imgPerevod.AutoSize = true;
            this.lbl_imgPerevod.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_imgPerevod.Location = new System.Drawing.Point(314, 326);
            this.lbl_imgPerevod.Name = "lbl_imgPerevod";
            this.lbl_imgPerevod.Size = new System.Drawing.Size(37, 18);
            this.lbl_imgPerevod.TabIndex = 10;
            this.lbl_imgPerevod.Text = "-->";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 535);
            this.Controls.Add(this.lbl_imgPerevod);
            this.Controls.Add(this.lbl_inputValuta);
            this.Controls.Add(this.lbl_mainTitle);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comBox_endValuta);
            this.Controls.Add(this.txtBox_summa);
            this.Controls.Add(this.lbl_inputSumma);
            this.Controls.Add(this.comBox_startValuta);
            this.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.Name = "Form1";
            this.Text = "Конвертер валют";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comBox_startValuta;
        private System.Windows.Forms.Label lbl_inputSumma;
        private System.Windows.Forms.TextBox txtBox_summa;
        private System.Windows.Forms.ComboBox comBox_endValuta;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbl_mainTitle;
        private System.Windows.Forms.Label lbl_inputValuta;
        private System.Windows.Forms.Label lbl_imgPerevod;
    }
}

