using UnityEngine;
using UnityEngine.SceneManagement;


public class PlayerHealth : MonoBehaviour
{
    public int health = 3; 
    public string debut;


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