
using Godot;
using System;

public class FadeToColorTransition :AbstractScreenTransition
{
	private static Color normalModulateColor = new Color(1, 1, 1, 1);
	private Color fadeColor;

	public FadeToColorTransition(float duration,Color color)
	{
		this.duration = duration;
		this.fadeColor = color;
	}

    public override async void Run(Game game,Tween tween, string path)
    {
        tween.InterpolateProperty(
			game.currentScreen, "modulate", 
			normalModulateColor, 
			fadeColor, 
			duration
		);
		tween.Start();

		await game.ToSignal(tween,"tween_completed");

		Screen newScreen = game.LoadScreen(path);

		newScreen.Modulate = fadeColor;

		game.ChangeCurrentScreen(newScreen);

		tween.InterpolateProperty(
			game.currentScreen, "modulate", 
			fadeColor, 
			normalModulateColor, 
			duration
		);
		tween.Start();
    }
}