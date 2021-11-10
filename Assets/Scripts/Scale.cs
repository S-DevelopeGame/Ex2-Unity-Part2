using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scale : MonoBehaviour
{

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        transform.localScale = new Vector3(Mathf.Abs(Mathf.Sin(Time.time)), Mathf.Abs(Mathf.Sin(Time.time)), 0);
    }
}
