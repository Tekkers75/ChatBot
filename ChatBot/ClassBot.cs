/// @author Саранчин К.А.
/// Класс бота
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace ChatBot
{
     public class Bot
    {   
        string userName = FormLogin.userName;
        string url = "https://www.meteonova.ru/frc/30758.htm";
        List<string> History = new List<string>();
        List<string> Answer1 = new List<string>();


        /// Регулярные выражения
        public static Regex regexHello = new Regex(@"(^(пр(и|e)в)е*т|х(а|e)*й|hi|hello*|ghbd)", RegexOptions.IgnoreCase);
        public static Regex regexTime = new Regex(@"время$|час$|time|dhtvz", RegexOptions.IgnoreCase);
        public static Regex regexDate = new Regex(@"(число$|lfnf$|дата|xbckj)", RegexOptions.IgnoreCase);
        public static Regex regexSum = new Regex(@"Сложи", RegexOptions.IgnoreCase);
        public static Regex regexSub = new Regex(@"Вычти", RegexOptions.IgnoreCase);
        public static Regex regexWheather = new Regex(@"погод(а|у)$|weather|gjujlf$", RegexOptions.IgnoreCase);
        public static Regex regexInstr = new Regex(@"Инструкция", RegexOptions.IgnoreCase);
        public static Regex regexExit = new Regex(@"Пока|До свидания", RegexOptions.IgnoreCase);


        public string SiteWheather()
        {
            ///  создание ссылки на объект для загрузки данных с ресурсом, заданным URL.
            using (WebClient client = new WebClient())
            {
                client.Encoding = System.Text.Encoding.UTF8;
                // ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;

                /// Загрузка данных с сервера 
                var htmlData = client.DownloadData(url);
                string htmlCode = Encoding.UTF8.GetString(htmlData);

                var parts1 = Regex.Split(htmlCode, "<div id=\"frc_text_0\" class=\"nodsp\"><b>");
                var parts2 = Regex.Split(parts1[1], "   |<br></div>");
                string numberPosition = Regex.Replace(parts2[0], @"</b>|<b>", "");
                return numberPosition;
            }
        }


        public void AddList(string a)
        {
            History.Add(a);
        }

        public string Vivod(string a)
        {
            foreach(var item in History)
            {
                a = item; 
            }
            return a;
        }
        //public void BotCheckReg(string a)
        //{
        //    if (regexHello.IsMatch(a))
        //    {
        //        Answer(a,this);
        //    }
        //}


        /// Как сделать выход после определенного промежутка времени
        public void Exit()
        {
            Thread.Sleep(5000);
            Application.Exit();
        }

        public string Answer(string b, Bot bot)
        {
            if (regexHello.IsMatch(b))
            {
                return (bot.UserQuest(b) + "\r"  //"\n"
                + bot.BotSay(bot.SetHelloBot()));
            }
            if (regexDate.IsMatch(b))
            {
                return bot.UserQuest(b) + "\r"  //"\n"
                + bot.BotSay(bot.DateBot());
            }
            if (regexTime.IsMatch(b))
            {
                return bot.UserQuest(b) + "\r"  //"\n"
                + bot.BotSay(bot.TimeBot());
            }
            if (regexSum.IsMatch(b))
            {
                return bot.UserQuest(b) + "\r"  //"\n"
                + bot.BotSay(bot.BotSum(b));
            }
            if (regexSub.IsMatch(b))
            {
                return bot.UserQuest(b) + "\r"  //"\n"
                + bot.BotSay(bot.BotSub(b));
            }
            if (regexWheather.IsMatch(b))
            {
                return bot.UserQuest(b) + "\r"  //"\n"
                + bot.BotSay(bot.SiteWheather());
            }
            if (regexInstr.IsMatch(b))
            {
                return bot.UserQuest(b) + "\r"  //"\n"
                + bot.BotSay(BotInstruction());
            }
            if (regexExit.IsMatch(b))
            {
                return bot.UserQuest(b) + "\r"  //"\n"
                + bot.BotSay(BotExit());
            }
            else
            {
                return bot.UserQuest(b) + "\r" + "[" + DateTime.Now.ToString("HH:mm") + "] " + "Бот"/*FormLogin.userName*/ + ": "
                    + "Я вас не понимаю :(" + "\r" + "\n";
            }
            
        }

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


        public string BotInstruction()
        {   
            return "\r" + "\n" + "В данный момент я умею: " + "\r" + "\n"
                + "Отвечать на приветствие разными вариантами " + "\r" + "\n"
                + "Показывать дату и время " + "\r" + "\n"
                + "Складывать числа 'a и b' = c" + "\r" + "\n"
                + "Вычитать числа 'a из b' = c" + "\r" + "\n"
                + "Говорить погоду " + "\r" + "\n"
                + "Прощаться и закрывать программу " + "\r" + "\n"
                + "Скоро научусь чему то еще 😀";
        }

        public string BotExit() /// Как выйти из программы после того как бот ответил
        {
            string s = "Пока, друг";
            //добавить рандом
            //Thread.Sleep(2000);
            //Application.Exit();
            //Environment.Exit(0);
            return s;
        }

        public void LoadHistory(string a)
        {
            {
                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*"; // Фильтр для типа файлов
                    if (openFileDialog.ShowDialog() == DialogResult.OK) // Если пользователь выбрал файл 
                    {
                        string text = File.ReadAllText(openFileDialog.FileName); // чтение текста из выбранного файла
                        a = text; // загрузка текста в TextEdit
                    }
                }
            }
        }

        public void SaveHistory(string a)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Текстовые файлы (*.txt)|*.txt"; // Фильтр для типа файлов
                if (saveFileDialog.ShowDialog() == DialogResult.OK) // Если пользователь выбрал файл 
                {
                    string date = DateTime.Now.ToString("D");

                    //string text = a;
                    History.Add ($"История чата от " + date + "\r\n" + a);
                    //File.WriteAllText(saveFileDialog.FileName, all); // сохранение текста в файл по выбранному пути
                    File.WriteAllLines(saveFileDialog.FileName,History);
                }
            }
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


        /// Проверка регулярок была
        // else
        //if (regexTime.IsMatch(textBox_Question.Text))
        // {
        //     //Result();
        //     textBox_Result.Text += bot.UserQuest(textBox_Question.Text);
        //     //textBox_Result.Text += "[" + DateTime.Now.ToString("HH:mm") + "] " + FormLogin.userName + ": " + textBox_Question.Text + "\r" + "\n";
        //     textBox_Result.Text += bot.BotSay(bot.TimeBot());
        //     //textBox_Result.Text += "[" + DateTime.Now.ToString("HH:mm") + "] " + "Бот" + ": " + bot.TimeBot() + "\r" + "\n";
        // } // todo: else
        // if (regexDate.IsMatch(textBox_Question.Text))
        // {
        //     //Result();
        //     textBox_Result.Text += bot.UserQuest(textBox_Question.Text);
        //     //textBox_Result.Text += "[" + DateTime.Now.ToString("HH:mm") + "] " + FormLogin.userName + ": " + textBox_Question.Text + "\r" + "\n";
        //     textBox_Result.Text += bot.BotSay(bot.DateBot());
        //     //textBox_Result.Text += "[" + DateTime.Now.ToString("HH:mm") + "] " + "Бот" + ": " + bot.DateBot() + "\r" + "\n";
        // }
        // if (regexSum.IsMatch(textBox_Question.Text))
        // {
        //     //Result();
        //     textBox_Result.Text += bot.UserQuest(textBox_Question.Text);
        //     textBox_Result.Text += bot.BotSay(bot.BotSum(textBox_Question.Text));
        // }
        // if (regexSub.IsMatch(textBox_Question.Text))
        // {
        //     //Result();
        //     textBox_Result.Text += bot.UserQuest(textBox_Question.Text);
        //     textBox_Result.Text += bot.BotSay(bot.BotSub(textBox_Question.Text));
        // }


        //string botName = "Bot";

        //string question;

        //public Bot()
        //{
        //   question = "";
        //}


        //public string Question(string quest)
        //{
        //    return question;
        //}

    }
}
