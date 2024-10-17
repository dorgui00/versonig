using System.Collections;
using UnityEngine;

public class EnemyShooter : MonoBehaviour
{
    public GameObject projectilePrefab;
    public GameObject ZoneTire;
    public float shootInterval = 2f;
    public float projectileSpeed = 5f;

    private bool canShoot = false;

    private void Start()
    {
        StartCoroutine(ShootProjectiles());
    }

    private void Update()
    {
        // Optional: You could check for player proximity here, if needed
    }

    private IEnumerator ShootProjectiles()
    {
        while (true)
        {
            // Wait for the shoot interval only if canShoot is true
            if (canShoot)
            {
                yield return new WaitForSeconds(shootInterval);

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

    public void TireAuto()
    {
        canShoot = true;
    }
    
}
