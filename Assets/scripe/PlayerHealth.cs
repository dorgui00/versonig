using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int health = 3;  // Points de vie du joueur

    // Fonction pour infliger des dégâts au joueur
    public void TakeDamage(int damage)
    {
        health -= damage;
        Debug.Log("Joueur reçoit des dégâts! Points de vie restants: " + health);

        if (health <= 0)
        {
            Die();  // Si les points de vie atteignent zéro, le joueur meurt
        }
    }

    private void Die()
    {
        Debug.Log("Le joueur est mort !");
        Destroy(gameObject);
    }
}