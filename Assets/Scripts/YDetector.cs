using NUnit.Framework.Constraints;
using UnityEngine;

public class YDetector : MonoBehaviour
{
    private int VirusHealth = 30;
    private static int StaticVirusHealth = 30;

    public void OnTriggerEnter(Collider other)
    {
        if (other.transform.root.name == "Y(Clone)")
        {
            other.gameObject.SetActive(false);
            VirusHealth--;
            ChangeStaticVirusHealth(-1);

            if (VirusHealth <= 0)
            {
                transform.parent.GetChild(0).gameObject.SetActive(false);
                transform.parent.GetChild(1).GetChild(0).gameObject.SetActive(true);
                Destroy(transform.parent.gameObject, 5f);
            }
        }
    }

    public static int GetVirusHealth() 
    {
        return StaticVirusHealth;
    }
    public static void ChangeStaticVirusHealth(int value) 
    {
        StaticVirusHealth += value;
    }
}
