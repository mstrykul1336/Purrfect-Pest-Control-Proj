using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelController : MonoBehaviour
{
    Monster[] _monsters;

    void OnEnable()
    {
        _monsters = FindObjectsOfType<Monster>();
    }

    void Update()
    {
        if(MonstersAreAllDead())
        {
            GoToNextLevel();
        }
    }

    void GoToNextLevel()
    {
        //debug logs add ~optimization~ issues so no more debug sorry jason :(
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    bool MonstersAreAllDead()
    {
        foreach(var monster in _monsters)
        {
            if(monster.gameObject.activeSelf)
            {
                return false;
            }
        }
        return true;
    }

}
