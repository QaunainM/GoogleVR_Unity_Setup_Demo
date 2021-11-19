using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VRPlayer : MonoBehaviour
{

    public Player player;   // Import the script attached to the Player obhect (parent of this VR Player)

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Local Raycast (laser) method, the results will be stored in the varaible hit
        RaycastHit hit;     

        if (Input.GetButtonDown("Fire1")){                      // Code to see if the VR button has been pressed
            Debug.Log("Player has clicked the VR headset");     // Code to record the VR button being pressed in the Console

            if (Physics.Raycast(transform.position, transform.forward, out hit)) {      // Check if Raycasts have hit something, triggering from the position of the VR Player's camera in the direction forward
                if (hit.transform.tag == "Enter") {                                     // See if anything was hit with the tag "Enter"
                    hit.transform.GetComponent<DoorButton>().LookAtEnter();             // Activate the LookAtEnter method inside the DoorButton script
                    hit.transform.GetComponent<Teleporter>().Teleport();                // Acticate the Teleport method inside the Teleporter script
                    
                     
                    

                } else if (hit.transform.tag == "Exit") {                               //  See if anything was hit with the tag "Exit"
                    hit.transform.GetComponent<DoorButton>().LookAtExit();              // Activate the LookAtEnter method inside the DoorButton script
                    hit.transform.GetComponent<Teleporter>().Teleport();                // Acticate the Teleport method inside the Teleporter script
                }

                else if (hit.transform.tag == "Teleport") {                             //  See if anything was hit with the tag "Teleport"
                    hit.transform.GetComponent<Teleporter>().Teleport();                // Acticate the Teleport method inside the Teleporter script
                }

                            
            }
        }
       
    }
}
