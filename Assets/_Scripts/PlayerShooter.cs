using UnityEngine;

public class PlayerShooter : MonoBehaviour
{
    [Header("Shooting")]
    public GameObject projectilePrefab;
    public Transform firePoint;

    public float fireRate = 0.3f;

    private float nextFireTime = 0f;

    void Update()
    {
        if (Input.GetMouseButton(0) && Time.time >= nextFireTime)
        {
            Shoot();

            nextFireTime = Time.time + fireRate;
        }
    }

    void Shoot()
    {
        if (projectilePrefab == null)
        {
            Debug.LogWarning("Projectile Prefab has not been assigned!");
            return;
        }

        if (firePoint == null)
        {
            Debug.LogWarning("Fire Point has not been assigned!");
            return;
        }

        // Create projectile
        Instantiate(
            projectilePrefab,
            firePoint.position,
            firePoint.rotation
        );
    }
}