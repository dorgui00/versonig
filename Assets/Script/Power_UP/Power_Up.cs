using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Power_Up : MonoBehaviour
{

    public int powerUpTirX2 = 0;
    public int powerUpTirX3 = 0;
    public int powerUpTirRapide = 0;
    public float newSpeedMissile = 0;
    //Old speed
    public float oldSpeedMissile = 0f;

    public AttackDIST atkPlayer;

    //time power up
    public float tempsActuel = 0f;
    public float tempsDureePowerUp = 0f;
    public int powerUpOn = 0;


    // Start is called before the first frame update
    void Start()
    {
        oldSpeedMissile = atkPlayer.speedMissile;
    }

    // Update is called once per frame
    void Update()
    {
        if(powerUpOn == 1)
        {
            CountUp();
        }

        if(tempsActuel >= tempsDureePowerUp)
        {
            tempsActuel = 0f;
            powerUpTirX2 = 0;
            powerUpTirX3 = 0;
            powerUpTirRapide = 0;
            atkPlayer.speedMissile = oldSpeedMissile;
            atkPlayer.LVL = 0;
            powerUpOn = 0;
        }

    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") && powerUpTirX2 == 1)
        {
            powerUpTirX3 = 0;
            powerUpTirRapide = 0;
            atkPlayer.LVL = 1;
            powerUpOn = 1;
        }

        if (collision.CompareTag("Player") && powerUpTirX3 == 1)
        {
            powerUpTirX2 = 0;
            powerUpTirRapide = 0;
            atkPlayer.LVL = 2;     
            powerUpOn = 1;
        }

        if (collision.CompareTag("Player") && powerUpTirRapide == 1)
        {
            powerUpTirX2 = 0;
            powerUpTirX3 = 0;
            atkPlayer.speedMissile = newSpeedMissile;
            powerUpOn = 1;
        }
    }

    void CountUp()
    {
        tempsActuel += 1 * Time.deltaTime;
    }
}
