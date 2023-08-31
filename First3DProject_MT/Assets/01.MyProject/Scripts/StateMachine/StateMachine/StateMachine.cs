using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GenshinInmpactMovementSystem
{
    public abstract class StateMachine
    {
        protected IState currentState;

        public void ChangeState(IState newState)
        {
            //currentState가 null을 반환하면 Exit 메서드를 호출하지 않음.
            currentState?.Exit();

            currentState = newState;

            currentState.Enter();
        }

        public void HandleInput()
        {
            currentState?.HandleInput();
        }

        public void Update()
        {
            currentState?.Update();
        }

        public void PhysicsUpdate()
        {
            currentState?.PhysicsUpdate();
        }
    }
}
