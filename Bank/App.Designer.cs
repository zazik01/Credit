namespace Bank
{
    partial class App
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(App));
            this.button_tableShow = new System.Windows.Forms.Button();
            this.label_date = new System.Windows.Forms.Label();
            this.label_percent = new System.Windows.Forms.Label();
            this.label_term = new System.Windows.Forms.Label();
            this.label_sum = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.textBox_sum = new System.Windows.Forms.TextBox();
            this.textBox_term = new System.Windows.Forms.TextBox();
            this.label_minsum = new System.Windows.Forms.Label();
            this.label_minterm = new System.Windows.Forms.Label();
            this.textBox_percent = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_tableShow
            // 
            this.button_tableShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_tableShow.Location = new System.Drawing.Point(330, 330);
            this.button_tableShow.Name = "button_tableShow";
            this.button_tableShow.Size = new System.Drawing.Size(125, 57);
            this.button_tableShow.TabIndex = 4;
            this.button_tableShow.Text = "Показать таблицу";
            this.button_tableShow.UseVisualStyleBackColor = true;
            this.button_tableShow.Click += new System.EventHandler(this.button_tableShow_Click);
            // 
            // label_date
            // 
            this.label_date.AutoSize = true;
            this.label_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_date.Location = new System.Drawing.Point(170, 117);
            this.label_date.Name = "label_date";
            this.label_date.Size = new System.Drawing.Size(271, 22);
            this.label_date.TabIndex = 25;
            this.label_date.Text = "Выберите дату взятия кредита";
            // 
            // label_percent
            // 
            this.label_percent.AutoSize = true;
            this.label_percent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_percent.Location = new System.Drawing.Point(261, 275);
            this.label_percent.Name = "label_percent";
            this.label_percent.Size = new System.Drawing.Size(188, 22);
            this.label_percent.TabIndex = 23;
            this.label_percent.Text = "Годовой процент (%)";
            // 
            // label_term
            // 
            this.label_term.AutoSize = true;
            this.label_term.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_term.Location = new System.Drawing.Point(219, 221);
            this.label_term.Name = "label_term";
            this.label_term.Size = new System.Drawing.Size(204, 22);
            this.label_term.TabIndex = 22;
            this.label_term.Text = "Срок кредита (в годах)";
            // 
            // label_sum
            // 
            this.label_sum.AutoSize = true;
            this.label_sum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_sum.Location = new System.Drawing.Point(219, 169);
            this.label_sum.Name = "label_sum";
            this.label_sum.Size = new System.Drawing.Size(168, 22);
            this.label_sum.TabIndex = 21;
            this.label_sum.Text = "Сумма кредита (₽)";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker.Location = new System.Drawing.Point(451, 117);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(163, 24);
            this.dateTimePicker.TabIndex = 0;
            this.dateTimePicker.Value = new System.DateTime(2025, 3, 29, 0, 26, 42, 0);
            // 
            // textBox_sum
            // 
            this.textBox_sum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_sum.Location = new System.Drawing.Point(451, 171);
            this.textBox_sum.Multiline = true;
            this.textBox_sum.Name = "textBox_sum";
            this.textBox_sum.Size = new System.Drawing.Size(163, 22);
            this.textBox_sum.TabIndex = 1;
            this.textBox_sum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_sum_KeyPress);
            // 
            // textBox_term
            // 
            this.textBox_term.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_term.Location = new System.Drawing.Point(451, 223);
            this.textBox_term.Multiline = true;
            this.textBox_term.Name = "textBox_term";
            this.textBox_term.Size = new System.Drawing.Size(163, 22);
            this.textBox_term.TabIndex = 2;
            this.textBox_term.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_term_KeyPress);
            // 
            // label_minsum
            // 
            this.label_minsum.AutoSize = true;
            this.label_minsum.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_minsum.Location = new System.Drawing.Point(220, 191);
            this.label_minsum.Name = "label_minsum";
            this.label_minsum.Size = new System.Drawing.Size(221, 15);
            this.label_minsum.TabIndex = 29;
            this.label_minsum.Text = "Минимальная сумма кредита: 10000";
            // 
            // label_minterm
            // 
            this.label_minterm.AutoSize = true;
            this.label_minterm.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_minterm.Location = new System.Drawing.Point(220, 243);
            this.label_minterm.Name = "label_minterm";
            this.label_minterm.Size = new System.Drawing.Size(225, 15);
            this.label_minterm.TabIndex = 30;
            this.label_minterm.Text = "Минимальный срок кредита: полгода";
            // 
            // textBox_percent
            // 
            this.textBox_percent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_percent.Location = new System.Drawing.Point(451, 275);
            this.textBox_percent.Multiline = true;
            this.textBox_percent.Name = "textBox_percent";
            this.textBox_percent.Size = new System.Drawing.Size(163, 22);
            this.textBox_percent.TabIndex = 3;
            this.textBox_percent.WordWrap = false;
            this.textBox_percent.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_percent_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(157, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(471, 29);
            this.label1.TabIndex = 32;
            this.label1.Text = "Расчёт дифференцированного кредита";
            // 
            // App
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(784, 484);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_percent);
            this.Controls.Add(this.label_minterm);
            this.Controls.Add(this.label_minsum);
            this.Controls.Add(this.textBox_term);
            this.Controls.Add(this.textBox_sum);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.button_tableShow);
            this.Controls.Add(this.label_date);
            this.Controls.Add(this.label_percent);
            this.Controls.Add(this.label_term);
            this.Controls.Add(this.label_sum);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "App";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BankZ";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.App_FormClosed);
            this.Load += new System.EventHandler(this.App_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_tableShow;
        private System.Windows.Forms.Label label_date;
        private System.Windows.Forms.Label label_percent;
        private System.Windows.Forms.Label label_term;
        private System.Windows.Forms.Label label_sum;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.TextBox textBox_sum;
        private System.Windows.Forms.TextBox textBox_term;
        private System.Windows.Forms.Label label_minsum;
        private System.Windows.Forms.Label label_minterm;
        private System.Windows.Forms.TextBox textBox_percent;
        private System.Windows.Forms.Label label1;
    }
}

