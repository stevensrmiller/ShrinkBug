## Two Labels Do Not Both Shrink if the First is Set to Grow:0 and the Second is Set to Grow:1

There are three ways to reproduce this problem:

Method One - Use the UI Builder:

1. Use the UI Builder to create a UI with a VisualElement with FlexGrow = 1, FlexDirection = row.
2. Add two Labels to the VisualElement with FlexBasis = 150px, FlexShrink = 1.
3. Set the first Label to FlexGrow = 0.
4. Set the second Label to FlexGrow = 1.
5. Use the UI Builder to shrink and grow the UI horizontally.

Observe that when the UI is 300px wide or wider, the first Label does not grow, but the second Label does, which is correct. But then observe that when the UI is less than 300px wide, the first Label does not shrink, but the second Label does, which is NOT correct. See the images in the ScreenCaps folder starting with letters "A" and "B" as illustrations.

Note that if you set the first Label to FlexGrow = 1 and the second Label to FlexGrow = 0, the first Label grows and the second Label does not, when the UI is 300px wide or wider, and both shrink correctly when the UI is less than 300px wide. See the images in the ScreenCaps folder starting with letters "C" and "D" as illustrations.

Method Two - Use UXML and a Custom Inspector:

1. Define the compilation symbol "USE_UXML" and use the custom inspector "MyClassEditor" to inspect a GameObject with a MyClass component.
2. Use the UI Builder to edit the UXML UI definition, and use MyClassEditor to create a custom Inspector.
3. Set the first Label to FlexGrow = 0.
4. Set the second Label to FlexGrow = 1.

In the Unity Editor, shrink and grow the Inspector pane horizontally. When the pane is 300px wide or wider, the first Label does not grow, but the second Label does, which is correct. But then observe that when the UI is less than 300px wide, the first Label does not shrink, but the second Label does, which is NOT correct. See the images in the ScreenCaps folder starting with letters "E" and "F" as illustrations.

Note that if you set the first Label to FlexGrow = 1 and the second Label to FlexGrow = 0, the first Label grows and second Label does not, when the pane is 300px wide or wider, and both shrink correctly when the pane is less than 300px wide. See the images in the ScreenCaps folder starting with letters "G" and "H" as illustrations.

Method Three - Use C# and a Custom Inspector:

1. Undefine the compilation symbol "USE_UXML" and use the custom inspector "MyClassEditor" to inspect a GameObject with a MyClass component.
2. Use C# in MyClassEditor to create the UI and a custom Inspector.
3. Set the first Label to FlexGrow = 0.
4. Set the second Label to FlexGrow = 1.

In the Unity Editor, shrink and grow the Inspector pane horizontally. When the pane is 300px wide or wider, the first Label does not grow, but the second Label does, which is correct. But then observe that when the UI is less than 300px wide, the first Label does not shrink, but the second Label does, which is NOT correct. See the images in the ScreenCaps folder starting with letters "I" and "J" as illustrations.

Note that if you set the first Label to FlexGrow = 1 and the second Label to FlexGrow = 0, the first Label grows and second Label does not, when the pane is 300px wide or wider, and both shrink correctly when the pane is less than 300px wide. See the images in the ScreenCaps folder starting with letters "K" and "L" as illustrations.

In all cases, the first Label does not shrink if it is set to FlexGrow = 0 and the second Label is set to FlexGrow = 1, and both are set to FlextShrink = 1. Both should shrink.
