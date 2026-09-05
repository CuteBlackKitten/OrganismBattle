using System;
using UnityEngine;

public class VirusRandomMovement : MonoBehaviour
{
    int ticksCounter = 0;
    public int ticksToMove = 0;
    public Rigidbody Rigidbody;
    System.Random random = new System.Random();
    private int Score;

    public void FixedUpdate()
    {
        ticksCounter += 1;
        if (ticksCounter >= ticksToMove) 
        {
            Rigidbody.AddForce(new Vector3(random.Next(-180, 180), random.Next(-180, 180), random.Next(-180, 180)) * 0.05f, ForceMode.Impulse);
            ticksCounter = 0;
        }
        if (YDetector.GetVirusHealth() <= 0) 
        {
            Score += 1;
            GlobalVariableHolder.SetScore(Score);
            this.enabled = false;
        }
    }
}
