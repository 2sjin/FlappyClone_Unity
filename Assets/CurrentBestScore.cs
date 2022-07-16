using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CurrentBestScore : MonoBehaviour {
    void Start() {
        GetComponent<Text>().text = "Best: " + Score.bestScore.ToString();
    }
}
