using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour {
   

    public enum Status
    {
        Active,
        Inactive
    }

    [Tooltip("Panel with the menu items on them. Gets enabled and disabled.")]
    [SerializeField] GameObject UIPanel = null;

    Status status;

    void Start()
    {
        status = Status.Active;
        UIPanel.SetActive(true);
    }

    public void LoadScene(string scene)
    {
        SceneManager.LoadScene(scene);
    }

}
