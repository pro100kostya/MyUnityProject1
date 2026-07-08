using UnityEngine;
using PixelCrew;

public class Coin : MonoBehaviour
{
    [SerializeField] private int _cost;

    private WalletManager _walletManager;

    private void Start()
    {
        _walletManager = WalletManager.GetInstance();
    }

    public void Collect()
    {
        _walletManager.AddCoins(_cost);
        _walletManager.PrintBalance();
    }
}
