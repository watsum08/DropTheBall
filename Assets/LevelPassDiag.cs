using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelPassDiag : MonoBehaviour
{
    public Text text;
    private int minutes;
    private double seconds;
    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<Text>();
    }

    // Update is called once per frame
    public void SetTime(float timer)
    {
        minutes = Mathf.FloorToInt(timer / 60f);
        seconds = Mathf.Floor(timer%60f * 10f) / 10.0;

        text.text = "Time: " + minutes + ":" + seconds.ToString();
        text.text += "\nWow impressive!";
    }
}
