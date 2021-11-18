using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{

    private Vector3 targetPosition;

    public Vector3 loweredPosition;
    private Vector3 closedPosition; 

    public float speed = 1.5f;

    
    // Start is called before the first frame update
    void Start()
    {
        // Set the private variable (targetPosition) to the doors actual starting position which is Transform.position
        targetPosition = transform.position;

        // Declare the closed position as the initial target position
        closedPosition = targetPosition;  

    }

    // Update is called once per frame
    void Update()
    {
        // Animation using LEPR to move the doors current position to the target position 
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
