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
            player.transform.position = MoveY(player.transform, _currentSpeed);
        if (Input.GetKey(KeyCode.A))
            player.transform.position = MoveX(player.transform, -_currentSpeed);
        if (Input.GetKey(KeyCode.S))
            player.transform.position = MoveY(player.transform, -_currentSpeed);
        if (Input.GetKey(KeyCode.D))
            player.transform.position = MoveX(player.transform, _currentSpeed);
    }

    private Vector2 MoveX(Transform transform, float velocity)
    {
        return new Vector2(transform.position.x + (Time.deltaTime * velocity), transform.position.y);
    }

    private Vector2 MoveY(Transform transform, float velocity)
    {
        return new Vector2(transform.position.x, transform.position.y + (Time.deltaTime * velocity));
    }
}