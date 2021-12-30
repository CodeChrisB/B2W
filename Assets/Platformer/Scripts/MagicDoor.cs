using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace B2W.Platformer
{
    public class MagicDoor : MonoBehaviour
    {
        private bool canEnter = false;
        public bool isTopDownLevel;
        public int level;
        public Animator anim;
        private void Start()
        {
            anim = gameObject.GetComponent<Animator>();
        }
        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.transform.tag == "Player")
            {
                canEnter = true;
                other.gameObject.GetComponent<PlayerCharacter>().setBubbleKey("E");
            }
        }
        private void OnTriggerExit2D(Collider2D other)
        {
            if (other.transform.tag == "Player")
            {
                canEnter = false;
                other.gameObject.GetComponent<PlayerCharacter>().disableBubble();

            }
        }

        void Update()
        {

            if (canEnter && Input.GetKeyDown(KeyCode.E)){
                anim.SetTrigger("OpenDoor");
                LeanTween.delayedCall(0.7f, LoadScene);   
                //todo suck the player into the door make him spin and get smaller  durring this animation
            }
        }

        private void LoadScene()
        {
            SceneManager.LoadScene((isTopDownLevel ? "td_" : "pf_") + level.ToString());
        }
    }
}