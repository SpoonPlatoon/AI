using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GoneHome
{

    public class PatrolEnemy : MonoBehaviour
    {
        public Transform waypointGroup;
        public float movementSpeed = 5f;

        //determines how close you have to be to switch targets
        public float closeness = 1f;

        private Transform[] waypoints;
        private int currentIndex = 0;

        private Vector3 spawnPoint;

        // Use this for initialization
        void Start()
        {
            //Make a copy of the starting position
            spawnPoint = transform.position;

            int length = waypointGroup.childCount;
            waypoints = new Transform[length];
            for (int i = 0; i < length; i++)
            {
                waypoints[i] = waypointGroup.GetChild(i);
            }
        }

        // Update is called once per frame
        void Update()
        {
            //get current waypoint
            Transform current = waypoints[currentIndex];

            //move enemy in direction of current waypoint
            Vector3 position = transform.position;
            Vector3 direction = current.position - position;
            position += direction.normalized * movementSpeed * Time.deltaTime;
            //apply new position
            transform.position = position;

            //check closeness of enemy to current waypoint
            float distance = Vector3.Distance(position, current.position);
            //is the enemy close to the current waypoint
            if (distance <= closeness)
            {
                //switch to nect waypoint
                currentIndex++;
            }

            //is currentIndex greaterthan or equal to length
            if(currentIndex >= waypoints.Length)
            {
                //loop back to start
                currentIndex = 0;
            }
        }

        public void Reset()
        {
            transform.position = spawnPoint;
            currentIndex = 0; //reset current waypoint
        }
    }
}