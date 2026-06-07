using System.Collections;
using System.Collections.Generic;
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

        public void AddCoins(int cost)
        {
            _coins += cost;
        }

        public void PrintBalance()
        {
            Debug.Log(_coins);
        }
    }
}

