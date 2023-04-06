using System.Collections;
using System.Collections.Generic;
using UnityEditor.UIElements;
using UnityEngine;




public class ToolbarInput : MonoBehaviour
{
    public KeyCode showToolBar = KeyCode.Tab;
    public KeyCode hideToolBar = KeyCode.Escape;

    public GameObject toolbar;
    public Animator animator;


    private void Awake()
    {
       
    }

    private void Update()
    {
        if (Input.GetKeyDown(showToolBar)) { ShowToolbar(); }
        if (Input.GetKeyDown(hideToolBar)) { HideToolbar(); }
    }


    public void ShowToolbar()
    {
        toolbar.SetActive(true);
        animator.SetTrigger("Show");
    }

    public void HideToolbar()
    {
        toolbar.SetActive(false);
        animator.SetTrigger("Hide");
    }
}
