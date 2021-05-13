using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectSkin : MonoBehaviour
{
    public GameObject Skin1, Skin2, Skin3;
    int selectSkin1, selectSkin2, selectSkin3;
    void Start()
    {
        selectSkin1 = PlayerPrefs.GetInt("selectSkin1", 1);
        selectSkin2 = PlayerPrefs.GetInt("selectSkin2", 1);
        selectSkin3 = PlayerPrefs.GetInt("selectSkin3", 1);
    }

    // Update is called once per frame
    void Update()
    {
        if (selectSkin1 == 1)
        {
            Skin1.SetActive(true);
            Skin2.SetActive(false);
            Skin3.SetActive(false);
        }
        else
        {
            Skin1.SetActive(false);
        }

        if (selectSkin2 == 2)
        {
            Skin1.SetActive(false);
            Skin2.SetActive(true);
            Skin3.SetActive(false);
        }
        else
        {
            Skin2.SetActive(false);
        }

        if (selectSkin3 == 3)
        {
            Skin1.SetActive(false);
            Skin2.SetActive(false);
            Skin3.SetActive(true);
        }
        else
        {
            Skin3.SetActive(false);
        }
    }

    public void SelectOneSkin()
    {
        selectSkin1 = 1;
        PlayerPrefs.SetInt("selectSkin1", selectSkin1);
        selectSkin2 = 1;
        PlayerPrefs.SetInt("selectSkin2", selectSkin2);
        selectSkin3 = 1;
        PlayerPrefs.SetInt("selectSkin3", selectSkin3);
    }

    public void SelectTwoSkin()
    {
        selectSkin1 = 2;
        PlayerPrefs.SetInt("selectSkin1", selectSkin1);
        selectSkin2 = 2;
        PlayerPrefs.SetInt("selectSkin2", selectSkin2);
        selectSkin3 = 2;
        PlayerPrefs.SetInt("selectSkin3", selectSkin3);
    }

    public void SelectFreeSkin()
    {
        selectSkin1 = 3;
        PlayerPrefs.SetInt("selectSkin1", selectSkin1);
        selectSkin2 = 3;
        PlayerPrefs.SetInt("selectSkin2", selectSkin2);
        selectSkin3 = 3;
        PlayerPrefs.SetInt("selectSkin3", selectSkin3);
    }
}
