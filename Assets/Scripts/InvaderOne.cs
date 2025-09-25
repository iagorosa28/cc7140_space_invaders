using UnityEngine;

public class InvaderOne : MonoBehaviour
{
    private Rigidbody2D rb2d;
    private float timer = 0.0f;
    private float waitTime = 1.0f;
    private float speed = 2.0f;

    public GameObject tiroInvaderPrefab;
    public Transform firePoint;

    private void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();

        var vel = rb2d.linearVelocity;
        vel.x = speed;
        rb2d.linearVelocity = vel;
    }
    
    private void Update()
    {
        timer += Time.deltaTime;
        if (timer >= waitTime)
        {
            ChangeState();
            timer = 0.0f;

            int n = Random.Range(0, 2);
            if (n == 1)
            {
                Instantiate(tiroInvaderPrefab, firePoint.position, Quaternion.identity);
            }
        }
    }

    void ChangeState()
    {
        var vel = rb2d.linearVelocity;
        vel.x *= -1;
        rb2d.linearVelocity = vel;
    }
}
