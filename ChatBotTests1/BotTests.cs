using Microsoft.VisualStudio.TestTools.UnitTesting;
using ChatBot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ChatBot.Tests
{
    [TestClass()]
    public class BotTests
    {
        [TestMethod()]
        public void AnswerTimeTest()
        {
            Bot bot = new Bot();
            
            string quest = "время";

            //[20:03] Бот: 20:03:22
            Assert.AreEqual(bot.UserQuest(quest) + "\r"  //"\n"
                + bot.BotSay(bot.TimeBot()), bot.Answer(quest, bot));
        }

        [TestMethod()]
        public void UserQuestTest()
        {
            Bot bot = new Bot();

            string quest = "Как дела";

            
            Assert.AreEqual("[" + DateTime.Now.ToString("HH:mm") + "] " + FormLogin.userName + ": " + quest + "\r" + "\n", bot.UserQuest(quest));
        }

        [TestMethod()]
        public void BotSayTest()
        {
            Bot bot = new Bot();

            string quest = "Все хорошо";
            Assert.AreEqual("[" + DateTime.Now.ToString("HH:mm") + "] " + "Бот" + ": " + quest + "\r" + "\n", bot.BotSay(quest));
        }

        [TestMethod()]
        public void BotSumTest()
        {
            Bot bot = new Bot();

            string quest = "Сложи 5 и 6";
            Assert.AreEqual("11",bot.BotSum(quest));
        }


        [TestMethod()]
        public void BotSubTest()
        {
            Bot bot = new Bot();

            string quest = "Вычти 100 из 130";
            Assert.AreEqual("30", bot.BotSub(quest));
        }


        //[TestMethod()]
        //public void SiteWheatherTest()
        //{
        //    Bot bot = new Bot();

        //    string quest = "Вычти 100 из 130";
        //    Assert.AreEqual("30", bot.SiteWheather());
        //}



    }





}