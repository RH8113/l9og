using System.Collections;
using System.Runtime.InteropServices;
using System.Threading;
using UnityEngine;



public class balldestroy : MonoBehaviour
{
    public float life = 3.0f;
    float time = 0f;


    void start()
    {
        time = 0f;
       
    }

    void Update()
    {
        time += Time.deltaTime;
        print(time);
        if(life < time)
        {
            Destroy(this.gameObject);
        }

        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        

        if (other.gameObject.tag == "whiteheartTag")
        {
            Destroy(other.gameObject);
            
        }
    }


}   
