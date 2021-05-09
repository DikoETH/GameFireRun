using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopManager : MonoBehaviour
{
    private int index;
    [SerializeField] private SetSkin setSkin;
    [SerializeField] private Text priceText;
    [SerializeField] private int[] price;

    private void Start(){
        index = setSkin.index;
        /*priceText.text = price[index].ToString();*/
        DetectionPriceSkin();
        
    }

    public void SkinMinus(){
        if(index > 0){
            index--;
        }
        else
        {
           index = 0; 
        }
        setSkin.UpdateSkin(index);
        DetectionPriceSkin();
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
        setSkin.UpdateSkin(index);
        DetectionPriceSkin();
        PlayerPrefs.SetInt("index", index);
    }

    private void DetectionPriceSkin(){
        if(MoneyText.Money >= price[index]){
            priceText.color = Color.green;
        }
        else if(MoneyText.Money < price[index])
        {
            priceText.color = Color.red;
        }
    }

    public void BuySkin(){
    }
}