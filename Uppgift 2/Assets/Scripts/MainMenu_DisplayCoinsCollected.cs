using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenu_DisplayCoinsCollected : MonoBehaviour
{

    [SerializeReference] private Text textComponent;

    // Start is called before the first frame update
    void Start()
    {
        textComponent.text = "Total Coins Collected: " + PlayerPrefs.GetInt("CoinAmount");
    }
}
