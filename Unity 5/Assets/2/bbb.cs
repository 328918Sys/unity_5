using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bbb : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject player;
    private Vector3 offset;

    void Start()
    {
        offset = transform.position -  player.transform.position;

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = player.transform.position + offset;

    }
}
