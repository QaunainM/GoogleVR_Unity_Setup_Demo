using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VRPlayer : MonoBehaviour
{

    public Player player;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Local Raycast (laser) variable and the results will be stored in hit
        RaycastHit hit;     

        if (Input.GetButtonDown("Fire1")){
            Debug.Log("Player has clicked the VR headset");

            if (Physics.Raycast(transform.position, transform.forward, out hit)) {
                if (hit.transform.tag == "Enter") {
                    hit.transform.GetComponent<DoorButton>().LookAtEnter();
                    hit.transform.GetComponent<Teleporter>().Teleport();
                    
                     
                    

                } else if (hit.transform.tag == "Exit") {
                    hit.transform.GetComponent<DoorButton>().LookAtExit();
                    hit.transform.GetComponent<Teleporter>().Teleport();
                }

                else if (hit.transform.tag == "Teleport") {
                    hit.transform.GetComponent<Teleporter>().Teleport();
                }

                            
            }
        }


      
                            

    }
}
