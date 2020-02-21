using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public Rigidbody rb;

    public float forwardForce = 2000f;

    // We are using the physics system
    // Update is called once per frame
    void FixedUpdate()
    {
        // Add a forward force
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);
        {

        }
    }
}
