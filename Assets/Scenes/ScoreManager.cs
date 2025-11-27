using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public int score;
    public GUIStyle monStyle;

    void Start()
    {

    }
    void Update()
    {

    }

    private void OnGUI()
    {
        GUILayout.Label($"Score : {score}", monStyle);
    }
}
