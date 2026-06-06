using JetBrains.Annotations;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody Rigidbody;

    private void FixedUpdate()
    {
        if (Input.GetKey("w") || Input.GetKey("up")) 
        {
            Rigidbody.AddForce(-transform.forward, ForceMode.Impulse);
        }
        if (Input.GetKey("s") || Input.GetKey("down"))
        {
            Rigidbody.AddForce(transform.forward, ForceMode.Impulse);
        }
    }
}
