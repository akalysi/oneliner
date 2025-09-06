using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JACKPOT : MonoBehaviour
{
    private GameObject child;
    private void Start()
    {
        child = transform.GetChild(0).gameObject;
        child.gameObject.SetActive(false);
    }

    private void OisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            child.gameObject.SetActive(true);
            child.transform.parent = GameObject.Find("Wins").transform;
            Destroy(gameObject);
        }
    }
}
