using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float jumpForce = 600f;
    public float walkForce = 30f;
    public float maxWalkSpeed = 2f;

    public Sprite[] walkSprites;
    public float animationPeriod = 0.1f;
    float time = 0;
    int idx = 0;

    SpriteRenderer sr;
    Rigidbody2D rb;
    void Start()
    {
        Application.targetFrameRate = 60;
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            rb.AddForce(transform.up * jumpForce);
        }
        
        if(rb.linearVelocityX < maxWalkSpeed)
        {
            rb.AddForce(transform.right * walkForce);
        }

        time += Time.deltaTime;
        if(time > animationPeriod)
        {
            time = 0;
            sr.sprite = walkSprites[idx];
            idx++;
            if(idx == walkSprites.Length)
            {
                idx = 0;
            }
        }
    }
}
