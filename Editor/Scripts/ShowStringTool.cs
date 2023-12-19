using UnityEditor;
using UnityEngine;

public class ShowStringTool : EditorWindow
{
    [MenuItem("Tools/Show String Tool")]
    static void ShowWindow()
    {
        GetWindow<ShowStringTool>().Show();
    }

    private void OnGUI()
    {
        if(GUILayout.Button("Show String"))
        {
            // Only For Test
            Debug.Log("Show String Tool");
        }
    }
}
