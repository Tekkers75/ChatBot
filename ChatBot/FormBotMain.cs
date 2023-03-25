﻿/// @author Саранчин К.А.
/// Класс формы и обработчики событий
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ChatBot
{
    public partial class FormBot : Form
    {
        public Bot bot = new Bot();
        
        public FormBot()
        {
            InitializeComponent();
            KeyPreview = true;
            this.KeyDown += new KeyEventHandler(FormBot_KeyEnter);
        }

        private void FormBot_KeyEnter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button_Send.PerformClick();
            }
        }

        private void button_Send_Click(object sender, EventArgs e)
        {
            bot.BotCheckReg(textBox_Question.Text);
            textBox_Result.Text += bot.Answer(textBox_Question.Text, bot);
            textBox_Question.Clear();
        }

        private void button_instruction_Click(object sender, EventArgs e)
        {
            textBox_Result.Text += bot.BotSay(bot.BotInstruction());
        }











        ///// Добавить еще регулярок
        //public static Regex regexHello = new Regex(@"(^(пр(и|e)в)е*т|х(а|e)*й|hi|hello*|ghbd)", RegexOptions.IgnoreCase);
        ////public static Regex regexHello = new Regex(@"привет", RegexOptions.IgnoreCase);
        //public static Regex regexTime = new Regex(@"время$|час$|time|dhtvz", RegexOptions.IgnoreCase);
        ////public static Regex regexTime = new Regex(@"(?:который час\??|сколько времени\??)", RegexOptions.IgnoreCase);
        //public static Regex regexDate = new Regex(@"(число$|lfnf$|дата|xbckj)", RegexOptions.IgnoreCase);
        ////public static Regex regexDate = new Regex(@"(?:какое сегодня число\??|число\??)", RegexOptions.IgnoreCase);
        //public static Regex regexSum = new Regex(@"Сложи", RegexOptions.IgnoreCase);
        //public static Regex regexSub = new Regex(@"Вычти", RegexOptions.IgnoreCase);

        ///// Как работать с URL ссылками?


        //private void ProverkaRegex()
        //{

        //    // todo: to bot
        //    /// Можно вывести в класс void Name (string n)??
        //    /// Как добавить условие на общий if (условие)
        //    ///                     else { "не понимаю что вы хотите" }
        //    ///         
        //    if (regexHello.IsMatch(textBox_Question.Text))
        //    {
        //        //Result();
        //        textBox_Result.Text += bot.UserQuest(textBox_Question.Text);
        //        textBox_Result.Text += bot.BotSay(bot.SetHelloBot());

        //        textBox_Result.SelectionStart = textBox_Result.Text.Length;
        //        textBox_Result.ScrollToCaret();


        //        //textBox_Result.Text += "[" + DateTime.Now.ToString("HH:mm") + "] " + FormLogin.userName + ": " + textBox_Question.Text + "\r" + "\n";
        //        // textBox_Result.Text += "[" + DateTime.Now.ToString("HH:mm") + "] " + "Бот" + ": " + bot.SetHelloBot() +  "\r" + "\n";
        //        //textBox_Question.Clear();
        //    } else
        //    if (regexTime.IsMatch(textBox_Question.Text))
        //    {
        //        //Result();
        //        textBox_Result.Text += bot.UserQuest(textBox_Question.Text);
        //        //textBox_Result.Text += "[" + DateTime.Now.ToString("HH:mm") + "] " + FormLogin.userName + ": " + textBox_Question.Text + "\r" + "\n";
        //        textBox_Result.Text += bot.BotSay(bot.TimeBot());
        //        //textBox_Result.Text += "[" + DateTime.Now.ToString("HH:mm") + "] " + "Бот" + ": " + bot.TimeBot() + "\r" + "\n";
        //    } // todo: else
        //    if (regexDate.IsMatch(textBox_Question.Text))
        //    {
        //        //Result();
        //        textBox_Result.Text += bot.UserQuest(textBox_Question.Text);
        //        //textBox_Result.Text += "[" + DateTime.Now.ToString("HH:mm") + "] " + FormLogin.userName + ": " + textBox_Question.Text + "\r" + "\n";
        //        textBox_Result.Text += bot.BotSay(bot.DateBot());
        //        //textBox_Result.Text += "[" + DateTime.Now.ToString("HH:mm") + "] " + "Бот" + ": " + bot.DateBot() + "\r" + "\n";
        //    }
        //    if (regexSum.IsMatch(textBox_Question.Text))
        //    {
        //        //Result();
        //        textBox_Result.Text += bot.UserQuest(textBox_Question.Text);
        //        textBox_Result.Text += bot.BotSay(bot.BotSum(textBox_Question.Text));
        //    }
        //    if (regexSub.IsMatch(textBox_Question.Text))
        //    {
        //        //Result();
        //        textBox_Result.Text += bot.UserQuest(textBox_Question.Text);
        //        textBox_Result.Text += bot.BotSay(bot.BotSub(textBox_Question.Text));
        //    }
        //   // textBox_Result.Text += "[" + DateTime.Now.ToString("HH:mm") + "] " + "Я не понял, что вы хотите" + "\r" + "\n"; // Можно добавить рандом
        //    }

        /// Не работает
        //private void Result()
        //{
        //    textBox_Result.Text += bot.UserQuest(textBox_Question.Text);
        //    textBox_Result.Text += bot.BotSay(bot.BotSum(textBox_Question.Text));
        //}


        //private void button_Send_Click(object sender, EventArgs e)
        //{
        //    //bot.Question(Convert.ToString(textBox_Question.Text));
        //    //if (regexHello.IsMatch(textBox_Question.Text))
        //    //{
        //    //    textBox_Result.Text += bot.UserQuest(textBox_Question.Text);
        //    //    //textBox_Result.Text += "[" + DateTime.Now.ToString("HH:mm") + "] " + FormLogin.userName + ": " + textBox_Question.Text + "\r" + "\n";
        //    //    textBox_Result.Text += bot.BotSay(bot.SetHelloBot());

        //    //   // textBox_Result.Text += "[" + DateTime.Now.ToString("HH:mm") + "] " + "Бот" + ": " + bot.SetHelloBot() +  "\r" + "\n";
        //    //    //textBox_Question.Clear();
        //    //}
        //    //if (regexTime.IsMatch(textBox_Question.Text))
        //    //{
        //    //    textBox_Result.Text += bot.UserQuest(textBox_Question.Text);
        //    //    //textBox_Result.Text += "[" + DateTime.Now.ToString("HH:mm") + "] " + FormLogin.userName + ": " + textBox_Question.Text + "\r" + "\n";
        //    //    textBox_Result.Text += bot.BotSay(bot.TimeBot());

        //    //    //textBox_Result.Text += "[" + DateTime.Now.ToString("HH:mm") + "] " + "Бот" + ": " + bot.TimeBot() + "\r" + "\n";
        //    //}
        //    //if (regexDate.IsMatch(textBox_Question.Text))
        //    //{
        //    //    textBox_Result.Text += bot.UserQuest(textBox_Question.Text);
        //    //    //textBox_Result.Text += "[" + DateTime.Now.ToString("HH:mm") + "] " + FormLogin.userName + ": " + textBox_Question.Text + "\r" + "\n";
        //    //    textBox_Result.Text += bot.BotSay(bot.DateBot());

        //    //    //textBox_Result.Text += "[" + DateTime.Now.ToString("HH:mm") + "] " + "Бот" + ": " + bot.DateBot() + "\r" + "\n";
        //    //}
        //    //if (regexSum.IsMatch(textBox_Question.Text))
        //    //{
        //    //    textBox_Result.Text += bot.UserQuest(textBox_Question.Text);
        //    //    textBox_Result.Text += bot.BotSay(bot.BotSum(textBox_Question.Text));
        //    //}
        //    //if (regexSub.IsMatch(textBox_Question.Text))
        //    //{
        //    //    textBox_Result.Text += bot.UserQuest(textBox_Question.Text);
        //    //    textBox_Result.Text += bot.BotSay(bot.BotSub(textBox_Question.Text));
        //    //}

        //    bot.BotCheckReg(textBox_Question.Text);
        //    textBox_Result.Text += bot.Answer(textBox_Question.Text, bot);
        //    //ProverkaRegex();
        //    textBox_Question.Clear();
        //    //backgroundWorkerSite.RunWorkerAsync();

        //}

    }

}
