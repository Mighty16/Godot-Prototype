using Godot;
using System;

public class MenuScreen : Screen
{
	public const string PATH = "res://Src/Screens/MenuScreen/MenuScreen.tscn";


	public override void Init()
	{
		GD.Print("MenuScreen _Ready was called");
	}

	public void OnButtonPressed()
	{
		GD.Print("OnButtonPressed() was called");
		Navigator.NavigateTo(LevelScreen.PATH, ScreenTransitions.FADE_TO_BLACK);
	}
}



