using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoneyText : MonoBehaviour
{
    public static int Money;
    Text text;

    void Start(){
        text = GetComponent<Text>();
        /*Money = PlayerPrefs.GetInt("money");*/
    }

    void Update(){
        text.text = Money.ToString();
        /*Money = PlayerPrefs.SetInt();*/
    }
}
