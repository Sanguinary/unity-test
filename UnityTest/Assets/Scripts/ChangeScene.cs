using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ChangeScene : MonoBehaviour {

    public string thisSceneLabel;
    public string[] scenesToLoad;
    public int[] sceneIDs;

    public GameControl gameControl;

    void Start()
    {
        GameObject go = GameObject.Find("GameControl");
        gameControl = (GameControl)go.GetComponent(typeof(GameControl));
    }

    // Create buttons on screen
    void OnGUI()
    {
        GUI.Label(new Rect(Screen.width / 2 - 100, 30, 200, 30), "Current Scene: " + thisSceneLabel);
        gameControl.textField = GUI.TextField(new Rect(40, Screen.height / 2, 200, 40), gameControl.textField, 25);

        for(int i = 0; i < scenesToLoad.Length; i++){
            if(scenesToLoad.Length % 2 == 0) {
                if(GUI.Button(new Rect((Screen.width / 2 - (Mathf.Floor(scenesToLoad.Length / 2) * 210) + (i * 210)), Screen.height - 50, 200, 40), "Load Scene: " + scenesToLoad[i]))
                {
                    Application.LoadLevel(sceneIDs[i]);
                }
            } else {
                if (GUI.Button(new Rect((Screen.width / 2 - (Mathf.Floor(scenesToLoad.Length / 2) * 210)  + (i * 210) - 100), Screen.height - 50, 200, 40), "Load Scene: " + scenesToLoad[i]))
                {
                    Application.LoadLevel(sceneIDs[i]);
                }
            }
        }
    }
}
