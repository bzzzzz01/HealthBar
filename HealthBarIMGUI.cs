using UnityEngine;

public class HealthBarIMGUI : MonoBehaviour
{
    float HP = 0.5f;
    Rect HealthBar;
    Rect minusHP, plusHP;

    void Start()
    {
        HealthBar = new Rect(Screen.width / 2 - 50, Screen.height / 2 - 20, 100, 10);
        minusHP = new Rect(Screen.width / 2 - 50, Screen.height / 2,  50, 20);
        plusHP = new Rect(Screen.width / 2, Screen.height / 2, 50, 20);
    }

    void OnGUI()
    {
        if (GUI.Button(minusHP, "-HP"))
        {
            if (HP > 0.1f)
            {
                HP -= 0.1f;
            }
        }
        if (GUI.Button(plusHP, "+HP"))
        {
            if (HP < 1f)
            {
                HP += 0.1f; 
            }
        }
        GUI.HorizontalScrollbar(HealthBar, 0, HP, 0, 1);
    }
}