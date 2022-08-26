using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Title : MonoBehaviour
{
  private static GUIStyle gui_style = new GUIStyle();
  private static Rect rect = new Rect();
  private static Color title_color = new Color(0.9f, 0.9f, 1.0f, 1.0f);
  private static Color btn_color = new Color(0.0f, 0.7f, 1.0f, 1.0f);
  private static string title_label = "Hello World!";
  private static string btn_label = "START!";
  private static float w = 128.0f;
  private static float h = 32.0f;
  private static float px = Screen.width / 2 - w / 2;
  private static float py = Screen.height / 2 - h / 2;

  void OnGUI()
  {
    gui_style.alignment = TextAnchor.MiddleCenter;
		gui_style.fontSize = 60;
		gui_style.normal.textColor = title_color;
		rect.x = px;
		rect.y = py;
		rect.width = w;
		rect.height = h;
		GUI.Label(rect, title_label, gui_style);

    rect.y += 80;
		gui_style.fontSize = 30;
		gui_style.normal.textColor = btn_color;
    if(GUI.Button(rect, btn_label, gui_style)) {
      SceneManager.LoadScene("MainScene");
    }
  }
}

