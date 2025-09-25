using UnityEngine;

public class TiroInvader : MonoBehaviour
{
    public float speed = 10f;
    public float maxDistance = -6f;

    void Update()
    {
        transform.Translate(Vector2.down * speed * Time.deltaTime);

        if (transform.position.y < maxDistance)
        {
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Destroy(gameObject);
            GameManager.LoseLife();
        }
    }
}
