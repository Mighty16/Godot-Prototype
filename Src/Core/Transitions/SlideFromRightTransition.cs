
using Godot;

public class SlideFromRightTransition : AbstractScreenTransition
{

	public SlideFromRightTransition(float duration)
	{
		this.duration = duration;
	}

    public override async void Run(Game game, Tween tween, string path)
    {
        Screen newScreen = game.LoadScreen(path);
		Vector2 startPosition = new Vector2(game.GetViewport().Size.x,0);
		newScreen.Position = startPosition;

		game.AddChild(newScreen);

		tween.InterpolateProperty(
			newScreen, "position", 
			startPosition, 
			new Vector2(0,0),
			duration
		);
		tween.Start();
		await game.ToSignal(tween,"tween_completed");
		game.ChangeCurrentScreen(newScreen);
    }

}