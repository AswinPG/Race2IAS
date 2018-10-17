using Race2IAS.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Race2IAS
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SingleMockTestPage : ContentPage
	{
        public string a;
        public QuizData QD;
        public int i = 1;
        public Score CurrentScore = new Score();
        public questions test;
        public int limit;
        public Stopwatch watch;
        public int paper;

        public SingleMockTestPage (string dpath, int lim, int f)
		{
			InitializeComponent ();
            a = DependencyService.Get<IFileAccessHelper>().GetLocalFilePath(dpath);
            QD = new QuizData(a);
            var Data = QD.GetItemsAsync();
            Testing();
            limit = lim;
            paper = f;

            watch = new Stopwatch();
        }
        

        private async void Testing()
        {
            test = await QD.GetItemsAsync(1);
            //MainListView.ItemsSource =await Data;
            Question.Text = test.Question;
            OptionA.Text = test.OptionA;
            OptionB.Text = test.OptionB;
            OptionC.Text = test.OptionC;
            OptionD.Text = test.OptionD;
            await DisplayAlert("MockTest", "Ready when you are...", "Start Test");
            MainLayout.IsVisible = true;
            watch.Start();
            await MainProgressBar.ProgressTo(1, 100000, Easing.Linear);

        }




        private async void LoadNext()
        {
            test = await QD.GetItemsAsync(++i);

            await Task.Delay(500);
            Question.Text = test.Question;
            OptionA.Text = test.OptionA;
            OptionB.Text = test.OptionB;
            OptionC.Text = test.OptionC;
            OptionD.Text = test.OptionD;
            OptionAFrame.BackgroundColor = Color.Peru;
            OptionBFrame.BackgroundColor = Color.Peru;
            OptionCFrame.BackgroundColor = Color.Peru;
            OptionDFrame.BackgroundColor = Color.Peru;
            await Task.Delay(300);
        }

        private async void ResultPage()
        {
            await DisplayAlert("Test Over", "Your Time's Up or You've attended all questions", "Go to results");
            MainLayout.IsVisible = false;
            ResultLayout.IsVisible = true;
            Score.Text = "Total Mark = " + CurrentScore.Total.ToString();
            QuestionsAttented.Text = "Attempted questions : " + (CurrentScore.Correct + CurrentScore.Wrong);
            Correct.Text = "Correct : " + CurrentScore.Correct;
            Wrong.Text = "Wrong : " + CurrentScore.Wrong;
            await Task.Delay(20);
            Wrong.Text = "Wrong : " + CurrentScore.Wrong;

            if (CurrentScore.Total >= 40)
            {
                await DisplayAlert("Congrats", "You're Excellent", "Ok");
            }
            else if (CurrentScore.Total < 40 && CurrentScore.Total > 10)
            {
                await DisplayAlert("Congrats", "You're  Okay..", "Ok");
            }
            else
            {
                await DisplayAlert("Oops", "You need a lot of improvement", "Ok");
            }
        }

        private void OptionAPressed(object sender, EventArgs e)
        {
            if (i < limit && (watch.Elapsed < TimeSpan.FromSeconds(100)))
            {
                OptionAFrame.BackgroundColor = Color.Green;
                if (test.Answer == "A")
                {
                    CurrentScore.Total += 2;
                    CurrentScore.Correct++;
                    OptionAFrame.BackgroundColor = Color.Green;
                }
                else
                {
                    CurrentScore.Total -= 0.5;
                    CurrentScore.Wrong++;
                    OptionAFrame.BackgroundColor = Color.Red;
                }
                LoadNext();
            }

            else
            {
                OptionAFrame.BackgroundColor = Color.Green;
                if (test.Answer == "A")
                {
                    CurrentScore.Total += 2;
                    CurrentScore.Correct++;
                    OptionAFrame.BackgroundColor = Color.Green;
                }
                else
                {
                    CurrentScore.Total -= 0.5;
                    CurrentScore.Wrong++;
                    OptionAFrame.BackgroundColor = Color.Red;
                }
                ResultPage();
            }



        }

        private void OptionBPressed(object sender, EventArgs e)
        {
            if (i < limit && (watch.Elapsed < TimeSpan.FromSeconds(100)))
            {
                OptionBFrame.BackgroundColor = Color.Green;
                if (test.Answer == "B")
                {
                    CurrentScore.Total += 2;
                    CurrentScore.Correct++;
                    OptionBFrame.BackgroundColor = Color.Green;
                }
                else
                {
                    CurrentScore.Total -= 0.5;
                    CurrentScore.Wrong++;
                    OptionBFrame.BackgroundColor = Color.Red;
                }
                LoadNext();
            }

            else
            {
                OptionBFrame.BackgroundColor = Color.Green;
                if (test.Answer == "B")
                {
                    CurrentScore.Total += 2;
                    CurrentScore.Correct++;
                    OptionBFrame.BackgroundColor = Color.Green;
                }
                else
                {
                    CurrentScore.Total -= 0.5;
                    CurrentScore.Wrong++;
                    OptionBFrame.BackgroundColor = Color.Red;
                }
                ResultPage();
            }
        }

        private void OptionCPressed(object sender, EventArgs e)
        {
            if (i < limit && (watch.Elapsed < TimeSpan.FromSeconds(100)))
            {
                OptionCFrame.BackgroundColor = Color.Green;
                if (test.Answer == "C")
                {
                    CurrentScore.Total += 2;
                    CurrentScore.Correct++;
                    OptionCFrame.BackgroundColor = Color.Green;
                }
                else
                {
                    CurrentScore.Total -= 0.5;
                    CurrentScore.Wrong++;
                    OptionCFrame.BackgroundColor = Color.Red;
                }

                LoadNext();
            }
            else
            {
                OptionCFrame.BackgroundColor = Color.Green;
                if (test.Answer == "C")
                {
                    CurrentScore.Total += 2;
                    CurrentScore.Correct++;
                    OptionCFrame.BackgroundColor = Color.Green;
                }
                else
                {
                    CurrentScore.Total -= 0.5;
                    CurrentScore.Wrong++;
                    OptionCFrame.BackgroundColor = Color.Red;
                }
                ResultPage();
            }
        }

        private void OptionDPressed(object sender, EventArgs e)
        {
            if (i < limit && (watch.Elapsed < TimeSpan.FromSeconds(100)))
            {
                OptionDFrame.BackgroundColor = Color.Green;
                if (test.Answer == "D")
                {
                    CurrentScore.Total += 2;
                    CurrentScore.Correct++;
                    OptionDFrame.BackgroundColor = Color.Green;
                }
                else
                {
                    CurrentScore.Total -= 0.5;
                    CurrentScore.Wrong++;
                    OptionDFrame.BackgroundColor = Color.Red;
                }

                LoadNext();
            }
            else
            {
                OptionDFrame.BackgroundColor = Color.Green;
                if (test.Answer == "D")
                {
                    CurrentScore.Total += 2;
                    CurrentScore.Correct++;
                    OptionDFrame.BackgroundColor = Color.Green;
                }
                else
                {
                    CurrentScore.Total -= 0.5;
                    CurrentScore.Wrong++;
                    OptionDFrame.BackgroundColor = Color.Red;
                }
                ResultPage();
            }

        }

        private async void ViewAnswers_Clicked(object sender, EventArgs e)
        {
            if (paper == 1)
            {
                await Navigation.PushAsync(new PlainWebView("mock1_solutions.html"));
            }

            else if (paper == 2)
            {
                await Navigation.PushAsync(new PlainWebView("mock2_solutions.html"));
            }

        }
    }
}