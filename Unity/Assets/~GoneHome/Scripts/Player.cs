using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Clean code: CTRL + K + D
// Fold code: CTRL + M + P
// Un-Fold code: CTRL + M + O

namespace GoneHome
{
    public class Player : MonoBehaviour
    {
        public float movementSpeed = 20f;

        public float maxVelocity = 5f;

        public GameObject deathParticles;

        private Rigidbody rigid;
        private Transform cam;
        private Vector3 spawnPoint;

        // Use this for initialization
        void Start()
        {
            rigid = GetComponent<Rigidbody>();

            cam = Camera.main.transform;

            //record the starting point
            spawnPoint = transform.position;
        }

        // Update is called once per frame
        void Update()
        {
            Movement();
        }

        void Movement()
        {
            float inputH = Input.GetAxis("Horizontal");
            float inputV = Input.GetAxis("Vertical");

            Vector3 inputDir = new Vector3(inputH, 0, inputV);

            Transform cam = Camera.main.transform;

            inputDir = Quaternion.AngleAxis(cam.eulerAngles.y, Vector3.up) * inputDir;

            // Moves the position of the rigidbody without 
            // effecting gravity
            // Vector3 position = transform.position;
            // position += inputDir * movementSpeed * Time.deltaTime;
            // rigid.MovePosition(position);

            // Add force in that direction
            rigid.AddForce(inputDir * movementSpeed);

            Vector3 vel = rigid.velocity;
            // If velocity reaches max velocity

            if (vel.magnitude > maxVelocity)
            {
                //cap the velocity
                vel = vel.normalized * maxVelocity;
            }
            // Apply the velocity to rigidbody
            rigid.velocity = vel;
        }

        public void Reset()
        {
            Instantiate(deathParticles, transform.position, transform.rotation);
            // Placing Player in staring point
            transform.position = spawnPoint;

            //reset the velocity to zero
            rigid.velocity = Vector3.zero;
        }
    }
}