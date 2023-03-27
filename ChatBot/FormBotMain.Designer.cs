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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBot));
            this.textBox_Result = new System.Windows.Forms.TextBox();
            this.textBox_Question = new System.Windows.Forms.TextBox();
            this.button_Send = new System.Windows.Forms.Button();
            this.button_instruction = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.загрузитьИсториюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.правкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.очиститьЧатToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_Result
            // 
            this.textBox_Result.Location = new System.Drawing.Point(12, 36);
            this.textBox_Result.Multiline = true;
            this.textBox_Result.Name = "textBox_Result";
            this.textBox_Result.ReadOnly = true;
            this.textBox_Result.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_Result.Size = new System.Drawing.Size(364, 190);
            this.textBox_Result.TabIndex = 0;
            this.textBox_Result.TabStop = false;
            // 
            // textBox_Question
            // 
            this.textBox_Question.Location = new System.Drawing.Point(12, 245);
            this.textBox_Question.Name = "textBox_Question";
            this.textBox_Question.Size = new System.Drawing.Size(249, 20);
            this.textBox_Question.TabIndex = 1;
            // 
            // button_Send
            // 
            this.button_Send.Location = new System.Drawing.Point(267, 232);
            this.button_Send.Name = "button_Send";
            this.button_Send.Size = new System.Drawing.Size(109, 45);
            this.button_Send.TabIndex = 2;
            this.button_Send.Text = "Отправить";
            this.button_Send.UseVisualStyleBackColor = true;
            this.button_Send.Click += new System.EventHandler(this.button_Send_Click);
            // 
            // button_instruction
            // 
            this.button_instruction.Location = new System.Drawing.Point(12, 271);
            this.button_instruction.Name = "button_instruction";
            this.button_instruction.Size = new System.Drawing.Size(75, 23);
            this.button_instruction.TabIndex = 3;
            this.button_instruction.Text = "Инструкция";
            this.button_instruction.UseVisualStyleBackColor = true;
            this.button_instruction.Click += new System.EventHandler(this.button_instruction_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.правкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(400, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сохранитьToolStripMenuItem,
            this.загрузитьИсториюToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить историю";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // загрузитьИсториюToolStripMenuItem
            // 
            this.загрузитьИсториюToolStripMenuItem.Name = "загрузитьИсториюToolStripMenuItem";
            this.загрузитьИсториюToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.загрузитьИсториюToolStripMenuItem.Text = "Загрузить историю";
            this.загрузитьИсториюToolStripMenuItem.Click += new System.EventHandler(this.загрузитьИсториюToolStripMenuItem_Click);
            // 
            // правкаToolStripMenuItem
            // 
            this.правкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.очиститьЧатToolStripMenuItem});
            this.правкаToolStripMenuItem.Name = "правкаToolStripMenuItem";
            this.правкаToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.правкаToolStripMenuItem.Text = "Правка";
            // 
            // очиститьЧатToolStripMenuItem
            // 
            this.очиститьЧатToolStripMenuItem.Name = "очиститьЧатToolStripMenuItem";
            this.очиститьЧатToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.очиститьЧатToolStripMenuItem.Text = "Очистить чат";
            this.очиститьЧатToolStripMenuItem.Click += new System.EventHandler(this.очиститьЧатToolStripMenuItem_Click);
            // 
            // FormBot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ChatBot.Properties.Resources.ChatBack1;
            this.ClientSize = new System.Drawing.Size(400, 307);
            this.Controls.Add(this.button_instruction);
            this.Controls.Add(this.button_Send);
            this.Controls.Add(this.textBox_Question);
            this.Controls.Add(this.textBox_Result);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormBot";
            this.Text = "Чат";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Result;
        private System.Windows.Forms.TextBox textBox_Question;
        private System.Windows.Forms.Button button_Send;
        private System.Windows.Forms.Button button_instruction;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem загрузитьИсториюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem правкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem очиститьЧатToolStripMenuItem;
    }
}

