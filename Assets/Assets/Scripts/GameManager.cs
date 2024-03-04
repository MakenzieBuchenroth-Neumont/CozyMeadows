using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
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
                break;
            case State.STARTGAME:
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
}
