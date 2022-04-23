using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamePlayController : MonoBehaviour
{
	public score scoreScript;
	public Transform overlay;
	public UnityEngine.UI.Text timeText;
	public UnityEngine.UI.Text finalScoreText;
	public bool gameEnd = false;
	public float countDown;
	// Start is called before the first frame update
	void Start()
	{

		scoreScript = GameObject.Find("score").GetComponent<score>();
		timeText = GameObject.Find("time").GetComponent<UnityEngine.UI.Text>();
		//finalScoreText = GameObject.Find("finalText").GetComponent<UnityEngine.UI.Text>();

	}

	// Update is called once per frame
	void Update()
	{
		countDown -= Time.deltaTime;
		if (countDown <= 0 && !gameEnd)
		{

			gameEnd = true;
			finishGame();
		}
		timeText.text = "Time: " + countDown.ToString("F2");
	}
	void finishGame()
	{
		overlay.gameObject.SetActive(true);
		scoreScript.getScore();
		finalScoreText.text = "Your score is : " + scoreScript.getScore();


		Time.timeScale = 0;
	}
}
