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
            //currentState�� null�� ��ȯ�ϸ� Exit �޼��带 ȣ������ ����.
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
