using UnityEngine;
using PixelCrew;

public class Coin : MonoBehaviour
{
    [SerializeField] private int _cost;

    public void Collect()
    {
        WalletManager.GetInstance().AddCoins(_cost);
        WalletManager.GetInstance().PrintBalance();
    }
}
