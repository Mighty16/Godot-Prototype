using Godot;
using System;

public class LevelScreen : Screen
{
    public const string PATH ="res://Src/Screens/LevelScreen/LevelScreen.tscn";

    public override void Init()
    {

    }

    public void GoToGameScreenPressed()
    {
        Navigator.NavigateTo(GameScreen.PATH,ScreenTransitions.SLIDE_FROM_RIGHT);
    }

}



