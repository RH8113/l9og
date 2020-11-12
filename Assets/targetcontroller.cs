using System.Collections;
using UnityEngine;

public class targetcontroller : MonoBehaviour
{
    public GameObject blackheartprefab;
    public GameObject whiteheartprefab;
    public float xMinPosition = -6.5f;
    public float xMaxPosition = 6.5f;
    public float yMinPosition = -4f;
    public float yMaxPosition = 4f;
    private float interval;
    private float time = 0f;

    // Start is called before the first frame update
    void Start()
    {
        interval = 5f;
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;

        if(time > interval)
        {
            GameObject whiteheart = Instantiate(whiteheartprefab);
            GameObject blackheart = Instantiate(blackheartprefab);
            transform.position = GetRandomPosition();
            time = 0f;
        }

    }


    private Vector2 GetRandomPosition()
    {
        float x = Random.Range(xMinPosition, xMaxPosition);
        float y = Random.Range(yMinPosition, yMaxPosition);
        return new Vector2(x, y);
    } 
}
