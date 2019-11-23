using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IMGUIxuetiao : MonoBehaviour {
    public Slider slider;
    private Rect healthPos; //血条的位置
    private Rect addPos; // 加血按钮的位置
    private Rect subPos; //减血按钮的位置
    private float health = 0.0f; //生命值
    private float temp; //一个临时变量
    // Use this for initialization
    void Start () {

        addPos = new Rect(0, 0, 50, 25);
        subPos = new Rect(50, 0, 50, 25);
    }

    // Update is called once per frame
    void Update () {

    }
    private void OnGUI()
    {
        if (GUI.Button(addPos, "加血"))
        {
            temp = health + 0.1f > 1.0f ? 1.0f : health + 0.1f;
        } else if (GUI.Button(subPos, "减血"))
        {
            temp = health - 0.1f < 0 ? 0.0f: health - 0.1f;
        }
        healthPos = new Rect(Screen.width / 2 - 50, 0, 100, 50);
        health = Mathf.Lerp(health, temp, 0.05f);
        GUI.HorizontalScrollbar(healthPos, 0, health, 0, 1);
    }
}