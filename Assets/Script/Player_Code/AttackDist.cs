using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackDIST : MonoBehaviour
{

    // Ce script permet de tirer tout droit devant soit

    public GameObject projectil;
    public GameObject projectilSave;
    public GameObject projectilSave1;
    public GameObject projectilSave2;
    public GameObject posAttack;
    public GameObject posAttack1;
    public GameObject posAttack2;

    public int LVL = 0;

    public float speedMissile = 0f;

    public float lifeTime = 0f;

    //prochaine attaque
    public float nexAttackTime = 0.5f;
    private bool reloading;


    private SpriteRenderer skin;

    //private Animator anim;

    //public HeroEntity heroEntity;

    // Dans le start on récupère le sprite renderer et l'animator
    void Start()
    {
        skin = GetComponent<SpriteRenderer>();
        //anim = GetComponent<Animator>();
    }


    void Update()
    {
        if (Input.GetMouseButtonDown(1) && !reloading)
        {
            TireEnHaut();
            reloading = true;
            StartCoroutine(NextAttack());
        }

    }

    void TireEnHaut()
    {
        if (LVL == 0)
        {
            // 1. Si le sprite est retourner (donc regarde à droite) 
            projectilSave = Instantiate(projectil, posAttack.transform.position, Quaternion.identity);

            Rigidbody2D rb = projectilSave.GetComponent<Rigidbody2D>();
            // Désactiver la gravité
            rb.gravityScale = 0f;
            // Propulse vers le haut
            rb.velocity = new Vector2(0f, speedMissile);
        }

        if (LVL == 1)
        {
            // 1. Si le sprite est retourner (donc regarde à droite) 
            projectilSave = Instantiate(projectil, posAttack.transform.position, Quaternion.identity);
            projectilSave1 = Instantiate(projectil, posAttack1.transform.position, Quaternion.identity);

            //missile 1
            Rigidbody2D rb = projectilSave.GetComponent<Rigidbody2D>();
            // Désactiver la gravité
            rb.gravityScale = 0f;
            // Propulse vers le haut
            rb.velocity = new Vector2(0f, speedMissile);

            //missile 2
            Rigidbody2D rb1 = projectilSave1.GetComponent<Rigidbody2D>();
            // Désactiver la gravité
            rb1.gravityScale = 0f;
            // Propulse vers le haut
            rb1.velocity = new Vector2(0f, speedMissile);
        }

        if (LVL == 2)
        {
            // 1. Si le sprite est retourner (donc regarde à droite) 
            projectilSave = Instantiate(projectil, posAttack.transform.position, Quaternion.identity);
            projectilSave1 = Instantiate(projectil, posAttack1.transform.position, Quaternion.identity);
            projectilSave2 = Instantiate(projectil, posAttack2.transform.position, Quaternion.identity);

            //missile 1
            Rigidbody2D rb = projectilSave.GetComponent<Rigidbody2D>();
            // Désactiver la gravité
            rb.gravityScale = 0f;
            // Propulse vers le haut
            rb.velocity = new Vector2(0f, speedMissile);

            //missile 2
            Rigidbody2D rb1 = projectilSave1.GetComponent<Rigidbody2D>();
            // Désactiver la gravité
            rb1.gravityScale = 0f;
            // Propulse vers le haut
            rb1.velocity = new Vector2(0f, speedMissile);

            //missile 3
            Rigidbody2D rb2 = projectilSave2.GetComponent<Rigidbody2D>();
            // Désactiver la gravité
            rb2.gravityScale = 0f;
            // Propulse vers le haut
            rb2.velocity = new Vector2(0f, speedMissile);
        }

    }

    // Voici la coroutine waitShoot
    IEnumerator NextAttack()
    {
        yield return new WaitForSeconds(nexAttackTime);
        reloading = false;
    }


}

