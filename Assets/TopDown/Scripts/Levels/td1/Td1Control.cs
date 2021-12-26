using System;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace B2W.TopDown
{
    public class Td1Control : MonoBehaviour
    {
        public Teleporter tp;
        public FollowCamera cam;
        public GameObject removeObj;
        public GameObject activate;
        void Start()
        {
            tp.subscribeById(0, breakRoom);
            tp.subscribeById(1, ChangeScene);
        }

        private void breakRoom()
        {
            LeanTween.delayedCall(2f, Shake);
            removeObj.Destroy();
            activate.SetActive(true);

            //TODO POST EFFECTS
            cam.HellCam();

            //WHEN PLAYER GETS TO THE END ; USE A TRIGGER THEN CHANGE THE FIRST ROOM TO MAKE IT EVEN COOLER

         
        }

        private void ChangeScene()
        {
            SceneManager.LoadScene(1);
        }

        private void Shake()
        {
            cam.Shake(0.5f, 5f);
        }
    }
}