using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class score : MonoBehaviour
{
	private int scored;
	public UnityEngine.UI.Text scoreText;
	private float timer = 0f;
	public float delayAmount;
	// Start is called before the first frame update
	void Start()
	{
		scored = 0;
		delayAmount = 1.5f;
	}

	// Update is called once per frame
	void Update()
	{



	}
	public int getScore()
	{
		return scored;
	}
	public void addScore()
	{
		scored++;
		scoreText.text = "Score: " + scored;
	}
}
