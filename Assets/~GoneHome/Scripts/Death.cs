using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GoneHome
{
    public class Death : MonoBehaviour
    {

        void Died()
        {
            //Play animation
            //spawn particles
            //preform other event


            print("The " + name + " has died");
        }

        //Detect collision with other triggers
        private void OnTriggerEnter(Collider other)
        {
            //have we hit a "DeathZone" or "Enemy"
            if(other.name == "DeathZone" || other.name == "Enemy")
            {
                //KILL IT
                Died();
            }

            // if (other.name == "Enemy")
            // {
            //KILL IT
            //    Died();
            // }


            if (other.name == "player")
            {
                audio.Play();
            }

        }

    }
}
