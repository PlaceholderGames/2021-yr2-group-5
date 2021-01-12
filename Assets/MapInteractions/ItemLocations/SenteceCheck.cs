using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SenteceCheck : MonoBehaviour
{
    public ItemCheck[] _loc;

    public void Check()
    {
        int i = 0;
        bool check = true;
        while (i < _loc.Length)
        {
            if (_loc[i].getItem() == false)
            {
                //print(_loc[i].getItem());
                check = false;
            }
            i++;
        }
        if (check)
        {
            print("Winner Winner Chicken Dinner");
            SceneManager.LoadScene(4);
        }
    }
}
