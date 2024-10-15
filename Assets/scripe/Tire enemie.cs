using System.Collections;
using UnityEngine;

public class EnemyShooter : MonoBehaviour
{
    public GameObject projectilePrefab; // Le prefab du projectile
    public float shootInterval = 2f;    // Intervalle entre chaque tir
    public float projectileSpeed = 5f;  // Vitesse du projectile

    private void Start()
    {
        // Commence � tirer apr�s un certain d�lai
        StartCoroutine(ShootProjectiles());
    }

    private IEnumerator ShootProjectiles()
    {
        while (true)
        {
            // Attendre l'intervalle d�fini avant de tirer
            yield return new WaitForSeconds(shootInterval);

            // Cr�er un projectile � la position de l'ennemi
            GameObject projectile = Instantiate(projectilePrefab, transform.position, Quaternion.identity);

            // R�cup�rer la direction (vers le bas) et appliquer la vitesse
            Rigidbody2D rb = projectile.GetComponent<Rigidbody2D>();
            if (rb != null)
            {
                rb.velocity = Vector2.down * projectileSpeed;
            }
        }
    }
}
