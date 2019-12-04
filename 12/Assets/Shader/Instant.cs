using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instant : MonoBehaviour
{
    public int count = 10;
    public Vector2 range;
    public GameObject obj;

    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < count; i++)
        {
            float x = Random.Range(-(range.x / 2), (range.x / 2));
            float z = Random.Range(-(range.y / 2), (range.y / 2));

            Instantiate(obj, new Vector3(x, 0, z), new Quaternion());
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
