using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BankATM
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Card card = new Card("1234", 5000000);
        private string hello = "hello";
        private string salom = "Assalomu alaykum";
        private string pul = " so'm yechildi ";
        string str = " Xush kelibsiz ";
        bool istrue = false;
        public MainWindow()
        {
            InitializeComponent();
            PasswordLabel.Visibility = Visibility.Collapsed;
            PasswordBox.Visibility = Visibility.Collapsed;
            passButtot.Visibility = Visibility.Collapsed;
            CheckBalanceButton.Visibility = Visibility.Collapsed;
            SumTextBox.Visibility = Visibility.Collapsed;
            hisobla.Visibility = Visibility.Collapsed;
            Pulyechish.Visibility = Visibility.Collapsed;
            yangilash.Visibility = Visibility.Collapsed;
            parol.Visibility = Visibility.Collapsed;
            Parol.Visibility = Visibility.Collapsed;
            Chiqish.Visibility = Visibility.Collapsed;
            
        }

        
        private void UzbekButton_Click(object sender, RoutedEventArgs e)
        {
            OutputText.Text = salom;
            PasswordLabel.Visibility = Visibility.Visible;
            PasswordBox.Visibility = Visibility.Visible;
            passButtot.Visibility = Visibility.Visible;
            // Uzbek tilini tanlash uchun kodlar
        }

        private void EnglishButton_Click(object sender, RoutedEventArgs e)
        {
            OutputText.Text = hello;
            PasswordLabel.Visibility = Visibility.Visible;
            PasswordBox.Visibility = Visibility.Visible;
            passButtot.Visibility = Visibility.Visible;
            // Ingliz tilini tanlash uchun kodlar
        }

        string str4 = " Balansingiz : ";
        private void pass_Click(object sender, RoutedEventArgs e)
        {
           
            string password = PasswordBox.Password; // Parolni olamiz
            if (password == card.Pin) // Parol tekshiriladi
            {
                
                OutputText.Text = str;
                PasswordLabel.Visibility = Visibility.Collapsed;
                PasswordBox.Visibility = Visibility.Collapsed;
                passButtot.Visibility = Visibility.Collapsed;
                UzbekButton.Visibility = Visibility.Collapsed;
                EnglishButton.Visibility = Visibility.Collapsed;
                //OutputText.Visibility = Visibility.Collapsed;
                salom = "";
                hello = "";
                
                CheckBalanceButton.Visibility = Visibility.Visible;
                Pulyechish.Visibility = Visibility.Visible;
                Parol.Visibility = Visibility.Visible;
                Chiqish.Visibility = Visibility.Visible;

            }
            else
            {
                
                OutputText.Text = $"Parol noto'g'ri kiritildi! ";
              
            }
        }
        
        
        private void CheckBalanceButton_Click(object sender, RoutedEventArgs e)
        {
            if (istrue) return;

            OutputText.Text = "";
            yangilash.Visibility = Visibility.Collapsed;
            parol.Visibility = Visibility.Collapsed;
            hisobla.Visibility = Visibility.Collapsed;
            OutputText2.Text = "";
            str = "";
            CheckBalanceButton.Visibility = Visibility.Visible;
            
            OutputText3.Text = "Balansingiz ";
            OutputText4.Text = card.Balans.ToString();
        }

        private void Pulyechish_Click(object sender, RoutedEventArgs e) 
        {
            if (istrue) return;
            str = "";
            
            BalanceLabel.Visibility = Visibility.Collapsed;
            SumTextBox.Visibility = Visibility.Visible;
            hisobla.Visibility = Visibility.Visible;
            OutputText2.Text = "";
            OutputText3.Text = "";
            OutputText4.Text = "";
            yangilash.Visibility = Visibility.Collapsed;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (istrue) return;
            decimal sum = 0;
            SumTextBox.Visibility = Visibility.Collapsed;
            sum = Convert.ToDecimal(SumTextBox.Text);
            if(sum > card.Balans)
            {
                OutputText.Text = " Kartada mablag yetarli emas ! " ;
                return;
            }
            card.Balans -= sum;
            OutputText.Text = SumTextBox.Text + "" + pul;
        }

        private void Parol_Click(object sender, RoutedEventArgs e)
        {
            if (istrue) return;
            OutputText.Visibility = Visibility.Collapsed;
            hisobla.Visibility= Visibility.Collapsed;
            SumTextBox.Visibility= Visibility.Collapsed;
            yangilash.Visibility = Visibility.Visible;
            parol.Visibility = Visibility.Visible;
            Parol.Visibility = Visibility.Visible;
            

        }
        private void yangi_Click(object sender, RoutedEventArgs e) 
        {
            if (istrue) return;
            yangilash.Visibility = Visibility.Visible;
            Parol.Visibility = Visibility.Visible;
            parol.Visibility = Visibility.Collapsed;
            card.Pin = parol.Text;
            OutputText2.Text = " Parol yangilandi ";
            OutputText4.Text = "";
        }
        private void Chiqish_Click(object sender, RoutedEventArgs e)
        {
            OutputText.Visibility = Visibility.Collapsed;
            OutputText4.Visibility = Visibility.Collapsed;
            OutputText2.Visibility = Visibility.Collapsed;
            OutputText3.Visibility = Visibility.Collapsed;
            PasswordLabel.Visibility = Visibility.Collapsed;
            PasswordBox.Visibility = Visibility.Collapsed;
            passButtot.Visibility = Visibility.Collapsed;
            CheckBalanceButton.Visibility = Visibility.Collapsed;
            SumTextBox.Visibility = Visibility.Collapsed;
            hisobla.Visibility = Visibility.Collapsed;
            Pulyechish.Visibility = Visibility.Collapsed;
            yangilash.Visibility = Visibility.Collapsed;
            parol.Visibility = Visibility.Collapsed;
            Parol.Visibility = Visibility.Collapsed;


            
            
        }


    }
       


    }
    class Card
    {
        public string Pin { get; set; } = "1234";
        public decimal Balans { get; set; } = 5000000;
        public Card(string pin , decimal balans ) 
        { 
          Pin = pin;
          Balans = balans;
        }
    }

