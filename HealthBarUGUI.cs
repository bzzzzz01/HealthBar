using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBarUGUI : MonoBehaviour
{

    public RectTransform HPbar;
    
    void Update()
    {
        this.gameObject.transform.Translate(Input.GetAxis("Horizontal") * 10 * Time.deltaTime, 0, Input.GetAxis("Vertical") * 10 * Time.deltaTime);
        
        Vector2 vec2 = Camera.main.WorldToScreenPoint(this.gameObject.transform.position);
        HPbar.anchoredPosition = new Vector2(vec2.x - Screen.width / 2 , vec2.y - Screen.height / 2 + 50);
    }

}
