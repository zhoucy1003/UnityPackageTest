using GluonGui.WorkspaceWindow.Views.WorkspaceExplorer.Explorer;
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
            Debug.Log("Show String Tool");
        }
    }
}
