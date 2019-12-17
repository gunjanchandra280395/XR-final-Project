using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube4Detection : MonoBehaviour
{
    public static bool isCube4Inside;
    // Start is called before the first frame update
    void Start()
    {
        isCube4Inside = false;
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerStay(Collider other)
    {
        //Debug.Log("Cube1 is inside");
        //Debug.Log(other.gameObject.name);
        if (other.gameObject.name == "Cube (4)")
        {
            isCube4Inside = true;
            //Debug.Log("cub4");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        //Debug.Log("Cube left the zone");
        if (other.gameObject.name == "Cube (4)")
            isCube4Inside = false;
    }
}
