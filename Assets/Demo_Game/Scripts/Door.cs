using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{

    private Vector3 targetPosition;             // Varaible that will hold the position the Door can be set to throughout the game
    public Vector3 loweredPosition;             // Variable that holds the position of the Doors open state (loweredPosition)
    private Vector3 closedPosition;             // Variable that holds the position of the Doors closed state (closedPosition)

    public float speed = 1.5f;

    
    // Start is called before the first frame update
    void Start()
    {
        targetPosition = transform.position;        // Set the targetPosition to the doors actual starting position which is this.transform.position

        closedPosition = targetPosition;            // Declare the closed position as the initial target position as the game starts with the doors in a closed state
    }

    // Update is called once per frame
    void Update()
    {
        // Animation using LERP to move the doors current position to the target position 
        transform.position = Vector3.Lerp(transform.position, targetPosition, Time.deltaTime * speed);
    }

    // Custom method to change the doors target position to the lowered position
    public void LowerDoor() {
        targetPosition = loweredPosition;
    }


    // Custom method to change the doors target position to the closed position
    public void CloseDoor() {
        targetPosition = closedPosition;
    }

}
