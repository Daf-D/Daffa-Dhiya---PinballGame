using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LauncherController : MonoBehaviour
{
    public Collider Ball;
    public KeyCode input;
    public float force;

    // Start is called before the first frame update
    private void OnCollisionStay(Collision collision)
    {
        if (collision.collider == Ball)
        {
            ReadInput(Ball);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void ReadInput(Collider collider)
    {
        if (Input.GetKey(input))
        {
            collider.GetComponent<Rigidbody>().AddForce(Vector3.forward * force);
        }
    }
}
