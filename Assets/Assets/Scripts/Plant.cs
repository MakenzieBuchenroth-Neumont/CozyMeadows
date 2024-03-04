using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plant : MonoBehaviour {
    [SerializeField] int maturityDay = 10;
    [SerializeField] List<GameObject> sprites;
    public int currentDay = 0;
    // Start is called before the first frame update
    void Start() {
        foreach (var sprite in sprites) {
            sprite.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update() {

    }

    public void setActiveSprite() {
        currentDay++;
        switch (currentDay) {
            case 0:
            case 1:
                sprites[0].SetActive(true);
                break;
            case 2:
            case 3:
                sprites[0].SetActive(false);
                sprites[1].SetActive(true);
                break;
            case 4:
            case 5:
                sprites[1].SetActive(false);
                sprites[2].SetActive(true);
                break;
            case 6:
            case 7:
                sprites[2].SetActive(false);
                sprites[3].SetActive(true);
                break;
            case 8:
            case 9:
                sprites[3].SetActive(false);
                sprites[4].SetActive(true);
                break;
            case 10:
                sprites[4].SetActive(false);
                sprites[5].SetActive(true);
                break;

        }
    }
}
