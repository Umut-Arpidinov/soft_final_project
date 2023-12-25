using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;


namespace Hangman
{   


    public partial class MainPage : ContentPage
    {
        List<Button> buttons;
        List<ImageSource> images;
        List<Label> fieldChar;
        string word;
        int counterMiss = 0;
            
     
        public MainPage()
        {
            InitializeComponent();
            images = new List<ImageSource>();
            LoadImage();
            DoWordArea();
        }


        private void Bt_Click_NewGame(object sender, EventArgs e)
        {
            DoWordArea();
        }
        private void LoadImage()
        {
            for (int i = 0; i < 11; i++)
            {
                ImageSource image = ImageSource.FromFile("hang" + i.ToString() + ".png");
                images.Add(image);
                    
                    }
        }
        private void CreateKeyboard()
        {
            buttons = new List<Button>();   
            firstRow.Children.Clear();
            secondRow.Children.Clear(); 
            thirdRow.Children.Clear(); 
            for(int i = 65; i <91; i++)
            {
                Button button = new Button()
                {
                    Text = ((char)i).ToString(),
                    FontSize = 18,
                    WidthRequest = 35,
                    HeightRequest = 50                    
                };
                button.Clicked += Bt_Click_Key;
                if(i %65 <8) firstRow.Children.Add(button);
                else if(i % 65 >=8 && i%65 <17) secondRow.Children.Add(button);
                else thirdRow.Children.Add(button);
                buttons.Add(button);
            }
        }
        private void Bt_Click_Key(object sender, EventArgs e)
        {
            Button button = sender as Button;
            string character = button.Text.ToString();
            bool hit = false;
            for (int i = 0; i < this.word.Length-1; i++)
            {
                if (this.word[i].ToString().ToLower() == character.ToLower())
                {
                    hit = true;
                    fieldChar[i].Text = character.ToLower();
                }
            }
            if(hit == false)
            {
                counterMiss += 1;
                imageMiss.Source = images[counterMiss];
            }

            if(counterMiss == 10)
            {
                 MessageToUser(false);

            }
            int count  = 0;
            for(int i = 0;i < this.word.Length;i++)
            {
                if (fieldChar[i].Text != "-")
                {
                    count++;
                }         
            }
            if (count == this.word.Length)
            {
                MessageToUser(true);
            }
            button.IsEnabled = false;
        }

        private async void MessageToUser(bool isWin)
            
        {
            bool playAgain;
            if (isWin)
            {
                 playAgain = await DisplayAlert("Congratulations!","You win the game","Ok", "Cancel");
                if (playAgain) DoWordArea();
                else DoWordArea();
            }
            else
            {
                playAgain = await DisplayAlert("Game Over" ,"Hidden word was " + word.ToString() ,"Play again", "Cancel");
                if (playAgain) DoWordArea();
                else DoWordArea();
            }
               
          

        }

        

        private string RandomWord()
        {
            string[] words = { "cat", "dog", "house", "application", "computer" };
            Random r = new Random();
            return words[r.Next(words.Length)];
        }

        private async Task<string> GetRandomWordFromApi()
        {
            activityIndicator.IsRunning = true;
            activityIndicator.IsVisible = true;


            using (HttpClient client = new HttpClient())
            {
                try
                {
                    string apiUrl = "https://random-word-api.herokuapp.com/word";
                    string jsonResponse = await client.GetStringAsync(apiUrl);
                    string word = jsonResponse.Trim('[', ']', '"');
                    activityIndicator.IsRunning = false;
                    activityIndicator.IsVisible = false;

                    return word.Trim();
                }catch(Exception ex)
                {
                    ShowError(ex.Message);
                    return null;
                }
            }
        }

        private async void DoWordArea()
        {
            counterMiss = 0;
            CreateKeyboard();
            this.word = await GetRandomWordFromApi();
            if(!string.IsNullOrEmpty(this.word))
            {
                imageMiss.Source = images[0];
                fieldChar = new List<Label>();
                WordArea.Children.Clear();
                for (int i = 0; i < this.word.Length; i++)
                {
                    Label label = new Label()
                    {
                        Text = "-",
                        Margin = new Thickness(5),
                        FontSize = 30,
                        TextColor = Color.White
                    };
                    WordArea.Children.Add(label);
                    fieldChar.Add(label);
                }
                fieldChar[0].Text = this.word[0].ToString();
                fieldChar[this.word.Length - 1].Text = this.word[this.word.Length - 1].ToString();
            }
            else
            {
                DisplayAlert("Error", "Failed to fetch a random word from the API", "OK");
            }
          
        }

        private async void ShowError(string v)
        {
            DisplayAlert("Cannot access to network", v, "Try again", "Cancel");
          
   


        }


    }

  


}
