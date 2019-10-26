using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipe : MonoBehaviour
{
    public float speed = 3;
    public float life = 10;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(-speed, 0, 0) * Time.deltaTime;
        life -= Time.deltaTime;
        if (life <= 0)
        {
            Destroy(gameObject);
        }
    }
}
