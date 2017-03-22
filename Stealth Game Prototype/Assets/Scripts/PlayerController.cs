using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private GameObject _player;
    private float _moveSpeed;
    // Use this for initialization
    void Start ()
    {
        _player = gameObject;
        _moveSpeed = 5  ;
    }

    // Update is called once per frame
    void Update ()
    {
        _moveSpeed = Input.GetKey(KeyCode.LeftShift) ?  7.5F : 5;

        if (Input.GetKey(KeyCode.W))
            _player.transform.position = new Vector2(_player.transform.position.x, _player.transform.position.y + (Time.deltaTime * _moveSpeed));
        if (Input.GetKey(KeyCode.A))
            _player.transform.position = new Vector2(_player.transform.position.x - (Time.deltaTime * _moveSpeed), _player.transform.position.y);
        if (Input.GetKey(KeyCode.S))
            _player.transform.position = new Vector2(_player.transform.position.x, _player.transform.position.y - (Time.deltaTime * _moveSpeed));
        if (Input.GetKey(KeyCode.D))
            _player.transform.position = new Vector2(_player.transform.position.x + (Time.deltaTime * _moveSpeed), _player.transform.position.y);
    }
}