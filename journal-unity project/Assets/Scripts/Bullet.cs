using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 20f;
    private Vector2 direction = Vector2.right;

    void Update()
    {
        // Move the projectile in the set direction
        transform.Translate(direction * speed * Time.deltaTime);
    }

    public void SetDirection(Vector2 newDirection)
    {
        direction = newDirection;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Bullet hit something: " + other.name + " with tag: " + other.tag);

        if (other.CompareTag("TriggerBox"))
        {
            Debug.Log("Bullet hit TriggerBox: " + other.name);
            TriggerBox triggerBox = other.GetComponent<TriggerBox>();
            if (triggerBox != null)
            {
                Debug.Log("TriggerBox script found on: " + other.name);
                triggerBox.TriggerAction(); // Call the method to change color
            }
            Destroy(gameObject); // Destroy the projectile on impact
        }
        else if (other.CompareTag("Environment"))
        {
            Debug.Log("Bullet hit Environment: " + other.name);
            Destroy(gameObject); // Destroy the projectile on hitting environment
        }
    }

}
