using Bet_mvvm.Commands;
using Bet_mvvm.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Bet_mvvm.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        private Player player;
        private Table table;
        private int result;
        private string playerBetColour = "Red";

        private ObservableCollection<string> results;

        public ObservableCollection<string> Results
        {
            get { return results; }
            set 
            { 
                results = value; 
                OnPropertyChanged();
            }
        }


        private string resultInfoString;

        public string ResultInfoString
        {
            get => resultInfoString;
            set
            {
                resultInfoString = value;
                OnPropertyChanged();
            }
        }


        public ICommand AddFundsCommand { get; }
        public ICommand SpinCommand { get; }
        public ICommand SetBetSizeCommand { get; }

        public Player Player
        {
            get => player;
            set 
            {
                player = value;
                OnPropertyChanged();
            }
        }

        public Table Table
        {
            get => table;
            set 
            { 
                table = value;
                OnPropertyChanged();
            }
        }

        public decimal BankBalance
        {
            get => player.BankBalance;
            set 
            {
                player.BankBalance = value;
                OnPropertyChanged();
            }
        }

        public decimal AddFundAmount
        {
            get => player.AddFundAmount;
            set
            {
                player.AddFundAmount = value;
                OnPropertyChanged();
            }
        }

        public string SpinResult
        {
            get => table.SpinResult;
            set 
            {
                table.SpinResult = value;
                OnPropertyChanged();
            }
        }

        public int Result
        {
            get => result;
            set 
            { 
                result = value;
                OnPropertyChanged();
            }
        }


        public decimal BetSize
        {
            get => player.BetSize;
            set
            {
                player.BetSize = value;
                OnPropertyChanged();
            }
        }

        public MainWindowViewModel()
        {
            player = new Player
            {
                BankBalance = 0
            };
            table = new Table();

            AddFundsCommand = new AddFundsCommand(this);
            SpinCommand = new SpinCommand(this);
            SetBetSizeCommand = new SpinCommand(this);
            BetSize = 0.1M;
            results = new ObservableCollection<string>();
        }

        public void AddFunds(decimal amount)
        {
            BankBalance += amount;
        }

        public void SetBetSize(decimal amount)
        {
            BetSize = amount;
        }

        public void Spin()
        {
            if (BetSize <= BankBalance)
            {
                Random rnd = new();
                Result = rnd.Next(36);

                if (Result == 0)
                {
                    SpinResult = "Green";
                }
                else if (Result % 2 == 0)
                {
                    SpinResult = "Red";
                }
                else SpinResult = "Black";

                MakeBet(SpinResult);
            }
            else
            {
                results.Add("Sorry, deposit additional funds to play!");
            }
   
        }

        public void MakeBet(string result)
        {
            
            
           if(result != playerBetColour)
           BankBalance -= BetSize;

           else
           {
               BankBalance += (BetSize);
           }
            
            ResultInfoString = $"{result}";
            BetString();
        }

        public void BetString()
        {
            string betString = $"Player bet {playerBetColour}, Result was {SpinResult}";
            results.Add(betString);
        }

    }
}
 