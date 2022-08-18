using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    public float speed = 20f;
    public float destroyTime = 4f;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("destroyDelay", destroyTime);
    }

    // Update is called once per frame
    void Update()
    {
        move();
    }

    private void move()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
    private void destroyDelay()
    {
        Destroy(gameObject);
    }
}
