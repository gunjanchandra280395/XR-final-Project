using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube3Detection : MonoBehaviour
{
    public static bool isCube3Inside;
    // Start is called before the first frame update
    void Start()
    {
        isCube3Inside = false;
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerStay(Collider other)
    {
        //Debug.Log("Cube1 is inside");
        //Debug.Log(other.gameObject.name);
        if (other.gameObject.name == "Cube (3)")
            isCube3Inside = true;
    }

    private void OnTriggerExit(Collider other)
    {
        //Debug.Log("Cube left the zone");
        if (other.gameObject.name == "Cube (3)")
            isCube3Inside = false;
    }
}
