using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class inCaseCollisionBall: MonoBehaviour
{
    //public NuitrackAvatar script;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "sphere")
        {
            Debug.Log("funziona");
            Destroy(collision.gameObject);
        }
    }
}