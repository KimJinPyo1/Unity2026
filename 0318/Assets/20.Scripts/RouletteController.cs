using System.Security.Cryptography;
using UnityEngine;

public class RouletteController : MonoBehaviour
{
    float rotSpeed = 0f;
    void Start()
    {
        Application.targetFrameRate = 60;
    }

    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            rotSpeed = 10f;
        }
        transform.Rotate(0, 0, rotSpeed);
         
    }
}
