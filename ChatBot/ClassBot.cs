/// @author Саранчин К.А.
/// Класс бота
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ChatBot
{
    public class Bot
    {
       
        public string BotSay(string bot)
        {
            return "[" + DateTime.Now.ToString("HH:mm") + "] " + "Бот" + ": " + bot + "\r" + "\n";
        }

        public string UserQuest(string quest)
        {
            return "[" + DateTime.Now.ToString("HH:mm") + "] " + FormLogin.userName + ": " + quest /*textBox_Question.Text*/ + "\r" + "\n";
        }

        public string BotSum(string quest)
        {
            /// сложи 5 и 5
            quest = quest.Replace(" ", "");
            quest = quest.Substring(quest.LastIndexOf('ж') + 2); /// Как тут можно сделать по другому что бы не отслеживать ласт символ
            string[] words = quest.Split(new char[] { 'и'}, StringSplitOptions.RemoveEmptyEntries);
            int a = Convert.ToInt32(words[0]);
            int b = Convert.ToInt32(words[1]);
            return (a + b).ToString();

        }

        public string BotSub(string quest)
        {
            quest = quest.Replace(" ", "");
            quest = quest.Substring(quest.LastIndexOf('т') + 2); /// Как тут можно сделать по другому что бы не отслеживать ласт символ
            string[] words = quest.Split(new char[] { 'и', 'з' }, StringSplitOptions.RemoveEmptyEntries);
            int a = Convert.ToInt32(words[0]);
            int b = Convert.ToInt32(words[1]);
            return (b - a).ToString();

        }

       

        //string botName = "Bot";
        string userName = FormLogin.userName;
        //string question;

        //public Bot()
        //{
        //   question = "";
        //}


        //public string Question(string quest)
        //{
        //    return question;
        //}

        public string SetHelloBot()
        {
            Random rand = new Random();
            string[] mas = { "Привет", "Дароу" };
            int mas1 = rand.Next(mas.Length);

            return mas[mas1] + " " + userName;
        }

        public string TimeBot()
        {
            return DateTime.Now.ToString("T");
        }

        public string DateBot()
        {
            return DateTime.Now.ToString("D");
        }


        public string BotInstruction(string bot)
        {
            return "В данный момент я умею: " + "\r" + "\n"
                + "Отвечать на приветствие разными варинтами " + "\r" + "\n"
                + "Показывать дату и время " + "\r" + "\n"
                + "Складывать числа 'a и b' = c" + "\r" + "\n"
                + "Вычитать числа 'a из b' = c" + "\r" + "\n";
        }

        //public string GetHelloBot ()
        //{
        //    return question;
        //}









        //List<Regex> reg = new List<Regex>
        //{
        /// Добавить регистр?
        //public static Regex regexHello = new Regex(@"привет",RegexOptions.IgnoreCase);
        //public static Regex regexTime = new Regex(@"(?:который час\??|сколько времени\??)", RegexOptions.IgnoreCase);
        //public static Regex regexDate = new Regex(@"(?:какое сегодня число\??|число\??)", RegexOptions.IgnoreCase);
        //    /// добавить еще потом.
        //};

        


       
    }
}
