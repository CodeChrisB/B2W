using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightSwing : MonoBehaviour
{
    // Start is called before the first frame update
    public float endPos;
    public float time;
    void Start()
    {
        LeanTween.rotateY(this.gameObject,endPos,time).setLoopPingPong();
    }


}
