using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {
	public float levelStartDelay = 5f;
    public BoardManager boardScript;
	private GameObject startImage;
	private bool doingSetup;

    private int level = 3;
	void Awake ()
    {
        boardScript = GetComponent<BoardManager>();
        InitGame();
	}

	private void onLevelWasLoaded(int index)
	{
		InitGame();
	}

    void InitGame()
    {
		doingSetup = true;
		startImage = GameObject.Find("Image");
		startImage.SetActive(true);
		Invoke("HideImage", levelStartDelay);
        boardScript.SetupScene(level);
    }

	void HideImage()
	{
		startImage.SetActive(false);
		doingSetup = false;
	}


	void Update () {
		
	}
}