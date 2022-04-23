using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fallingCoin : MonoBehaviour
{
	public GameObject nekoCat;
	public float speed = 0.003f;
	private CircleCollider2D coinCollider;

	public score scoreScript;
	private bool emitted = false;
	// Start is called before the first frame update
	void Start()
	{
		coinCollider = GetComponent<CircleCollider2D>();
		scoreScript = GameObject.Find("score").GetComponent<score>();
	}

	// Update is called once per frame
	void Update()
	{
		/* 		transform.position = new Vector2(transform.position.x, transform.position.y - speed * Time.deltaTime * Random.Range(0.1f, 0.5f)); */
		//
		/* 	if (coinCollider.IsTouching(nekoCat.GetComponent<EdgeCollider2D>()))
			{
				if (!emitted)
				{
					scoreScript.addScore();
					emitted = true;
				}
				transform.position = new Vector2(Random.Range(-10, 10), 10);
				emitted = false;
			} */
		if (transform.position.y < -6)
		{
			transform.position = new Vector2(Random.Range(-10, 10), 10);
		}

	}

	public void addScore()
	{
		scoreScript.addScore();
	}
}
