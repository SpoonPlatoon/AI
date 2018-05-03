using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

namespace GoneHome
{
    public class GameManager : MonoBehaviour
    {

        public void NextLevel()
        {
            //Get the current active scene
            Scene currentScene = SceneManager.GetActiveScene();
            //Load the next build index
            SceneManager.LoadScene(currentScene.buildIndex + 1);
        }

        public void RestartLevel()
        {
            //Get current active scene
            // Scene currentScene = SceneManager.GetActiveScene();
            //Load current scene
            // SceneManager.LoadScene(currentScene.buildIndex);

            //Grab all enemies in the scene into array
            FollowEnemy[] FollowEnemies = FindObjectsOfType<FollowEnemy>();
            PatrolEnemy[] PatrolEnemies = FindObjectsOfType<PatrolEnemy>();

            //Loop through all enemies
            foreach (var enemy in FollowEnemies)
            {
                //reset enemy
                enemy.Reset();
            }


            // Grab the player in the scene
            Player player = FindObjectOfType<Player>();
            // Reset player
            player.Reset();
        }

    }
}