using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube2Detection : MonoBehaviour
{
    public static bool isCube2Inside;
    // Start is called before the first frame update
    void Start()
    {
        isCube2Inside = false;
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerStay(Collider other)
    {
        //Debug.Log("Cube1 is inside");
        //Debug.Log(other.gameObject.name);
        if (other.gameObject.name == "Cube (2)")
            isCube2Inside = true;
    }

    private void OnTriggerExit(Collider other)
    {
        //Debug.Log("Cube left the zone");
        if (other.gameObject.name == "Cube (2)")
            isCube2Inside = false;
    }
}
