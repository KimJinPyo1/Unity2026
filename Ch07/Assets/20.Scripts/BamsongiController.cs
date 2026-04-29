using UnityEngine;

public class BamsongiController : MonoBehaviour
{
    void Start()
    {
        Application.targetFrameRate = 60;
        Shoot(new Vector3(0, 200, 2000));
    }

    void Update()
    {
        
    }

    public void Shoot(Vector3 dir)
    {
        GetComponent<Rigidbody>().AddForce(dir);
    }
}
