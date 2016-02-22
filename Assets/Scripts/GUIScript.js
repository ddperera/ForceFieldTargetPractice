#pragma strict

function Start () {

}

function Update () {

}

var MenuSkin : GUISkin;
 
function OnGUI() {
	GUI.skin = MenuSkin;
	GUI.skin.box.wordWrap = true;
    GUI.BeginGroup(new Rect(50,50,250,300));
	GUI.Box(Rect(0,0,200,80),"Press up or down to move the bullet and press space to fire. The goal is to hit the target. Enter resets the level.");
	GUI.EndGroup ();
	Debug.Log(Screen.width/2-150);
	Debug.Log(Screen.height/2-150);
}