using JetBrains.Annotations;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private PlayerController controller;
    public Rigidbody rigidbody;

    private void Awake()
    {
        controller = new PlayerController();
    }

    private void FixedUpdate()
    {
        if (controller != null && rigidbody != null) 
        {
            if (controller.PlayerMap.Forward.ReadValue<float>() >= 0.5f)
            {
                rigidbody.AddForce(-transform.forward, ForceMode.Impulse);
            }
            if (controller.PlayerMap.Backward.ReadValue<float>() >= 0.5f)
            {
                rigidbody.AddForce(transform.forward, ForceMode.Impulse);
            }
        }
    }

    private void OnEnable()
    {
        controller.Enable();
    }

    private void OnDisable() 
    {
        controller.Disable();
    }
}
