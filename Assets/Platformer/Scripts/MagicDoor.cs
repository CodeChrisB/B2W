using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagicDoor : MonoBehaviour
{
    private bool canEnter = false;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.transform.tag == "Player")
        {
            canEnter = true;
            Debug.Log("Enter");
            //other.gameObject.GetComponent<Player>
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if(other.transform.tag == "Player")
        {
            canEnter = false;
            Debug.Log("Leave");
        }
    }
}
