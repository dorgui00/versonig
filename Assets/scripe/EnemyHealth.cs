using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int health = 3;  // Points de vie de l'ennemi

    // Cette fonction est appelée pour infliger des dégâts à l'ennemi
    public void TakeDamage(int damage)
    {
        health -= damage;  // Réduire les points de vie de l'ennemi

        // Si les points de vie sont inférieurs ou égaux à zéro, détruire l'ennemi
        if (health <= 0)
        {
            Die();
        }
    }

    // Gérer la mort de l'ennemi
    private void Die()
    {
        // Ici, tu peux ajouter des effets (comme une animation, un son, ou une explosion).
        // Par exemple, on peut détruire l'ennemi :
        Destroy(gameObject);  // L'ennemi est détruit

        // Si tu veux ajouter un effet de mort (explosion, particules, etc.), tu peux l'ajouter ici.
    }
}