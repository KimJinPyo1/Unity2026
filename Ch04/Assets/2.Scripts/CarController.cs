using System.Security.Cryptography;
using UnityEngine;

public class CarController : MonoBehaviour
{
    float speed = 0.2f;
    Vector2 startPos;

    void Start()
    {
        Application.targetFrameRate = 60;
    }

    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            startPos = Input.mousePosition;
        }
        else if(Input.GetMouseButtonUp(0))
        {
            Vector2 endPos = Input.mousePosition;
            float swipeLen = endPos.x - startPos.x;
            speed = swipeLen / 200f;
            GetComponent<AudioSource>().Play();
        }
            transform.Translate(speed, 0, 0);
        speed *= 0.99f;
    }
}
