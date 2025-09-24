using Unity.VisualScripting;
using UnityEngine;

public class Tiro : MonoBehaviour
{
    public float speed = 10f;
    public float maxDistance = 6f;

    void Update()
    {
        transform.Translate(Vector2.up * speed * Time.deltaTime);

        if (transform.position.y > maxDistance)
        {
            Destroy(gameObject);
        }    
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Invader"))
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }
}
