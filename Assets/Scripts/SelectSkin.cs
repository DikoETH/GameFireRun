using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectSkin : MonoBehaviour
{
    public GameObject Skin1, Skin2, Skin3, Skin4, Skin5;
    int selectSkin1, selectSkin2, selectSkin3, selectSkin4, selectSkin5;
    void Start()
    {
        selectSkin1 = PlayerPrefs.GetInt("selectSkin1", 1);
        selectSkin2 = PlayerPrefs.GetInt("selectSkin2", 1);
        selectSkin3 = PlayerPrefs.GetInt("selectSkin3", 1);
        selectSkin4 = PlayerPrefs.GetInt("selectSkin4", 1);
        selectSkin5 = PlayerPrefs.GetInt("selectSkin5", 1);
    }

    // Update is called once per frame
    void Update()
    {
        if (selectSkin1 == 1)
        {
            Skin1.SetActive(true);
            Skin2.SetActive(false);
            Skin3.SetActive(false);
            Skin4.SetActive(false);
            Skin5.SetActive(false);
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
            Skin4.SetActive(false);
            Skin5.SetActive(false);
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
            Skin4.SetActive(false);
            Skin5.SetActive(false);
        }
        else
        {
            Skin3.SetActive(false);
        }

        if (selectSkin4 == 4)
        {
            Skin1.SetActive(false);
            Skin2.SetActive(false);
            Skin3.SetActive(false);
            Skin4.SetActive(true);
            Skin5.SetActive(false);
        }
        else
        {
            Skin4.SetActive(false);
        }

        if (selectSkin5 == 5)
        {
            Skin1.SetActive(false);
            Skin2.SetActive(false);
            Skin3.SetActive(false);
            Skin4.SetActive(false);
            Skin5.SetActive(true);
        }
        else
        {
            Skin5.SetActive(false);
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
        selectSkin4 = 1;
        PlayerPrefs.SetInt("selectSkin4", selectSkin4);
        selectSkin5 = 1;
        PlayerPrefs.SetInt("selectSkin5", selectSkin5);
    }

    public void SelectTwoSkin()
    {
        selectSkin1 = 2;
        PlayerPrefs.SetInt("selectSkin1", selectSkin1);
        selectSkin2 = 2;
        PlayerPrefs.SetInt("selectSkin2", selectSkin2);
        selectSkin3 = 2;
        PlayerPrefs.SetInt("selectSkin3", selectSkin3);
        selectSkin4 = 2;
        PlayerPrefs.SetInt("selectSkin4", selectSkin4);
        selectSkin5 = 2;
        PlayerPrefs.SetInt("selectSkin5", selectSkin5);
    }

    public void SelectFreeSkin()
    {
        selectSkin1 = 3;
        PlayerPrefs.SetInt("selectSkin1", selectSkin1);
        selectSkin2 = 3;
        PlayerPrefs.SetInt("selectSkin2", selectSkin2);
        selectSkin3 = 3;
        PlayerPrefs.SetInt("selectSkin3", selectSkin3);
        selectSkin4 = 3;
        PlayerPrefs.SetInt("selectSkin4", selectSkin4);
        selectSkin5 = 3;
        PlayerPrefs.SetInt("selectSkin5", selectSkin5);
    }

    public void SelectFourSkin()
    {
        selectSkin1 = 4;
        PlayerPrefs.SetInt("selectSkin1", selectSkin1);
        selectSkin2 = 4;
        PlayerPrefs.SetInt("selectSkin2", selectSkin2);
        selectSkin3 = 4;
        PlayerPrefs.SetInt("selectSkin3", selectSkin3);
        selectSkin4 = 4;
        PlayerPrefs.SetInt("selectSkin4", selectSkin4);
        selectSkin5 = 4;
        PlayerPrefs.SetInt("selectSkin5", selectSkin5);
    }

    public void SelectFiveSkin()
    {
        selectSkin1 = 5;
        PlayerPrefs.SetInt("selectSkin1", selectSkin1);
        selectSkin2 = 5;
        PlayerPrefs.SetInt("selectSkin2", selectSkin2);
        selectSkin3 = 5;
        PlayerPrefs.SetInt("selectSkin3", selectSkin3);
        selectSkin4 = 5;
        PlayerPrefs.SetInt("selectSkin4", selectSkin4);
        selectSkin5 = 5;
        PlayerPrefs.SetInt("selectSkin5", selectSkin5);
    }
}
