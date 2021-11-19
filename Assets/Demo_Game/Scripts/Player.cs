using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Transform vrPlayer;                  // Import the VRPlayer's transform component 
    private CharacterController cc;             // Import the Character Controller for Player GameObject (parent of the VRPlayer)

    public float lookDownAngle = 25.0f;         // Create a variable to represent the look down angle that will trigger the players movement
    public float speed = 3.0f;                  // Create a variable to represent the speed the player will move
    public bool moveForward;                    // Create a true/false Boolean to let us know if the playe is in the moveForward state

    

    
    // Start is called before the first frame update
    void Start()
    {
        cc = GetComponent<CharacterController>();       // Finish the importing of the Character controller

    }

    // Update is called once per frame
    void Update()
    {
        if (vrPlayer.eulerAngles.x >= lookDownAngle && vrPlayer.eulerAngles.x < 90.0f) {            // Check if the VRPlayers headmovement rotation is more than the lookDownAngle and less than the floor
            moveForward = true;                                                                     // Switch Boolean to being in the moveForward state
        }
        else {
            moveForward = false;                                                                    // If the above IF statment is not true then the player's Booelan moveForward is set to to False
        }

        if (moveForward == true) {                                                                  // What to do if the moveForward state is True                                                    
            Vector3 forward = vrPlayer.TransformDirection(Vector3.forward);                         // Create a Vector3 variable called Forward and apply a conversion to it so movement will work correctly

            cc.SimpleMove(forward * speed);                                                         // Tell the Character Controller for the Player GameObject to move in the way of the above Forward variable and multiply it be speed

        }

    }

    

}
