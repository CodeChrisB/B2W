using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace B2W.TopDown
{
    public static class Extensions
    {
        public static void DestroyAll(this GameObject[] obj)
        {
            foreach(GameObject val  in obj)
            {
                Object.Destroy(val);
            }
        }

        public static void Destroy(this GameObject obj)
        {
            Object.Destroy(obj);
        }

        public static void SetColor(this GameObject obj,Color color)
        {
            obj.GetComponent<SpriteRenderer>().color = color;
        }
        public static void SetColor(this GameObject[] obj, Color color)
        {
            foreach (GameObject val in obj)
            {
                val.GetComponent<SpriteRenderer>().color = color;
            }
           
        }
    }
}
