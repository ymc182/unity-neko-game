using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class actor : MonoBehaviour
{
	private float width;
	private float height;
	public float speed = 55.0f;
	public float jumpSpeed = 1.0f;
	public GameObject neko;
	// Start is called before the first frame update
	private bool goLeft = false;
	private bool gameStart = false;

	void awake()
	{

	}
	void Start()
	{
		width = (float)Screen.width / 2.0f;
		height = (float)Screen.height / 2.0f;
		Debug.Log("WIDTH:" + width);
		Debug.Log("HEIGHT:" + height);
	}

	// Update is called once per frame
	void Update()
	{

		if (!gameStart && !Input.anyKeyDown) return;
		if (!gameStart) gameStart = true;
		if (Input.touchCount > 0)
		{
			Touch touch = Input.GetTouch(0);
			if (touch.phase == TouchPhase.Stationary || touch.phase == TouchPhase.Moved)
			{
				if (touch.position.x < width)
				{
					transform.position = new Vector2(transform.position.x - speed * Time.deltaTime * 50, transform.position.y);
					transform.rotation = Quaternion.Euler(0, 180, 0);
				}
				else
				{
					transform.position = new Vector2(transform.position.x + speed * Time.deltaTime * 50, transform.position.y);
					transform.rotation = Quaternion.Euler(0, 0, 0);
				}
			}
		}
		if (Input.GetKey(KeyCode.RightArrow))
		{
			transform.position = new Vector2(transform.position.x + speed * Time.deltaTime * 50, transform.position.y);
			transform.rotation = Quaternion.Euler(0, 0, 0);
		}
		if (Input.GetKey(KeyCode.LeftArrow))
		{
			transform.position = new Vector2(transform.position.x - speed * Time.deltaTime * 50, transform.position.y);
			transform.rotation = Quaternion.Euler(0, 180, 0);
		}

	}
	void OnCollisionEnter2D(Collision2D col)
	{
		if (col.gameObject.GetComponent<fallingCoin>() != null)
		{
			col.gameObject.GetComponent<fallingCoin>().addScore();
			col.gameObject.transform.position = new Vector2(Random.Range(-10, 10), 10);
		}
		Debug.Log("OnCollisionEnter2D");
	}
}
