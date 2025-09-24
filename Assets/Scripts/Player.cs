using UnityEngine;

public class Player : MonoBehaviour
{
    public KeyCode moveLeft = KeyCode.LeftArrow;
    public KeyCode moveRight = KeyCode.RightArrow;
    public float speed = 5.0f;
    public float boundX = 8.5f;

    public GameObject tiroPrefab;
    public Transform firePoint;


    private Rigidbody2D rb2d;
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        float direction = 0.0f;
        if(Input.GetKey(moveLeft))
        {
            direction = -1.0f;
        }
        else if (Input.GetKey(moveRight))
        {
            direction = 1.0f;
        }

        var velocidade = rb2d.linearVelocity;
        velocidade.x = direction * speed;
        rb2d.linearVelocity = velocidade;

        var posicao = transform.position;
        posicao.x = Mathf.Clamp(posicao.x, -boundX, boundX);
        transform.position = posicao;

        if(Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(tiroPrefab, firePoint.position, Quaternion.identity);
        }
    }
}
