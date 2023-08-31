using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace GenshinInmpactMovementSystem
{
    public class PlayerMovementStateMachine : StateMachine
    {
        public GenshinPlayer GenshinPlayer { get; }
        public PlayerIdlingState IdlingState { get; }
        public PlayerWalkingState WalkingState { get; }
        public PlayerRunningState RunningState { get; }
        public PlayerSprintingState SprintingState { get; }

        public PlayerMovementStateMachine(GenshinPlayer genshinPlayer)
        {
            GenshinPlayer = genshinPlayer;

            IdlingState = new PlayerIdlingState(this);

            WalkingState = new PlayerWalkingState(this);
            RunningState = new PlayerRunningState(this);
            SprintingState = new PlayerSprintingState(this);
        }
    }
}
