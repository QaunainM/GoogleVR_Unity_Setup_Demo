using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject cameraRig;
    public float moveOffset = 50f;
    
    // Start is called before the first frame update
    void Start()
    {
        cameraRig = GameObject.Find("CameraRig"); 
    }

    // Update is called once per frame
    void Update()
    {

        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.forward, out hit)) {
            //Debug.Log(hit.transform.name); 
            if (hit.transform.tag == "Enemy") {
               cameraRig.transform.position = transform.position + transform.forward * moveOffset * Time.deltaTime;
            }
        }
        
    }
}
