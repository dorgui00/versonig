using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VICTOIRE : MonoBehaviour
{

    public GameObject menuVictoire;

    // Start is called before the first frame update
    void Start()
    {
            menuVictoire.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            menuVictoire.SetActive(true);
        }
    }
}
