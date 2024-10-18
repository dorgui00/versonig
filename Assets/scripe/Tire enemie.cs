using System.Collections;
using UnityEngine;

public class EnemyShooter : MonoBehaviour
{
    public GameObject projectilePrefab;
    public GameObject ZoneTire;
    public float shootInterval = 2f;
    public float projectileSpeed = 5f;

    private bool canShoot = false;

    // Reference to the Animator component
    private Animator animator;

    private void Start()
    {
        // Get the Animator component from the GameObject
        animator = GetComponent<Animator>();

        // Start shooting projectiles
        StartCoroutine(ShootProjectiles());
    }

    private void Update()
    {
        // Optional: You could check for player proximity or other conditions here
    }

    private IEnumerator ShootProjectiles()
    {
        while (true)
        {
            // Wait for the shoot interval only if canShoot is true
            if (canShoot)
            {
                // Trigger shooting animation
                if (animator != null)
                {
                    animator.SetTrigger("Shoot");
                }

                yield return new WaitForSeconds(shootInterval);

                // Instantiate and shoot the projectile
                GameObject projectile = Instantiate(projectilePrefab, transform.position, Quaternion.identity);
                Rigidbody2D rb = projectile.GetComponent<Rigidbody2D>();
                if (rb != null)
                {
                    rb.velocity = Vector2.down * projectileSpeed;
                }
            }
            else
            {
                yield return null; // Wait until canShoot becomes true
            }
        }
    }

    // Enable shooting (can be called from other scripts or events)
    public void TireAuto()
    {
        canShoot = true;
    }
}