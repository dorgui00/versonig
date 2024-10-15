using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float lifetime = 1f;  // Dur�e de vie avant destruction du projectile
    public int damage = 1;       // Nombre de d�g�ts inflig�s au joueur

    private void Start()
    {
        // D�truire le projectile apr�s "lifetime" secondes
        Destroy(gameObject, lifetime);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        // V�rifier si l'objet touch� est le joueur
        if (other.CompareTag("Player"))
        {
            Debug.Log("je touche l�nemi");
            // Si le projectile touche le joueur, infliger des d�g�ts
            PlayerHealth playerHealth = other.GetComponent<PlayerHealth>();  // R�cup�rer le script PlayerHealth du joueur
            if (playerHealth != null)
            {
                playerHealth.TakeDamage(damage);  // Appliquer les d�g�ts au joueur
            }

            // D�truire le projectile apr�s l'impact
            Destroy(gameObject);
        }
    }
}