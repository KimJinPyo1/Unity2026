using UnityEngine;

public class ItemGenerator : MonoBehaviour
{
    public GameObject applePrefab;
    public GameObject bombPrefab;

    public float span = 1f;
    float delta = 0f;
    int ratio = 3;

    void Update()
    {
        delta += Time.deltaTime;
        GameObject item;
        if(delta > span)
        {
            int dice = Random.Range(0, 10);
            if(dice < ratio)
            {
                item = Instantiate(applePrefab);
            }
            else
            {
                item = Instantiate(bombPrefab);
            }
            float x = Random.Range(-1, 2);
            float z = Random.Range(-1, 2);
            item.transform.position = new Vector3(x, 7, z);
            delta = 0;
        }
    }
}
