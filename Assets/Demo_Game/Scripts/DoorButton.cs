using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorButton : MonoBehaviour
{
    public Door door;           // Import the Script for the Door GameObject
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    } 

    // Custom method for when the Enter button is being looked at
    public void LookAtEnter() {
        door.LowerDoor();               // Tells it to jump to a method called LowerDoor() inside the Door's script
    }


    // Custom method for when the Exit button is being looked at
    public void LookAtExit() {
        door.CloseDoor();               // Tells it to jump to a method called CloseDoor() inside the Door's script
    }




}
