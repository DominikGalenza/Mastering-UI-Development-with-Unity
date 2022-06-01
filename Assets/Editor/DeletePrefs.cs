using UnityEngine;
using UnityEditor;

public class DeletePrefs : EditorWindow
{
    [MenuItem("Edit/Delete All Player Prefs")]
    public static void DeletePlayerPrefs()
    {
        PlayerPrefs.DeleteAll();
        Debug.Log("delete prefs");
    }
}
