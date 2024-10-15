using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int health = 3;  // Points de vie du joueur

    // Fonction pour infliger des d�g�ts au joueur
    public void TakeDamage(int damage)
    {
        health -= damage;
        Debug.Log("Joueur re�oit des d�g�ts! Points de vie restants: " + health);

        if (health <= 0)
        {
            Die();  // Si les points de vie atteignent z�ro, le joueur meurt
        }
    }

    private void Die()
    {
        Debug.Log("Le joueur est mort !");
        Destroy(gameObject);
    }
}