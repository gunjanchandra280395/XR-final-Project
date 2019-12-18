using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TableRiddle : MonoBehaviour
{
    private bool cube1OK;
    private bool cube2OK;
    private bool cube3OK;
    private bool cube4OK;
    public bool riddleSolved;
    public Rigidbody rb;
    public float thrust = 1.0f;
    GameObject key;
    // Start is called before the first frame update
    void Start()
    {
        cube1OK = false;
        cube2OK = false;
        cube3OK = false;
        cube4OK = false;
        rb = GetComponent<Rigidbody>();
        riddleSolved = false;
        key = GameObject.Find("key_gold");
    }

    // Update is called once per frame
    void Update()
    {
        cube1OK = Cube1Detection.isCube1Inside;
        cube2OK = Cube2Detection.isCube2Inside;
        cube3OK = Cube3Detection.isCube3Inside;
        cube4OK = Cube4Detection.isCube4Inside;

        if(cube1OK)// && cube2OK && cube3OK && cube4OK)
        {
            riddleSolved = true;
        }

        if (riddleSolved)
        {
            /*
            this.GetComponent<BoxCollider>().isTrigger = true;
            this.GetComponent<MeshCollider>().enabled = false;
            rb.useGravity = false;
            rb.isKinematic = false;
            rb.AddForce(0,1,1);
            */
            Rigidbody rKey = key.AddComponent<Rigidbody>();
            rKey.mass = 5;
            rKey.useGravity = true;

            Debug.LogWarning("Done");
        }
    }
}
