using UnityEngine;

public class Ciclo : MonoBehaviour
{
    private float hours = 0.1f;
    public int cycleSpeed = 1;

    void FixedUpdate()
    {
        hours++;
        transform.rotation = Quaternion.Euler(hours * cycleSpeed * Time.deltaTime, 0, 0);
    }

    void Sun()
    {
        //transform --> variable
        //variable++;
        //variable --> transform

        
    }
}
