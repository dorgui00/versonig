using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float lifetime = 1f;  
    public int damage = 1;       

    private void Start()
    {
        Destroy(gameObject, lifetime);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        
        if (other.CompareTag("Player"))
        {
            Debug.Log("je touche lénemi");
            
            PlayerHealth playerHealth = other.GetComponent<PlayerHealth>();  
            if (playerHealth != null)
            {
                playerHealth.TakeDamage(damage);  
            }

            
            Destroy(gameObject);
        }
    }
}