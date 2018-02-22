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

        private Rigidbody rigid;
        private Transform cam;

        // Use this for initialization
        void Start()
        {
            rigid = GetComponent<Rigidbody>();

            cam = Camera.main.transform;
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
            Vector3 position = transform.position;
            position += inputDir * movementSpeed * Time.deltaTime;
            rigid.MovePosition(position);
        }
    }
}