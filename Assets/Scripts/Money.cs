using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Money : MonoBehaviour
{
    void Start(){
        
    }

    void Update(){
        
    }

    private void OnTriggerEnter2D(Collider2D collision){
        if(collision.CompareTag("Player")){
            MoneyText.Money += 10;
            Destroy(gameObject);
        }
    }
}
