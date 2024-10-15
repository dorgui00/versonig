using UnityEngine;

public class EnemyCollision : MonoBehaviour
{
    public int damage = 1;  // Dégâts infligés au joueur lorsqu'il est touché par l'ennemi

    // Lorsque l'ennemi entre en collision avec un autre objet (ici le joueur)
    private void OnTriggerEnter2D(Collider2D other)
    {
        // Vérifier si l'objet touché est le joueur
        if (other.CompareTag("Player"))
        {
            // Récupérer le script PlayerHealth du joueur
            PlayerHealth playerHealth = other.GetComponent<PlayerHealth>();
            if (playerHealth != null)
            {
                playerHealth.TakeDamage(damage);  // Infliger les dégâts au joueur
            }

            // Détruire l'ennemi
            Destroy(gameObject);  // L'ennemi est détruit
        }
    }
}