using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleporter : MonoBehaviour
{
    public GameObject player;
    
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player"); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Teleport() {
        player.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z - 2f);
    }

}
