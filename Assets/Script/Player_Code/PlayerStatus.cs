using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PlayerStatus : MonoBehaviour
{
    public int Health = 100;
    public Text text;
    public GameObject menuMort;


    // Start is called before the first frame update
    void Start()
    {
        menuMort.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        if (Health <= 0)
        {
            menuMort.SetActive(true);
        }
        text.text = Health.ToString();

    }

    public void PlayerLostHealth(int degats)
    {
        Health = Health - degats;
    }

    public void PlayerWinHealth(int heal)
    {
        Health = Health + heal;
    }

}
