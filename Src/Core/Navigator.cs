using Godot;
using System;

public class Navigator
{
    private Game game;
    private Tween transitionTween;

    public Navigator(Game game)
    {
        this.game = game;
        this.transitionTween = game.GetNode<Tween>("TransitionTween");
    }

    public void NavigateTo(string path, AbstractScreenTransition transition)
    {
      transition.Run(game,transitionTween,path);
    }
}