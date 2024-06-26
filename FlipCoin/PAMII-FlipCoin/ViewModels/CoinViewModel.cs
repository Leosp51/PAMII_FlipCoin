//using AppKit;
using CommunityToolkit.Mvvm.ComponentModel;
using PAMII_FlipCoin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace PAMII_FlipCoin.ViewModels
{
    public partial class CoinViewModel:ObservableObject
    {
        [ObservableProperty]
        public string face;
        [ObservableProperty]
        public string img;
        [ObservableProperty]
        public string result;

        public ICommand PlayCommand { get; set; }

        public CoinViewModel()
        {
            PlayCommand = new Command(Play);
        }

        public void Play()
        {
            Coin coin = new Coin();
            Result = coin.Jogar(Face);
            Img = $"{coin.Lado}.jpeg";
        }
    }
}
