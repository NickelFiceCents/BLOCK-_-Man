using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ErrorScript : MonoBehaviour
{
    
    void Start()
    {
        StartCoroutine(Error());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator Error()
    {
        yield return new WaitForSeconds(1);

        this.enabled = true;
    }
}
