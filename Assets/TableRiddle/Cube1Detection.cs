using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube1Detection : MonoBehaviour
{
    public static bool isCube1Inside;
    // Start is called before the first frame update
    void Start()
    {
        isCube1Inside = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay(Collider other)
    {
        //Debug.Log("Cube1 is inside");
        //Debug.Log(other.gameObject.name);
        //Debug.LogWarning("Cube1 is inside");
        if (other.gameObject.name == "Cube (1)")
        {
            isCube1Inside = true;
            //Debug.LogWarning("Cube1 is inside");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        //Debug.Log("Cube left the zone");
        if (other.gameObject.name == "Cube (1)")
            isCube1Inside = false;
    }
}
