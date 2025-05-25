using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Bank : MonoBehaviour {

    [SerializeField] private TMP_Text coinText;
    private int coins = 0;

    private void UpdateUI() {
        coinText.text = coins.ToString();
    }

    private void LoadCoins() {
        coins = PlayerPrefs.GetInt("CoinCount");
    }

    private void SaveCoins() {
        PlayerPrefs.SetInt("CoinCount", coins);
    }

    public void AddCoins(int coins) {
        this.coins += coins;
        UpdateUI();
        SaveCoins();
    }

    public bool SpendCoins(int coins) {
        int remain = this.coins - coins;
        if (remain >= 0) {
            this.coins = remain;
            UpdateUI();
            SaveCoins();
            return true;
        }
        return false;
    }

    private void Awake() {
        LoadCoins();
        UpdateUI();
    }

}
