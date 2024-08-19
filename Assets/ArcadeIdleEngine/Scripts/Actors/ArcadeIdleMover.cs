﻿using ArcadeBridge.ArcadeIdleEngine.Interactables;
using UnityEngine;

namespace ArcadeBridge.ArcadeIdleEngine.Actors
{
    public class ArcadeIdleMover : MonoBehaviour, IInteractor
    {
        [SerializeField] Rigidbody _rbd;
        [SerializeField] ActorMovementData actorMovementData;
        [SerializeField] HumanoidAnimationManager _humanoidAnimationManager;
        [SerializeField] InputChannel inputChannel;

        Vector3 _currentInputVector;

        bool IInteractor.Interactable => _currentInputVector.sqrMagnitude < 0.2f;

        void OnEnable()
        {
            inputChannel.JoystickUpdate += OnJoystickUpdate;
        }

        void OnDisable()
        {
            inputChannel.JoystickUpdate -= OnJoystickUpdate;
        }

        void FixedUpdate()
        {
            _rbd.velocity = new Vector3(_currentInputVector.x, _rbd.velocity.y, _currentInputVector.z);
        }

        void OnJoystickUpdate(Vector2 newMoveDirection)
        {
            if (newMoveDirection.magnitude >= 1f)
            {
                newMoveDirection.Normalize();
            }

            _currentInputVector = new Vector3(newMoveDirection.x * actorMovementData.SideMoveSpeed, 0f, newMoveDirection.y * actorMovementData.ForwardMoveSpeed);
            _humanoidAnimationManager.PlayMove(newMoveDirection);
            Vector3 lookDir = new Vector3(_currentInputVector.x, 0f, _currentInputVector.z);
            if (lookDir != Vector3.zero)
            {
                transform.rotation = Quaternion.LookRotation(lookDir, Vector3.up);
            }
        }
    }
}