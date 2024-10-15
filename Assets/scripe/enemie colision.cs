using UnityEngine;

public class EnemyCollision : MonoBehaviour
{
    public int damage = 1;  // D�g�ts inflig�s au joueur lorsqu'il est touch� par l'ennemi

    // Lorsque l'ennemi entre en collision avec un autre objet (ici le joueur)
    private void OnTriggerEnter2D(Collider2D other)
    {
        // V�rifier si l'objet touch� est le joueur
        if (other.CompareTag("Player"))
        {
            // R�cup�rer le script PlayerHealth du joueur
            PlayerHealth playerHealth = other.GetComponent<PlayerHealth>();
            if (playerHealth != null)
            {
                playerHealth.TakeDamage(damage);  // Infliger les d�g�ts au joueur
            }

            // D�truire l'ennemi
            Destroy(gameObject);  // L'ennemi est d�truit
        }
    }
}