using UnityEngine;


namespace PixelCrew
{
    public class WalletManager : MonoBehaviour
    {
        private static WalletManager _instance;
        private int _coins = 0;

        private void Awake()
        {
            if (_instance == null) _instance = this;
        }

        public static WalletManager GetInstance()
        {
            return _instance;
        }

        public void AddCoins(int val)
        {
            _coins += val;
        }

        public void SubtractCoins(int val)
        {
            _coins -= val;
            if (_coins < 0) _coins = 0;
        }

        public void PrintBalance()
        {
            Debug.Log(_coins);
        }

        public int GetCoinsCount()
        {
            return _coins;
        }
    }
}

