using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace B2W.Platformer
{
    public class MagicDoor : MonoBehaviour
    {
        private bool canEnter = false;
        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.transform.tag == "Player")
            {
                canEnter = true;
                Debug.Log("Enter");
                other.gameObject.GetComponent<PlayerCharacter>().setBubbleText("fr can i enter now ?");
            }
        }
        private void OnTriggerExit2D(Collider2D other)
        {
            if (other.transform.tag == "Player")
            {
                canEnter = false;
                Debug.Log("Leave");
                other.gameObject.GetComponent<PlayerCharacter>().disableBubble();

            }
        }

        void Update()
        {
            if (canEnter && Input.GetKeyDown(KeyCode.E)){
                Debug.Log("YEs i enter now");
            }
        }
    }
}