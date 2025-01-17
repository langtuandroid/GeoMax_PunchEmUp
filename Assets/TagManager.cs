using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationTags
{
    public const string PUNCH_0_TRIGGER = "Punch_0";
    public const string PUNCH_1_TRIGGER = "Punch_1";
    public const string PUNCH_2_TRIGGER = "Punch_2";
    
    public const string KICK_0_TRIGGER = "Kick_0";
    public const string KICK_1_TRIGGER = "Kick_1";
    
    public const string IDLE_ANIMATION = "Idle";

}

public class Axis
{
    public const string HORIZONTAL_AXIS = "Horizontal";
    public const string VERTICAL_AXIS = "Vertical";
}

public class Tags
{
    public const string GROUND_TAG = "Ground";
    public const string PLAYER_TAG = "Player";
    public const string ENEMY_TAG = "Enemy";
    
    public const string LEFT_ARM_TAG = "LeftArm";
    public const string LEFT_LEG_TAG = "LeftLeg";
    public const string UNTAGGED_TAG = "Untagged";
    public const string MAIN_CAMERA_TAG = "MainCamera";
    public const string HEALTH_UI = "HealthUI";
}
