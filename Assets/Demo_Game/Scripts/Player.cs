using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Vector3 targetPosition;
    public Vector3 buildingPosition; 
    
    // Start is called before the first frame update
    void Start()
    {
        // Initialising (setting) the initial coordinates of the target position to be the same as the Players starting position
        targetPosition = this.transform.position; 
    }

    // Update is called once per frame
    void Update()
    {
        //transform.position = Vector3.Lerp(transform.position, targetPosition, Time.deltaTime);
    }

    public void EnteredBuilding() {
        targetPosition = buildingPosition; 
    }

}
