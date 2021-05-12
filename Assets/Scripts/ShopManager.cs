using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopManager : MonoBehaviour
{
    private int index;
    private int indexNow;
    [SerializeField] private SetSkin setSkin;
    [SerializeField] private Text priceText;
    [SerializeField] private int[] price;

    private void Start(){
        index = setSkin.index;
        indexNow = index;
        //Skin();
    }

    public void SkinMinus(){
        if(index > 0){
            index--;
        }
        else
        {
           index = 0; 
        }
        //Skin();
        setSkin.UpdateSkin(index);
        PlayerPrefs.SetInt("index", index);
    }

    public void SkinPlus(){
        if(index < 5){
            index++;
        }
        else
        {
           index = 5; 
        }
        /*Skin();*/
        setSkin.UpdateSkin(index);
        PlayerPrefs.SetInt("index", index);
    }

    /*private void Skin() {
        setSkin.UpdateSkin(index);
        priceText.text = price [index].ToString ();
        if (MoneyText.Money >= price [index])
            priceText.color = Color.green;
        else if (MoneyText.Money < price [index])
            priceText.color = Color.red;
        if (indexNow == index) {
            priceText.color = Color.yellow;
            priceText.text = "Selection";
        } else if (PlayerPrefs.GetInt ("" + index.ToString ()) == 1 || index == 0) {
            priceText.color = Color.blue;
            priceText.text = "Select";
        }
    }*/

    /*public void BuySkin () {
        Skin ();
        if (PlayerPrefs.GetInt ("" + index.ToString ()) == 1 || index == 0) {
            PlayerPrefs.SetInt ("index", index);
            priceText.color = Color.yellow;
            priceText.text = "Selection";
            indexNow = index;
        } else if (PlayerPrefs.GetInt ("" + index.ToString ()) == 0) {
            if (MoneyText.Money >= price [index]) {
                MoneyText.Money -= price [index];
                priceText.text = price [index].ToString ();
                PlayerPrefs.SetInt ("money", MoneyText.Money);
                PlayerPrefs.SetInt ("" + index.ToString (), 1);
            }
            Skin();
        }
    }*/
}