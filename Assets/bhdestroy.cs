using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bhdestroy : MonoBehaviour
{
    public float life = 10.0f;

    float time = 0f;

    // Start is called before the first frame update
    void Start()
    {
        time = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        print(time);
        if (life < time)
        {
            Destroy(this.gameObject);
        }
    }
}
