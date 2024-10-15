using UnityEngine;

public class EnemyCollision : MonoBehaviour
{
    public int damage = 1;  

 
    private void OnTriggerEnter2D(Collider2D other)
    {
        
        if (other.CompareTag("Player"))
        {
            
            PlayerHealth playerHealth = other.GetComponent<PlayerHealth>();
            if (playerHealth != null)
            {
                playerHealth.TakeDamage(damage);  
            }

          
            Destroy(gameObject);  
        }
    }
}