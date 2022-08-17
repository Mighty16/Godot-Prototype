using Godot;
using System;

public abstract class Screen: Node2D
{

	public Game game;

	public Navigator Navigator
	{
		get{return game.Navigator;}
	} 

	public abstract void Init();

	public override void _Ready()
	{
		game = GetParent<Game>();
		Init();
	}
}
