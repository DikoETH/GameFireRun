using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetSkin : MonoBehaviour
{
    public int index;
    [SerializeField] private Sprite [] Player1Sprite, Player2Sprite;
    private SpriteRenderer Player1, Player2;

    private void Awake(){
        index = PlayerPrefs.GetInt("index");
    }

    private void Start(){
        Player1 = transform.GetChild (0).GetComponent<SpriteRenderer>();
        Player2 = transform.GetChild (1).GetComponent<SpriteRenderer>();
        UpdateSkin(index);
    }

    public void UpdateSkin (int index){
        Player1.sprite = Player1Sprite [index];
        Player2.sprite = Player2Sprite [index];
    }
}
