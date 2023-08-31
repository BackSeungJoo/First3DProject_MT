using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GenshinInmpactMovementSystem
{
    [RequireComponent(typeof(PlayerInput))]
    public class GenshinPlayer : MonoBehaviour
    {
        public Rigidbody rigidbody { get; private set; }
        public Transform MainCameraTransform { get; private set; }
        public PlayerInput Input { get; private set; }

        private PlayerMovementStateMachine movementStateMachine;

        private void Awake()
        {
            rigidbody = GetComponent<Rigidbody>();
            Input = GetComponent<PlayerInput>();
            movementStateMachine = new PlayerMovementStateMachine(this);
            MainCameraTransform = Camera.main.transform;
        }
        private void Start()
        {
            movementStateMachine.ChangeState(movementStateMachine.IdlingState);
        }

        private void Update()
        {
            movementStateMachine.HandleInput();

            movementStateMachine.Update();
        }

        private void FixedUpdate()
        {
            movementStateMachine.PhysicsUpdate();
        }
    }
}

