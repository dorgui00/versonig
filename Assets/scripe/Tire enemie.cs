using System.Collections;
using UnityEngine;

public class EnemyShooter : MonoBehaviour
{
    public GameObject projectilePrefab;
    public float shootInterval = 2f;    
    public float projectileSpeed = 5f;  

    private void Start()
    {
        StartCoroutine(ShootProjectiles());
    }

    private IEnumerator ShootProjectiles()
    {
        while (true)
        {
           
            yield return new WaitForSeconds(shootInterval);

           
            GameObject projectile = Instantiate(projectilePrefab, transform.position, Quaternion.identity);

            
            Rigidbody2D rb = projectile.GetComponent<Rigidbody2D>();
            if (rb != null)
            {
                rb.velocity = Vector2.down * projectileSpeed;
            }
        }
    }
}
