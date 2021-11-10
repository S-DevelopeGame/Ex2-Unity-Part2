using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [Tooltip("the speed move")]
    [SerializeField] private float speed;

    [Tooltip("true - move to left, false move to right")]
    [SerializeField] private bool moveToLeft;
    // Start is called before the first frame update
    void Start()
    {
        if (!moveToLeft)
            transform.localScale *= -1;
    }

    // Update is called once per frame
    void Update()
    {
        if(moveToLeft)
        {
            transform.position += Vector3.left * Time.deltaTime * speed;
        }
        else
        {
            transform.position += Vector3.right * Time.deltaTime * speed;
        }
            
    }
}
