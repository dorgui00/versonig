using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class MissilePlayer : MonoBehaviour
{

    public int degats = 1;
    public float lifeTime = 5.0f;
    public static int levelFireBall = 1;


    // La fonction OnTriggerEnter s'enclenche quand votre Trigger touche un autre collider/trigger
    void OnTriggerEnter2D(Collider2D truc)
    {
        if (truc.tag == "Enemy")
        {                 // Si le truc qu'on touche a le tag "Ennemi"
            //truc.SendMessage("MonstreRang0LostHealth", degats); // On cherche sur lui une fonction qui s'appel "takeDamage", et on la lance en lui donnant le nombre de dégat qu'on fait
            Destroy(gameObject);
        }
        //else if (!truc.isTrigger && truc.tag != "Player")
        //{
        //    Destroy(gameObject);
        //}
        Destroy(gameObject, 10);
    }

    private void Update()
    {
        if (levelFireBall == 1)
        {
            degats = 1;
        }

        if (levelFireBall == 2)
        {
            degats = 10;
        }

        if (levelFireBall == 3)
        {
            degats = 50;
        }
    }

}
