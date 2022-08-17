using Godot;
using System;


public class Game : Node2D
{

	private const String CURRENT_SCREEN_NAME = "CurrentScreen";

	public Screen currentScreen;
	
	public Navigator Navigator;

	public override void _Ready()
	{
		currentScreen = GetNode<Screen>(CURRENT_SCREEN_NAME);
		Navigator = new Navigator(this);

	}

	public Screen LoadScreen(string path)
	{
		PackedScene newScene = (PackedScene)ResourceLoader.Load(path);
		return newScene.Instance<Screen>();
	}

	public void ChangeCurrentScreen(Screen newScreen)
	{
		var screen = GetNode<Screen>(CURRENT_SCREEN_NAME);
		if (screen!=null){
			RemoveChild(screen);
			screen.QueueFree();
		}
		newScreen.Name = "CurrentScreen";
		AddChild(newScreen);
		this.currentScreen = newScreen;
	}

}
