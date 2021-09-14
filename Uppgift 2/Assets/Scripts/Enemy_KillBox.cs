using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_KillBox : MonoBehaviour
{

    GameObject gameobjectToKill;

    private void Start() {

       gameobjectToKill = gameObject.transform.parent.gameObject;
    }


    private void OnTriggerEnter2D(Collider2D collision) {

        if(collision.CompareTag("Player") == true) {
            if (collision.gameObject.GetComponent<PlayerMovement>().isFalling() == true) {
                gameObject.GetComponentInParent<Enemy_SpiderMovement>().killMe();
            }
        }
    }
}
