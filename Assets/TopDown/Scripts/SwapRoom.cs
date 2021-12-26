using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwapRoom : MonoBehaviour
{
    public GameObject oldRoom;
    public GameObject newRoom;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.transform.tag == "Player")
        {
            oldRoom.SetActive(false);
            newRoom.SetActive(true);
            
        }
    }
}
