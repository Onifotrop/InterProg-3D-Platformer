using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disable : MonoBehaviour
{
    void Start()
    {
        throw new NotImplementedException();
    }

    void Update()
    {
        StartCoroutine(disableThis());
    }
    
    IEnumerator disableThis()
    {
        // suspend execution for 5 seconds
        yield return new WaitForSeconds(1);
        this.gameObject.SetActive(false);
    }
}
