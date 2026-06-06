using UnityEngine;

public class ShootingY : MonoBehaviour
{
    public GameObject Y;
    public Transform Shooter1;
    public Transform Shooter2;
    private bool isLeftShooter = true;

    private void FixedUpdate()
    {
        if (Input.GetMouseButton(0))
        {
            if (isLeftShooter)
            {
                GameObject bullet = Instantiate(Y, Shooter1.position, Quaternion.identity);
                bullet.GetComponent<Rigidbody>().AddForce(transform.forward * -100f, ForceMode.Impulse);
                Destroy(bullet, 5f);
                isLeftShooter = false;
            }
            else
            {
                GameObject bullet = Instantiate(Y, Shooter2.position, Quaternion.identity);
                bullet.GetComponent<Rigidbody>().AddForce(transform.forward * -100f, ForceMode.Impulse);
                Destroy(bullet, 5f);
                isLeftShooter = true;
            }
        }
    }
}
