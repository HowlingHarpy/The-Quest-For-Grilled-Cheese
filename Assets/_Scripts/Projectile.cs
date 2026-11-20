using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float speed = 20f;
    public int damage = 25;
    public float lifetime = 5f;

    void Start()
    {
        // Destroy projectile after a few seconds
        Destroy(gameObject, lifetime);

        // Give projectile forward velocity
        Rigidbody rb = GetComponent<Rigidbody>();

        if (rb != null)
        {
            rb.linearVelocity = transform.forward * speed;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Projectile hit: " + collision.gameObject.name);

        // Look for an enemy
        EnemyHealth enemy = collision.gameObject.GetComponent<EnemyHealth>();

        if (enemy != null)
        {
            enemy.TakeDamage(damage);
        }

        // Destroy projectile when it hits something
        Destroy(gameObject);
    }
}