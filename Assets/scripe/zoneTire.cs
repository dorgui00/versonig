using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zoneTire : MonoBehaviour
{
   public EnemyShooter a;
   public EnemyShooter b;
   public EnemyShooter c;
   public EnemyShooter d;
   public EnemyShooter e;
   public EnemyShooter f;
   public EnemyShooter g;
   public EnemyShooter h;
   public EnemyShooter j;
   public EnemyShooter k;
   public EnemyShooter m;
   public EnemyShooter n;
   public EnemyShooter o;
   public EnemyShooter p;
   public EnemyShooter t;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("salut");
            a.TireAuto(); 
            b.TireAuto();
            c.TireAuto();
            d.TireAuto();
            e.TireAuto();
            //f.TireAuto();
            //g.TireAuto(); 
            //h.TireAuto();
            //j.TireAuto(); 
            //k.TireAuto();
            //m.TireAuto();
            //n.TireAuto();
            //o.TireAuto();
            //p.TireAuto();
            //t.TireAuto();
            Debug.Log("salut");
        }
    }
}
