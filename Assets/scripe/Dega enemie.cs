using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float lifetime = 1f;  // Durée de vie avant destruction du projectile
    public int damage = 1;       // Nombre de dégâts infligés au joueur

    private void Start()
    {
        // Détruire le projectile après "lifetime" secondes
        Destroy(gameObject, lifetime);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        // Vérifier si l'objet touché est le joueur
        if (other.CompareTag("Player"))
        {
            Debug.Log("je touche lénemi");
            // Si le projectile touche le joueur, infliger des dégâts
            PlayerHealth playerHealth = other.GetComponent<PlayerHealth>();  // Récupérer le script PlayerHealth du joueur
            if (playerHealth != null)
            {
                playerHealth.TakeDamage(damage);  // Appliquer les dégâts au joueur
            }

            // Détruire le projectile après l'impact
            Destroy(gameObject);
        }
    }
}