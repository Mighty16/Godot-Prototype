using System;
using Godot;

class ScreenTransitions
{
    public static AbstractScreenTransition SLIDE_FROM_RIGHT = new SlideFromRightTransition(duration: 0.3f);
    public static AbstractScreenTransition FADE_TO_BLACK = new FadeToColorTransition(duration: 0.5f, color:new Color(0,0,0,1));

}