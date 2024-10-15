using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int health = 3;  

    
    public void TakeDamage(int damage)
    {
        health -= damage;  

       
        if (health <= 0)
        {
            Die();
        }
    }

    
    private void Die()
    {
       
        Destroy(gameObject);  // L'ennemi est d�truit

        
    }
}