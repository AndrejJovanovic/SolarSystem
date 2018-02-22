using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

    public GameObject defaultPlayer;

    private GameObject player;
    private Vector3 offset;

    private void Start()
    {
        player = defaultPlayer;
        offset = transform.position - player.transform.position;
    }

    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
        if (gameObject.GetComponent<ButtonManager>().GetIsChanged())
        {
            player = gameObject.GetComponent<ButtonManager>().GetPlanet();
            transform.position = player.transform.position + new Vector3(0,0,-8);
        }
    }
}
