using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int health = 3;  // Points de vie de l'ennemi

    // Cette fonction est appel�e pour infliger des d�g�ts � l'ennemi
    public void TakeDamage(int damage)
    {
        health -= damage;  // R�duire les points de vie de l'ennemi

        // Si les points de vie sont inf�rieurs ou �gaux � z�ro, d�truire l'ennemi
        if (health <= 0)
        {
            Die();
        }
    }

    // G�rer la mort de l'ennemi
    private void Die()
    {
        // Ici, tu peux ajouter des effets (comme une animation, un son, ou une explosion).
        // Par exemple, on peut d�truire l'ennemi :
        Destroy(gameObject);  // L'ennemi est d�truit

        // Si tu veux ajouter un effet de mort (explosion, particules, etc.), tu peux l'ajouter ici.
    }
}