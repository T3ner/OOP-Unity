using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameUI : MonoBehaviour
{
    public GameObject[] vehicle;
    public void startGame()
    {
        SceneManager.LoadScene(1);
    }
    public void exit()
    {
        SceneManager.LoadScene(0);
    }
    public void spawn()
    {
        int toSpawn = Random.Range(0, vehicle.Length);
        Instantiate(vehicle[toSpawn]);
    }
}
