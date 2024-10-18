using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class PlayerHealth : MonoBehaviour
{
    public int health = 3; 
    public string debut;

    public Image Coeur1;
    public Image Coeur2;
    public Image Coeur3;

    void Update()
    {
        if(health == 3)
        {
            Coeur1.enabled = true;
            Coeur2.enabled = true;
            Coeur3.enabled = true;
        }
        if (health == 2)
        {
            Coeur1.enabled = true;
            Coeur2.enabled = true;
            Coeur3.enabled = false;
        }
        if (health == 1)
        {
            Coeur1.enabled = true;
            Coeur2.enabled = false;
            Coeur3.enabled = false;
        }
    }

    public void TakeDamage(int damage)
    {
        health -= damage;
        Debug.Log("Joueur reçoit des dégâts! Points de vie restants: " + health);

        if (health <= 0)
        {
            SceneManager.LoadScene(debut);
            Die();  
        }
    }

    private void Die()
    {
        Debug.Log("Le joueur est mort !");
        Destroy(gameObject);
    }
}