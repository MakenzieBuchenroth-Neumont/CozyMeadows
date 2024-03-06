using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {
	[SerializeField] GameObject menuUI;

	enum State {
		STARTSCREEN,
		STARTGAME,
		GAME,
		DAYCHANGE
	}

	State currentState = State.GAME;

	private void Update() {
		switch (currentState) {
			case State.STARTSCREEN:
				menuUI.SetActive(true);
				break;
			case State.STARTGAME:
				menuUI.SetActive(false);
				break;
			case State.GAME:
				//test move day forward
				if (Input.GetKeyDown(KeyCode.O)) {
					DayChange();
				}
				break;
			case State.DAYCHANGE:
				var plants = GameObject.FindGameObjectsWithTag("Plant");
				foreach (var plant in plants) {
					if (plant.TryGetComponent(out Plant plantScript)) {
						plantScript.setActiveSprite();
					}
				}
				currentState = State.GAME;
				break;
		}
	}

	public void DayChange() {
		currentState = State.DAYCHANGE;
	}

	public void startGame() {
		currentState = State.STARTGAME;
		// later make it go to save selection
	}

	public void newSave() {
		currentState = State.STARTGAME;
		// later make it go to player creation
	}

	public void exitGame() {
		Application.Quit();
	}
}
