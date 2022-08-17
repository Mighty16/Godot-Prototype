using System;
using Godot;

public abstract class AbstractScreenTransition{

    protected float duration = 0.5f;
    public float Duration {get {return duration;}}

    public abstract void Run(Game game,Tween tween,string path);

}