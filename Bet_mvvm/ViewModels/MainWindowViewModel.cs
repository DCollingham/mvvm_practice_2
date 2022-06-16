using Bet_mvvm.Commands;
using Bet_mvvm.Models;
using System;
using System.Collections.Generic;
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
        }


    }
}
 