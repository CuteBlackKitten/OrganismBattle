using UnityEngine;

public class ShootingY : MonoBehaviour
{
    public GameObject Y;
    public Transform Shooter1;
    public Transform Shooter2;
    private bool isLeftShooter = true;
    private PlayerController controller;

    private void Awake()
    {
        controller = new PlayerController();
    }

    private void FixedUpdate()
    {
        controller.PlayerMap.Shoot.performed += _ => Shoot();
    }

    public void Shoot() 
    {
        if (isLeftShooter)
        {
            GameObject bullet = Instantiate(Y, Shooter1.position, Quaternion.identity);
            bullet.GetComponent<Rigidbody>().AddForce(transform.forward * -50f, ForceMode.Impulse);
            Destroy(bullet, 5f);
            isLeftShooter = false;
        }
        else
        {
            GameObject bullet = Instantiate(Y, Shooter2.position, Quaternion.identity);
            bullet.GetComponent<Rigidbody>().AddForce(transform.forward * -50f, ForceMode.Impulse);
            Destroy(bullet, 5f);
            isLeftShooter = true;
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
