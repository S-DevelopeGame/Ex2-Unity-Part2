using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyCar : MonoBehaviour
{
    [Tooltip("Choose time that Cars will destroy")]
    [SerializeField] private int timeDestroyCar;
    void Start()
    {
        this.StartCoroutine(destroyCar());
    }
    private IEnumerator destroyCar()
    {
        while (true)
        {
           
            yield return new WaitForSeconds(timeDestroyCar);
            Destroy(this.gameObject);
        }
    }
}
