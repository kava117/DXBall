using UnityEngine;
public class Ball : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody2D rb;
    public float speed;
    public Vector2 direction;
    public int brickCount;
    private ScoreManager score;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        direction = Vector2.one.normalized; //(1,1)
        score = GameObject.FindGameObjectWithTag("Logic").GetComponent<ScoreManager>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.linearVelocity = direction * speed;
    }

    void OnTriggerEnter2D(Collider2D collison)
    {
        if (collison.gameObject.CompareTag("Paddle") || collison.gameObject.CompareTag("Ceiling"))
            direction.y = -direction.y;
        else if (collison.gameObject.CompareTag("Wall"))
            direction.x = -direction.x;
        else if (collison.gameObject.CompareTag("Floor"))
        {
            Debug.Log("Game Over!");
            gameObject.SetActive(false);
            score.AddScore(0);
        }
        else
        {
            direction.y = -direction.y;
            Destroy(collison.gameObject);
            brickCount++;
            Debug.Log("Brick Count: " + brickCount);
            score.AddScore(1);
        }
            
    }
    
}