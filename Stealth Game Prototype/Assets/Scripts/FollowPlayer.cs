using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour 
{
    private GameObject _player;
	// Use this for initialization
	void Start () 
    {
        _player = GameObject.Find("Player");
	}
	
	// Update is called once per frame
	void Update () 
    {
        if (gameObject.transform.position.x != _player.transform.position.x)
            gameObject.transform.position = AdjustPosition(_player.transform);
        if (gameObject.transform.position.y != _player.transform.position.y)
            gameObject.transform.position = AdjustPosition(_player.transform);
	}

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Enemy")
            Debug.Log("contact!");
    }

    Vector2 AdjustPosition(Transform player)
    {
        return new Vector2(player.position.x, player.position.y);
    }
}
