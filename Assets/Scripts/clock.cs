using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class clock : MonoBehaviour
{   
    float nowTime = 0;

    void FixedUpdate()
    {
        nowTime += Time.deltaTime;
        GetComponent<LineRenderer>().SetPosition(1,new Vector3(Mathf.Sin(2*Mathf.PI*nowTime/60),Mathf.Cos(2*Mathf.PI*nowTime/60),0));      
    }
}
