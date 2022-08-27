using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    private static GUIStyle gui_style = new GUIStyle();
    private static Rect rect = new Rect();
    private static Color clear_color = new Color(0.2f, 1.0f, 0.2f, 0.9f);
    private static string clear_label = "Game Clear!";

    void OnGUI()
    {
        if (Enemy.count == 0)
        {
            gui_style.alignment = TextAnchor.MiddleCenter;
            gui_style.fontSize = 40;
            gui_style.fontStyle = FontStyle.Bold;
            gui_style.normal.textColor = clear_color;
            rect.x = Screen.width / 2;
            rect.y = Screen.height / 2;
            rect.width = 0;
            rect.height = 0;
            GUI.Label(rect, clear_label, gui_style);

            /* rect.y += 80; */
            /* gui_style.fontSize = 30; */
            /* gui_style.normal.textColor = btn_color; */
            /* if (GUI.Button(rect, btn_label, gui_style)) */
            /* { */
            /*     SceneManager.LoadScene("TitleScene"); */
            /* } */
        }
    }
}
