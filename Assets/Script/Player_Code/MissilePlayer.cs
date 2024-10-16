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
            //truc.SendMessage("MonstreRang0LostHealth", degats); 
            Destroy(gameObject);
        }
        //else if (!truc.isTrigger && truc.tag != "Player")
        //{
        //    Destroy(gameObject);
        //}
        
    }

    private void Update()
    {
        Destroy(gameObject, lifeTime);
    }

}
