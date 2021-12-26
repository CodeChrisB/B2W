using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace B2W.TopDown
{
    public class Teleporter : MonoBehaviour
    {
        public Dictionary<int,UnityAction> beforeDestroy = new Dictionary<int,UnityAction>();
        [SerializeField]
        public int teleportId;

        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.transform.tag == "Player")
            {
                LeanTween.move(other.gameObject,new Vector3(this.transform.position.x,this.transform.position.y,other.transform.position.z),0.5f);
                var script = other.gameObject.GetComponent<PlayerCharacter>();
                script.SpinPlayer(5, 5, true);
                beforeDestroy[teleportId].Invoke();
                Destroy(this.gameObject, 5);

            }
        }

        internal void subscribeById(int id, UnityAction breakRoom)
        {
            beforeDestroy.Add(id, breakRoom);
        }

        internal void unsubscribeById(int id)
        {
            beforeDestroy.Remove(id);
        }



    }

}