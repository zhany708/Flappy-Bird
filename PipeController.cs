using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class PipeController : MonoBehaviour
{
    public float speed = 2f;
    public float lifetime = 10f;


    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, lifetime);
    }

    // Update is called once per frame
    void Update()
    {
        Moveleft();
    }



    void Moveleft()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);     //使水管从右往左移动
    }
}
