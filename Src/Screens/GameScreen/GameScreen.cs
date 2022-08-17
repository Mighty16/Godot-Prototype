using Godot;
using System;

public class GameScreen : Screen
{
    public const string PATH ="res://Src/Screens/GameScreen/GameScreen.tscn";

    public override void Init()
    {
        
    }

    public void OnGoToMenuButtonPressed()
    {
        Navigator.NavigateTo(MenuScreen.PATH, ScreenTransitions.FADE_TO_BLACK);
    }

}
