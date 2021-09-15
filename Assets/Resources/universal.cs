using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class universal : MonoBehaviour
{
    //public GameObject target;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
void Update ()
{
    //transform.RotateAround(target.transform.position, Vector3.down, 45*Time.deltaTime);
    
    
    transform.Rotate(0,45*Time.deltaTime, 0); 
}
}
