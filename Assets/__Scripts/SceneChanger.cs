using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene : MonoBehaviour
{
    public void SceneChanger(string _sceneName)
    {
        SceneManager.LoadScene(_sceneName);
    }
}
