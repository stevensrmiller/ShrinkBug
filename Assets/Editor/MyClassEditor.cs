using UnityEditor;
using UnityEditor.UIElements;
using UnityEngine;
using UnityEngine.UIElements;

[CustomEditor(typeof(MyClass))]
public class MyClassEditor : Editor
{
    public override VisualElement CreateInspectorGUI()
    {
        VisualElement root = new();

#if USE_UXML

        Debug.Log("Using UXML");

        VisualTreeAsset tree = Resources.Load("MyUXML") as VisualTreeAsset;

        tree.CloneTree(root);

#else

        Debug.Log("Using code");
        
        Label one = new();

        one.text = "One";
        one.style.flexBasis = 150;
        one.style.flexShrink = 1;
        one.style.flexGrow = 0;
        one.style.backgroundColor = (Color) new Color32(255, 100, 0, 255);

        Label two = new();

        two.text = "Two";
        two.style.flexBasis = 150;
        two.style.flexShrink = 1;
        two.style.flexGrow = 1;
        two.style.backgroundColor = (Color) new Color32(100, 255, 0, 255);

        root.style.flexDirection = FlexDirection.Row;
        root.style.flexGrow = 1;

        root.Add(one);
        root.Add(two);

#endif

        return root;
    }
}
