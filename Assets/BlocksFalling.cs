using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlocksFalling : MonoBehaviour
{

    float speed;
    public Vector2 speedMinMax;

    float visibleHeightThreshold;

    void Start()
    {
        speed = Mathf.Lerp(speedMinMax.x, speedMinMax.y, Difficulty.GetDifficultyPerecent());

        visibleHeightThreshold = -Camera.main.orthographicSize - transform.localScale.y;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.down * speed * Time.deltaTime, Space.Self);

        if(transform.position.y < visibleHeightThreshold)
        {
            Destroy(gameObject);
        }
    }
}
