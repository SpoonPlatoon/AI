using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace GoneHome
{
    public class Death : MonoBehaviour
    {
        public UnityEvent onDeath;
       
        //Detect collision with other triggers
        private void OnTriggerEnter(Collider other)
        {
            //have we hit a "DeathZone" or "Enemy"
            if(other.name.Contains("DeathZone") || other.name.Contains("Enemy"))
            {
                //KILL IT
               onDeath.Invoke();
            }

            // if (other.name == "Enemy")
            // {
            //KILL IT
            //    Died();
            // }

        }

    }
}
