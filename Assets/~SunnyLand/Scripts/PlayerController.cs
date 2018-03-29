using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SunnyLand

{
    public class PlayerController : MonoBehaviour
    {
        public float speed = 5f;
        public int health = 100;
        public int damage = 50;
        public float hitForce = 4f;
        public float damageForce = 4f;
        public float maxVelocity;
        public float maxSlopeAngle = 45;
        [Header("Grounding")]
        public float rayDistance = .5f;
        public bool isGrounded = false;
        [Header("Crouch")]
        public bool isCrouching = false;
        [Header("Jump")]
        public float jumpHeight = 2f;
        public int maxJumpCount = 2;
        public bool isJumping = false;

        private Vector3 groundNormal = Vector3.up;
        private int currentJump = 0;
        private float inputH, inputV;

        // References
        private SpriteRenderer rend;
        private Animator anim;
        private Rigidbody2D rigid;

        #region Unity Functions
        // Use this for initialization
        void Awake()
        {
            rend = GetComponent<SpriteRenderer>();
            anim = GetComponent<Animator>();
            rigid = GetComponent<Rigidbody2D>();
        }

        // Update is called once per frame
        void Update()
        {

        }
        #endregion

        #region Custom Functions
        public void Jump()
        {

        }
        public void Crouch()
        {

        }
        public void unCrouch()
        {

        }
        public void Move(float horizontal)
        {

        }
        public void Hurt(int damage)
        {

        }

        private void PerformClimb()
        {

        }
        private void PerformMove()
        {

        }
        private void PerformJump()
        {

        }

        private void CheckGround(RaycastHit2D hit)
        {

        }
        private void CheckEnemy(RaycastHit2D hit)
        {

        }
        private void DetectClimbable()
        {

        }
        private void DetectGround()
        {

        }
        private void LimitVelocity()
        {

        }
        private void StopClimbing()
        {

        }
        private void EnablePhysics()
        {

        }
        private void DisablePhysics()
        {

        }

        #endregion
    }
}
