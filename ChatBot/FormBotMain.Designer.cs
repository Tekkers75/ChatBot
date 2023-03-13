namespace ChatBot
{
    partial class FormBot
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
            this.textBox_Result = new System.Windows.Forms.TextBox();
            this.textBox_Question = new System.Windows.Forms.TextBox();
            this.button_Send = new System.Windows.Forms.Button();
            this.button_instruction = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_Result
            // 
            this.textBox_Result.Location = new System.Drawing.Point(52, 28);
            this.textBox_Result.Multiline = true;
            this.textBox_Result.Name = "textBox_Result";
            this.textBox_Result.ReadOnly = true;
            this.textBox_Result.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_Result.Size = new System.Drawing.Size(463, 190);
            this.textBox_Result.TabIndex = 0;
            this.textBox_Result.TabStop = false;
            // 
            // textBox_Question
            // 
            this.textBox_Question.Location = new System.Drawing.Point(82, 264);
            this.textBox_Question.Name = "textBox_Question";
            this.textBox_Question.Size = new System.Drawing.Size(297, 20);
            this.textBox_Question.TabIndex = 1;
            // 
            // button_Send
            // 
            this.button_Send.Location = new System.Drawing.Point(406, 264);
            this.button_Send.Name = "button_Send";
            this.button_Send.Size = new System.Drawing.Size(109, 45);
            this.button_Send.TabIndex = 2;
            this.button_Send.Text = "Отправить";
            this.button_Send.UseVisualStyleBackColor = true;
            this.button_Send.Click += new System.EventHandler(this.button_Send_Click);
            // 
            // button_instruction
            // 
            this.button_instruction.Location = new System.Drawing.Point(12, 330);
            this.button_instruction.Name = "button_instruction";
            this.button_instruction.Size = new System.Drawing.Size(75, 23);
            this.button_instruction.TabIndex = 3;
            this.button_instruction.Text = "Инструкция";
            this.button_instruction.UseVisualStyleBackColor = true;
            this.button_instruction.Click += new System.EventHandler(this.button_instruction_Click);
            // 
            // FormBot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 365);
            this.Controls.Add(this.button_instruction);
            this.Controls.Add(this.button_Send);
            this.Controls.Add(this.textBox_Question);
            this.Controls.Add(this.textBox_Result);
            this.Name = "FormBot";
            this.Text = "Чат";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Result;
        private System.Windows.Forms.TextBox textBox_Question;
        private System.Windows.Forms.Button button_Send;
        private System.Windows.Forms.Button button_instruction;
    }
}

