using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public Transform car;
    public Transform flag;
    public TextMeshProUGUI distance;
    void Start()
    {
        // car = GameObject.Find("car");
    }

    void Update()
    {
        float length = flag.transform.position.x - car.transform.position.x;
        //distance.GetComponent<TextMeshProUGUI>().text = "Distance : " + length.ToString("F2") + "m";
        distance.text = "Distance : " + length.ToString("F2") + "m";
    }
}
