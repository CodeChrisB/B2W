using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveOjects : MonoBehaviour
{
   public GameObject[] ojects;

    void RemoveAll()
    {
        foreach (var o in ojects)
           Object.Destroy(o);
    }
}
