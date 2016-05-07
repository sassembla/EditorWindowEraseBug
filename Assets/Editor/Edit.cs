

using UnityEditor;

public class SampleEditWindow : EditorWindow {
	
	[MenuItem("Window/SampleEditWindow")] static void ShowEditor() {
		EditorWindow.GetWindow<SampleEditWindow>(typeof(SceneView));
	}
}