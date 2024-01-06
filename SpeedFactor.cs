using System.Collections;
using System.Collections.Generic

public class SpeedTrigger : MonoBehavior
{
    public float speedFactor = 2.5f;

    void OnTriggerEnter(Collider other)
    {
        //Increasing the player's running speed =
        othe.GetComponent<FirstPersonMovement>() .runSpeed *=speedFactor;
    }