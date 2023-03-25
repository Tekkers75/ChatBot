/// @author Саранчин К.А.
/// Класс формы и обработчики событий
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatBot
{
    public partial class FormLogin : Form
    {
        

        public FormLogin()
        {
            InitializeComponent();
            KeyPreview = true;
            this.KeyDown += new KeyEventHandler(FormLogin_KeyDown);
        }

        // 
        public static string userName { get; set; }


        private void FormLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
               //this.buttonLogin.Focus();
               // buttonLogin_Click(buttonLogin, null);
               buttonLogin.PerformClick();
            }
        }


        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (textBoxLogin.Text == "")
            {
                MessageBox.Show("Вы не ввели имя");
            }
            else
            {
                userName = textBoxLogin.Text;
                // todo: rename
                Form FormBot = new FormBot();
               
                //FormBot.bot.username = textBoxLogin.Text;
                Close();
                FormBot.Show();
            }
        }
    }
}
