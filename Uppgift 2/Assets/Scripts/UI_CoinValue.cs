using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_CoinValue : MonoBehaviour
{
    private Text textCoponent;
    private PlayerState playerState;

    // Start is called before the first frame update
    void Start()
    {
       playerState = GameObject.Find("Player").GetComponent<PlayerState>();
        textCoponent = gameObject.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        textCoponent.text = playerState.coinAmount + "";
    }
}
