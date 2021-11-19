using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleporter : MonoBehaviour
{
    public GameObject player;                   // Import the Player (parent of the VRPlayer) GameObject  
    
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");     // Finish the import of the Player GameObject by finding it in the Unity GUI's hierarchy 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Create a custom method to teleport the Player GameObject's position to that of the objet with the Teleporter Script that's been hit
    public void Teleport() {
        player.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z - 2f);
    }

}
