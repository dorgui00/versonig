using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class PlayerStatus : MonoBehaviour
{
    public int Health = 100;
    public Text text;
    public string debut;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Health <= 0)
        {
           SceneManager.LoadScene(debut);
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
