using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SunnyLand
{
    [RequireComponent(typeof(PlayerController))]
    public class UserInput : MonoBehaviour
    {
        private PlayerController player;
        private float inputH, inputV;
        private bool isJumping = false, isCrouching = false;

        private void Start()
        {
            player = GetComponent<PlayerController>();
        }

        void Update()
        {
            GetInput();
            player.Move(inputH);
            if(isJumping)
            {
                player.Jump();
            }
            if(isCrouching)
            {
                player.Crouch();
            }
            else
            {
                player.unCrouch();
            }
        }

        void GetInput()
        {
            inputH = Input.GetAxis("Horizontal");
            inputV = Input.GetAxis("Vertical");
            isJumping = Input.GetKeyDown(KeyCode.Space);
            isCrouching = Input.GetKey(KeyCode.LeftControl);

        }
    }
}