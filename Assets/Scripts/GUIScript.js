#pragma strict

function Start () {

}

function Update () {

}

var MenuSkin : GUISkin;
 
function OnGUI() {
	GUI.skin = MenuSkin;
	GUI.skin.box.wordWrap = true;
    GUI.BeginGroup(new Rect(Screen.width/2-100,Screen.height/2-220,200,100));
	GUI.Box(Rect(0,0,200,60),"Press up or down to move the bullet and press space to fire. The goal is to hit the target.");
	GUI.EndGroup ();
	Debug.Log(Screen.width/2-150);
	Debug.Log(Screen.height/2-150);
}