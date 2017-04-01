using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject player;
    public float baseSpeed;
    private float _currentSpeed;
    // Use this for initialization
    void Start ()
    {
        player = gameObject;
        baseSpeed = 25;
    }

    // Update is called once per frame
    void Update ()
    {
        _currentSpeed = Input.GetKey(KeyCode.LeftShift) ? baseSpeed * 2 : baseSpeed * 1;

        if (Input.GetKey(KeyCode.W))
            player.transform.position = new Vector2(player.transform.position.x, player.transform.position.y + (Time.deltaTime * _currentSpeed));
        if (Input.GetKey(KeyCode.A))
            player.transform.position = new Vector2(player.transform.position.x - (Time.deltaTime * _currentSpeed), player.transform.position.y);
        if (Input.GetKey(KeyCode.S))
            player.transform.position = new Vector2(player.transform.position.x, player.transform.position.y - (Time.deltaTime * _currentSpeed));
        if (Input.GetKey(KeyCode.D))
            player.transform.position = new Vector2(player.transform.position.x + (Time.deltaTime * _currentSpeed), player.transform.position.y);
    }
}