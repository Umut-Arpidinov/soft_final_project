using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.System;
using Windows.UI.Popups;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;
using static System.Net.Mime.MediaTypeNames;

// Документацию по шаблону элемента "Пустая страница" см. по адресу https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x419

namespace HangmanWindows
{
    /// <summary>
    /// Пустая страница, которую можно использовать саму по себе или для перехода внутри фрейма.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        List<Button> buttons;
        List<BitmapImage> images;
        List<TextBlock> fieldChar;
        string word;
        int counterMiss = 0;
        public MainPage()
        {
            this.InitializeComponent();
            ApplicationView view=ApplicationView.GetForCurrentView();
            view.TryEnterFullScreenMode();
            images = new List<BitmapImage>();
            LoadImage();
            DoWordArea();
        }

        private void LoadImage()
        {
            for (int i = 0; i < 11; i++)
            {
                var imagePath = @"ms-appx:/Images/hang" + i.ToString() + ".png";
                var image = new BitmapImage(new Uri(imagePath));
                images.Add(image);
            

            }
        }

        private string RandomWord()
        {
            string[] word = { "cat", "dog", "software","house","apple","banana","elephant"};
            Random random = new Random();
            return word[random.Next(word.Length)];

        }

        private void DoWordArea()
        {
            counterMiss = 0;
            CreateKeyboard();

            this.word = RandomWord();
            imageMiss.Source = images[0];
            fieldChar = new List<TextBlock>();
            wordArea.Children.Clear();
            for (int i = 0; i < this.word.Length; i++)
            {
                TextBlock textBlock = new TextBlock()
                {
                    Text = "_",
                    Margin = new Thickness(10),
                    FontSize = 50
                };
                wordArea.Children.Add(textBlock);
                fieldChar.Add(textBlock);
            }
            fieldChar[0].Text= this.word[0].ToString(); //first char in word
            fieldChar[this.word.Length - 1].Text = this.word[this.word.Length - 1].ToString();  // last char in word

        }

        private void BT_CLICK_NewGame(object sender, RoutedEventArgs e)
        {
            DoWordArea();
        }

        private void CreateKeyboard()
        {
            buttons = new List<Button>();
            firstRow.Children.Clear();
            secondRow.Children.Clear();
            thirdRow.Children.Clear();
            for (int i = 65; i < 91; i++) //ASCII [A-Z]
            {
                Button btn = new Button()
                {
                    Content = ((char)i).ToString(),
                    FontSize = 55,
                    Width = 120,
                    Height = 120,
                    Margin = new Thickness(2),
                };
                btn.Click += Bt_Click_Key;
                if(i%65<8) firstRow.Children.Add(btn);
                else if (i%65>=8 && i%65<16) secondRow.Children.Add(btn);
                else thirdRow.Children.Add(btn);
                buttons.Add(btn);


            }
        }

        private void Bt_Click_Key(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            string character = button.Content.ToString();
            bool hit = false;
            for (int i = 1; i < this.word.Length - 1; i++) // without first and last 
            {
                if (this.word[i].ToString().ToLower() == character.ToLower())
                {
                    hit = true;
                    fieldChar[i].Text = character.ToLower();

                }
            }
                if (hit==false)
            {
                counterMiss += 1;
                imageMiss.Source = images[counterMiss];

            }
            //lose
            if(counterMiss == 10)
                {
                MessageToUserAsync("You lose");
                };
            //win
            int count = 0 ;
            for(int i = 0;i<this.word.Length; i++)
                {
                if (fieldChar[i].Text !="_") count++;
                }
            if(count == this.word.Length)
            {
                MessageToUserAsync("You win");

            };
            button.IsEnabled = false;
        }

        private async void MessageToUserAsync(string v)
        {
            MessageDialog messageDialog = new MessageDialog("Play again", v);
            await messageDialog.ShowAsync();
            DoWordArea(); // new game 
        }
    }
}
