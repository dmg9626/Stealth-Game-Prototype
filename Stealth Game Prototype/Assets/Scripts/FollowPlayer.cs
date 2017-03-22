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
            gameObject.transform.position = new Vector2(_player.transform.position.x, gameObject.transform.position.y);
        if (gameObject.transform.position.y != _player.transform.position.y)
            gameObject.transform.position = new Vector2(gameObject.transform.position.x, _player.transform.position.y);
	}

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Enemy")
            Debug.Log("contact!");
    }
}
