using UnityEngine;
using System.Collections;

public class GameControl : MonoBehaviour {

    public static GameControl control;

    public float health;
    public float experience;
    public string textField = "Default String";

    // Checks if the control object exists, if not, save it
    void Awake() {
        if( control == null){
            DontDestroyOnLoad(gameObject);
            control = this;
        } else if( control != null) {
            Destroy(gameObject);
        }
    }
}
